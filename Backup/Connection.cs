using System;
using System.Collections.Generic;
using System.Text;

namespace torrent.libtorrent
{
    delegate void ConnectionCallBack();
    interface  Connection
    {
        void connect(ConnectionCallBack callback);
    }
}
