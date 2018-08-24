using System;
using FileMasta.Utilities;

namespace FileMasta.Extensions
{
    class LocalExtensions
    {
        /// <summary>
        /// User's directories
        /// </summary>
        public static string PathRoot { get; } = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\FileMasta\";
        public static string PathData { get; } = $@"{PathRoot}Data\";
        public static string PathDownloadsDirectory { get; } = $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\";
        public static string PathBookmarks { get; } = $@"{PathRoot}bookmarked.json";

        /// <summary>
        /// Supported media players
        /// </summary>
        public const string _pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public const string _pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public const string _pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public const string _pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";
        public const string _pathKMPlayer = @"C:\KMPlayer\KMPlayer.exe";
        public const string _pathPotPlayer = @"C:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe";

        /// <summary>
        /// Supported PDF viewers
        /// </summary>
        public const string _pathNitroReader = @"C:\Program Files\Nitro\Reader 5\NitroPDFReader.exe";

        /// <summary>
        /// Supported download managers
        /// </summary>
        public const string _pathIDM64 = @"C:\Program Files\Internet Download Manager\IDMan.exe";
        public const string _pathIDM86 = @"C:\Program Files (x86)\Internet Download Manager\IDMan.exe";
        public const string _pathFDM = @"C:\Program Files\FreeDownloadManager.ORG\Free Download Manager\fdm.exe";
        public const string _pathIDA = @"C:\Program Files (x86)\IDA\ida.exe";

        /// <summary>
        /// Supported FTP clients
        /// </summary>
        public const string _pathFileZilla = @"C:\Program Files\FileZilla FTP Client\filezilla.exe";
    }
}