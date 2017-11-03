using System.Net;

namespace torrent.libtorrent
{
    public class PeerInfo
    {
        public PeerInfo(byte[] ip, short port)
        {
            IpAddress = new IPAddress(ip);
            Port = IPAddress.NetworkToHostOrder(port);
        }
        public IPAddress IpAddress;
        public short Port;
    }
}