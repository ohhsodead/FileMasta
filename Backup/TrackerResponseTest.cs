using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using NUnit.Framework;

namespace torrent.libtorrent
{
    [TestFixture]
    public class TrackerResponseTest
    {
        [Test]
        public void CompactResponse()
        {
            TrackerResponse tr = new TrackerResponse(CreateTestResponseString());
            Assert.AreEqual(1, tr.NumberOfSeeds);
            Assert.AreEqual(2, tr.NumberOfLeechers);
        }

        [Test]
        public void CompactResponseAddresses()
        {
            TrackerResponse tr = new TrackerResponse(CreateTestResponseString());
            Assert.AreEqual(IPAddress.Parse("127.0.0.1"), tr.Peers[0].IpAddress);
            Assert.AreEqual(6881, tr.Peers[0].Port);
            Assert.AreEqual(IPAddress.Parse("207.142.131.248"), tr.Peers[1].IpAddress);
            Assert.AreEqual(6882, tr.Peers[1].Port);
            Assert.AreEqual(IPAddress.Parse("105.100.107.120"), tr.Peers[2].IpAddress);
            Assert.AreEqual(6883, tr.Peers[2].Port);
        }

        public static ByteString CreateTestResponseString()
        {
            Hashtable response = new Hashtable();
            response["interval"] = 10;
            response["tracker id"] = "some tracker id";
            response["complete"] = 1;
            response["incomplete"] = 2;
            response["peers"] = new ByteString(new byte[] { 127, 0, 0, 1, 0x1a, 0xe1, 207, 142, 131, 248, 0x1a, 0xe2, 105, 100, 107, 120, 0x1a, 0xe3 });
            ByteString encodedResponseBody = new ByteString(BEncoder.Encode(response));
            return new ByteString(string.Format("HTTP/1.1 OK\r\n\r\n{0}", encodedResponseBody.ToString()));
        }

        [Test]
        public void FailureMessage()
        {
            TrackerResponse response = new TrackerResponse(new ByteString("HTTP/1.0 200 OK\r\n\r\n" +
                                    "d14:failure reason56:unsupported tracker protocol, please upgrade your cliente"));
            Assert.IsFalse(response.IsSuccessful);
            Assert.AreEqual(response.FailureReason, "unsupported tracker protocol, please upgrade your client");
        }
    }
}
