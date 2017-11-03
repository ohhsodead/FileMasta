using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Collections;

namespace torrent.libtorrent
{
    [TestFixture]
    public class MultiFileTorrentTest
    {               
        Torrent torrent;        

        [SetUp]
        public void SetUp()
        {
            torrent = TorrentTestUtils.CreateMultiFileTorrent();
        }

        
        [Test]
        public void NumberOfFiles()
        {
            Assert.AreEqual(2, torrent.Files.Count);
        }

        [Test]
        public void FileNames()
        {
            Assert.AreEqual("test\\dir1\\file1", torrent.Files[0].Name);
            Assert.AreEqual("test\\dir1\\dir2\\file2", torrent.Files[1].Name);
        }

        [Test]
        public void FileLengths()
        {
            Assert.AreEqual(512 * 1024L, torrent.Files[0].Length);
            Assert.AreEqual(256 * 1024L, torrent.Files[1].Length);
        }
    }
}
