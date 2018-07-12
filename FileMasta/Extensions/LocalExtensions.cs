using System;
using System.IO;
using FileMasta.Utilities;

namespace FileMasta.Extensions
{
    class LocalExtensions
    {
        /// <summary>
        /// User's directories
        /// </summary>
        public static string pathRoot = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\FileMasta\";
        public static string pathData = $@"{pathRoot}Data\";
        public static string pathDownloadsDirectory = $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\";
        public static string pathVideosDirectory = $@"{KnownFolders.GetPath(KnownFolder.Videos)}\";
        public static string pathMusicDirectory = $@"{KnownFolders.GetPath(KnownFolder.Music)}\";
        public static string pathDocumentsDirectory = $@"{KnownFolders.GetPath(KnownFolder.Documents)}\";
        public static string pathDesktopDirectory = $@"{KnownFolders.GetPath(KnownFolder.Desktop)}\";
        public static string pathBookmarks = $@"{pathRoot}bookmarked.json";

        /// <summary>
        /// Supported media players
        /// </summary>
        public const string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public const string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public const string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public const string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";
        public const string pathKMPlayer = @"C:\KMPlayer\KMPlayer.exe";
        public const string pathPotPlayer = @"C:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe";

        /// <summary>
        /// Supported PDF viewers
        /// </summary>
        public const string pathNitroReader = @"C:\Program Files\Nitro\Reader 5\NitroPDFReader.exe";

        /// <summary>
        /// Supported download managers
        /// </summary>
        public const string pathIDM64 = @"C:\Program Files\Internet Download Manager\IDMan.exe";
        public const string pathIDM86 = @"C:\Program Files (x86)\Internet Download Manager\IDMan.exe";
        public const string pathFDM = @"C:\Program Files\FreeDownloadManager.ORG\Free Download Manager\fdm.exe";
        public const string pathIDA = @"C:\Program Files (x86)\IDA\ida.exe";

        /// <summary>
        /// Checks for exact file name of a subtitle file that matches the web filename (e.g. File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
        /// </summary>
        /// <param name="fileURL"></param>
        /// <returns></returns>
        public static bool IsSubtitlesAvailable(string fileURL)
        {
            if (File.Exists(pathDownloadsDirectory + Path.GetFileNameWithoutExtension(new Uri(fileURL).LocalPath) + ".srt"))
                return true;
            else
                return false;
        }
    }
}