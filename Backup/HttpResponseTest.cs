using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace torrent.libtorrent
{
    [TestFixture]
    public class HttpResponseTest
    {
        [Test]
        public void ParseStatusLine()
        {
            ByteString responseText = new ByteString("HTTP/1.1 200 OK\r\n\r\n");
            HttpResponse response = new HttpResponse(responseText);
            Assert.AreEqual("HTTP/1.1 200 OK", response.StausLine);
        }
        
        [Test]
        public void ParseOneField()
        {
            ByteString responseText = new ByteString("HTTP/1.1 200 OK\r\n" + 
                                                      "Header1: Value1\r\n\r\n");
            HttpResponse response = new HttpResponse(responseText);
            Assert.AreEqual("Value1", response.Fields["Header1"]);
        }
        
        [Test]
        public void ParseTwoFields()
        {
            ByteString responseText = new ByteString("HTTP/1.1 200 OK\r\n" +
                                                      "Header1: Value1\r\n" +
                                                      "Header2: Value2\r\n\r\n");
            HttpResponse response = new HttpResponse(responseText);
            Assert.AreEqual("Value2", response.Fields["Header2"]);
        }
        
        [Test]
        public void ParseContent()
        {
            ByteString responseText = new ByteString("HTTP/1.1 200 OK\r\n" +
                                                      "Header1: Value1\r\n" +
                                                      "Header2: Value2\r\n\r\n" +
                                                      "content");
            HttpResponse response = new HttpResponse(responseText);
            Assert.AreEqual(new ByteString("content"), response.Content);
        }
    }
}
