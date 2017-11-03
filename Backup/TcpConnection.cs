using System;
using System.Net.Sockets;

namespace torrent.libtorrent
{
    internal class TcpConnection : Connection
    {
        private Socket s;
        private string host;
        private int port;

        public TcpConnection(string host, int port)
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.host = host;
            this.port = port;
        }

        public void connect(ConnectionCallBack back)
        {
            s.BeginConnect(host, port, new AsyncCallback(BeginConnectCallback), back);
        }

        private void BeginConnectCallback(IAsyncResult ar)
        {
            s.EndConnect(ar);
            ConnectionCallBack func = (ConnectionCallBack) ar.AsyncState;
            func();
        }
    }
}