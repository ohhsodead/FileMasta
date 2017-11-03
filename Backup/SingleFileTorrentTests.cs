using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Collections;

namespace torrent.libtorrent
{
    [TestFixture]
    public class SingleFileTorrentTests
    {
       
        Torrent torrent;       

        [SetUp]
        public void SetUp()
        {
            torrent = TorrentTestUtils.CreateSingleFileTorrent();  
        }       

        [Test]
        public void GetAnnounceUrl()
        {          
            Assert.AreEqual(new Uri("http://localhost:82"), torrent.AnnounceUri);
        }

        [Test]
        public void NumberOfFiles()
        {  
            Assert.AreEqual(1, torrent.Files.Count);
            
        }

        [Test]
        public void PieceLength()
        {
            Assert.AreEqual(512 * 1024L, torrent.PieceLength);
        }

        [Test]
        public void Pieces()
        {
            Assert.AreEqual(new byte[20], torrent.Pieces[0]);
            Assert.AreEqual(new byte[20], torrent.Pieces[1]);
        }

        [Test]
        public void FilesName()
        {
            Assert.AreEqual("test", torrent.Files[0].Name);
        }

        [Test]
        public void FileLength()
        {
            Assert.AreEqual(512 * 1024 + 256 * 1024, torrent.Files[0].Length);
        }

        [Test]
        public void NumberOfPieces()
        {
            Assert.AreEqual(2, torrent.Pieces.Count);
        }

        [Test]
        public void Hash()
        {
            Assert.AreEqual(20, torrent.InfoHash.Value.Length);
            Assert.AreEqual(40, torrent.InfoHash.ToHexString().Length);
            Assert.AreEqual("2511167C5282E94B646E0A450B5502D6007BC65F",
                torrent.InfoHash.ToHexString());
        }
    }
}
