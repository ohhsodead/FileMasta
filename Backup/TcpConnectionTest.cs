using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace torrent.libtorrent
{
    [TestFixture]
    public class TcpConnectionTest
    {
        private bool connected;

        [Test]
        public void MakeConnection()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(new IPEndPoint(IPAddress.Loopback, 1234));
            s.Listen(4);
            s.BeginAccept(new AsyncCallback(AcceptForTest), s);
            TcpConnection connection = new TcpConnection("localhost", 1234);
            connected = false;
            connection.connect(new ConnectionCallBack(ConnectionEstablished));
            Thread.Sleep(100);
            s.Close();
            Assert.IsTrue(connected);
        }

        private void ConnectionEstablished()
        {
            connected = true;
        }

        private void AcceptForTest(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            Socket accepted = s.EndAccept(ar);
            accepted.Close();
        }
    }
}
