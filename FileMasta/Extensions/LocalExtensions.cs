using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using FileMasta.Models;
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
        public static string pathDataBookmarked = $"{pathRoot}bookmarked-files.json";
        public static string userDownloadsDirectory = $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\";

        /// <summary>
        /// Supported media players
        /// </summary>
        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public static string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public static string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public static string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";

        /// <summary>
        /// Checks for internet connection by attempting to connect to Google.com
        /// </summary>
        /// <returns></returns>
        public static bool CheckForInternetConnection()
        {
            try
            {
                Program.log.Info("Checking for internet connection");
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://google.com")) {
                    Program.log.Info("Internet connection detected");
                    return true;
                }
            }
            catch (Exception ex) { Program.log.Error("Error, no internet connection detected", ex); return false; }
        }

        /// <summary>
        /// Checks for exact file name of a subtitle file that matches the web filename (e.g. File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
        /// </summary>
        /// <param name="fileURL"></param>
        /// <returns></returns>
        public static bool HasExistingSubtitle(string fileURL)
        {
            if (File.Exists(userDownloadsDirectory + Path.GetFileNameWithoutExtension(new Uri(fileURL).LocalPath) + ".srt"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Gets local files (supported in this app) from user's /Downloads directory
        /// </summary>
        /// <returns>Local files from /Downloads as a WebFile</returns>
        public static List<WebFile> GetLocalFiles()
        {
            Program.log.Info("Getting users local files");

            var filesLocal = new List<WebFile>();
            foreach (var pathFile in Directory.GetFiles(userDownloadsDirectory, "*.*", SearchOption.AllDirectories))
                filesLocal.Add(new WebFile(
                    Path.GetExtension(pathFile).Replace(".", "").ToUpper(),
                    Path.GetFileNameWithoutExtension(pathFile),
                    new FileInfo(pathFile).Length,
                    File.GetCreationTime(pathFile),
                    "Local",
                    pathFile));

            Program.log.Info("Users local files returned successful");

            return filesLocal;
        }

        /// <summary>
        /// Open and select file in File Explorer
        /// </summary>
        /// <param name="path"></param>
        public static void OpenFile(string path)
        {
            if (!File.Exists(path))
                return;            

            Process.Start("explorer.exe", "/select, \"" + path + "\"");
        }
    }
}
