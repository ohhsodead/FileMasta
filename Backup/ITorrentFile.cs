using System;
namespace torrent.libtorrent
{
    public interface ITorrentFile
    {
        long Length { get; }
        string Name { get; }
    }
}
