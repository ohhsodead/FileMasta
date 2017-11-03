using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace torrent.libtorrent
{
    public class TorrentFile : ITorrentFile
    {
        private string name;
        private long length;

        public long Length
        {
            get { return length; }           
        }

        public string Name
        {
            get { return name; }           
        } 
        public TorrentFile(string name, long length)
        {
            this.name = name;
            this.length = length;
        }

        public TorrentFile(string name, IList path, long length)
        {
            List<string> paths = new List<string>();
            foreach (ByteString pathPart in path)
            {
                paths.Add(pathPart.ToString());
            }
            this.name = name + "\\" + string.Join("\\", paths.ToArray());
            this.length = length;
        }
    }

    class PieceList : List<byte[]>
    {
        public PieceList(ByteString pieces)
        {
            byte[] peaceArray = pieces.ToBytes();
            for (int i = 0; i < peaceArray.Length / 20; i++)
            {
                byte[] piece = new byte[20];
                for (int j = 0; j < piece.Length; j++)
                {
                    piece[j] = peaceArray[i * 20 + j];
                }
                base.Add(piece);
            }
        }
    }  

    public class Torrent
    {
        private IDictionary metainfo, info;
        private IList<ITorrentFile> files;       

        public Torrent(IDictionary metainfo)
        {
            this.metainfo = metainfo;
            this.files = new List<ITorrentFile>();
            info = metainfo["info"] as IDictionary;

            if (!info.Contains("files"))
            {
                files.Add(new TorrentFile(info["name"].ToString(), (long)info["length"]));
            }
            else
            {
                IList files = info["files"] as IList;
                foreach (IDictionary file in files)
                {
                    this.files.Add(new TorrentFile(info["name"].ToString(), 
                        file["path"] as IList, (long)file["length"]));
                }
            }
        }

        public Uri AnnounceUri
        {
            get
            {
                return new Uri(metainfo["announce"].ToString());
            }
        }

        public long PieceLength
        {
            get { return (long)info["piece length"]; }
        }

        public IList<byte[]> Pieces
        {
            get
            { 
                return new PieceList(info["pieces"] as ByteString); 
            }
        }

        public IList<ITorrentFile> Files
        {
            get { return files; }
        }

        public Hash InfoHash
        {
            get
            {
                return Hash.Compute(BEncoder.Encode(info));
            }
        }
    }
}
