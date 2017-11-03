using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace torrent.libtorrent
{
    class TorrentTestUtils
    {
        internal static Torrent CreateMultiFileTorrent()
        {
            Hashtable metainfo = new Hashtable();
            Hashtable info = new Hashtable();
            ArrayList files = new ArrayList();
            Hashtable file1 = new Hashtable();
            Hashtable file2 = new Hashtable();
            ArrayList file1Path = new ArrayList(
                new ByteString[] { new ByteString("dir1"), new ByteString("file1") });
            ArrayList file2Path = new ArrayList(
                new ByteString[] { new ByteString("dir1"), new ByteString("dir2"), new ByteString("file2") });

            metainfo["announce"] = new ByteString("http://localhost:82/announce");
            metainfo["info"] = info;

            info["name"] = new ByteString("test");
            info["piece length"] = 512 * 1024L;
            info["pieces"] = new ByteString(new byte[40]);
            info["files"] = files;
            files.Add(file1);
            files.Add(file2);

            file1["length"] = 512 * 1024L;
            file1["path"] = file1Path;

            file2["length"] = 256 * 1024L;
            file2["path"] = file2Path;

            return new Torrent(metainfo);
        }

        internal static Torrent CreateSingleFileTorrent()
        {
            Hashtable metainfo = new Hashtable();
            Hashtable info = new Hashtable();
            metainfo["announce"] = new ByteString("http://localhost:82");
            info["name"] = new ByteString("test");
            info["length"] = 512 * 1024L + 256 * 1024L;
            info["piece length"] = 512 * 1024L;
            info["pieces"] = new ByteString(new byte[40]);
            metainfo["info"] = info;
            return new Torrent(metainfo);
        }

    }    
}
