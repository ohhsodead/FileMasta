using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using WebCrunch;

namespace Extensions
{
    class LocalExtensions
    {
        /// <summary>
        /// Check for internet connection
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
        /// Returns local files from specified source/directory
        /// </summary>
        /// <param name="SourceFolder"></param>
        /// <param name="Filter"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        public static string[] GetFiles(string SourceFolder, string Filter, SearchOption searchOption)
        {
            // ArrayList will hold all file names
            ArrayList allFiles = new ArrayList();

            // Create an array of filter string
            string[] MultipleFilters = Filter.Split('|');

            // for each filter find mathing file names
            foreach (string FileFilter in MultipleFilters)
                // add found file names to array list
                allFiles.AddRange(Directory.GetFiles(SourceFolder, FileFilter, searchOption));

            // returns string array of relevant file names
            return (string[])allFiles.ToArray(typeof(string));
        }

        /// <summary>
        /// Open and select local file
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
