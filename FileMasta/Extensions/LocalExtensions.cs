using System;
using System.Runtime.InteropServices;

namespace FileMasta.Extensions
{
    internal static class LocalExtensions
    {
        /// <summary>
        /// Supported media players
        /// </summary>
        public const string PathVlc = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public const string PathMpcCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public const string PathMpc64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public const string PathMpc86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";
        public const string PathKmPlayer = @"C:\KMPlayer\KMPlayer.exe";
        public const string PathPotPlayer = @"C:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe";

        /// <summary>
        /// Supported PDF viewers
        /// </summary>
        public const string PathNitroReader = @"C:\Program Files\Nitro\Reader 5\NitroPDFReader.exe";

        /// <summary>
        /// Supported download managers
        /// </summary>
        public const string PathIdm64 = @"C:\Program Files\Internet Download Manager\IDMan.exe";
        public const string PathIdm86 = @"C:\Program Files (x86)\Internet Download Manager\IDMan.exe";
        public const string PathFdm = @"C:\Program Files\FreeDownloadManager.ORG\Free Download Manager\fdm.exe";
        public const string PathIda = @"C:\Program Files (x86)\IDA\ida.exe";
    }

    /// <summary>
    /// Class containing methods to retrieve specific file system paths.
    /// </summary>
    public static class KnownFolders
    {
        private static readonly string[] KnownFoldersGuid = new string[]
        {
        "{56784854-C6CB-462B-8169-88E350ACB882}", // Contacts
        "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}", // Desktop
        "{FDD39AD0-238F-46AF-ADB4-6C85480369C7}", // Documents
        "{374DE290-123F-4565-9164-39C4925E467B}", // Downloads
        "{1777F761-68AD-4D8A-87BD-30B759FA33DD}", // Favorites
        "{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}", // Links
        "{4BD8D571-6D19-48D3-BE97-422220080E43}", // Music
        "{33E28130-4E1E-4676-835A-98395C3BC3BB}", // Pictures
        "{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}", // SavedGames
        "{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}", // SavedSearches
        "{18989B1D-99B5-455B-841C-AB7C74E4DDFC}", // Videos
        };

        /// <summary>
        ///     Gets the current path to the specified known folder as currently configured. This does
        ///     not require the folder to be existent.
        /// </summary>
        /// <param name="knownFolder">The known folder which current path will be returned.</param>
        /// <param name="defaultUser">Specifies if the paths of the default user (user profile template) will be used.
        ///     This requires administrative rights.</param>
        /// <returns>The default path of the known folder.</returns>
        /// <exception cref="ExternalException">Thrown if the path could not be retrieved.</exception>
        public static string GetPath(KnownFolder knownFolder, bool defaultUser = false)
        {
            return GetPath(knownFolder, KnownFolderFlags.DoNotVerify, defaultUser);
        }

        private static string GetPath(KnownFolder knownFolder, KnownFolderFlags flags,
            bool defaultUser)
        {
            int result = SHGetKnownFolderPath(new Guid(KnownFoldersGuid[(int)knownFolder]),
                (uint)flags, new IntPtr(defaultUser ? -1 : 0), out IntPtr outPath);
            if (result >= 0)
            {
                return Marshal.PtrToStringUni(outPath);
            }
            else
            {
                throw new ExternalException("Unable to retrieve the known folder path. It may not "
                    + "be available on this system.", result);
            }
        }

        [DllImport("Shell32.dll")]
        private static extern int SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)]Guid rfid, uint dwFlags, IntPtr hToken,
            out IntPtr pszPath);

        [Flags]
        private enum KnownFolderFlags : uint
        {
            SimpleIdList = 0x00000100,
            NotParentRelative = 0x00000200,
            DefaultPath = 0x00000400,
            Init = 0x00000800,
            NoAlias = 0x00001000,
            DoNotVerify = 0x00004000,
            Create = 0x00008000,
            NoAppContainerRedirection = 0x00010000,
            AliasOnly = 0x80000000
        }
    }

    /// <summary>
    /// Standard folders registered with the system. These folders are installed with Windows Vista
    /// and later operating systems, and a computer will have only folders appropriate to it installed.
    /// </summary>
    public enum KnownFolder
    {
        Contacts,
        Desktop,
        Documents,
        Downloads,
        Favorites,
        Links,
        Music,
        Pictures,
        SavedGames,
        SavedSearches,
        Videos
    }
}