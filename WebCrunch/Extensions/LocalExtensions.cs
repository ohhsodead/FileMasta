using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace WebCrunch.Extensions
{
    class LocalExtensions
    {
        /// <summary>
        /// Check for internet connection
        /// </summary>
        /// <returns></returns>
        public static bool checkForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://google.com"))
                {
                    return true;
                }
            }
            catch { return false; }
        }

        /// <summary>
        /// Returns local files from specified source/directory
        /// </summary>
        /// <param name="SourceFolder"></param>
        /// <param name="Filter"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        public static string[] getFiles(string SourceFolder, string Filter, SearchOption searchOption)
        {
            // ArrayList will hold all file names
            ArrayList alFiles = new ArrayList();

            // Create an array of filter string
            string[] MultipleFilters = Filter.Split('|');

            // for each filter find mathing file names
            foreach (string FileFilter in MultipleFilters)
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(SourceFolder, FileFilter, searchOption));
            }

            // returns string array of relevant file names
            return (string[])alFiles.ToArray(typeof(string));
        }

        /// <summary>
        /// Open and select local file
        /// </summary>
        /// <param name="path"></param>
        public static void openFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            // combine the arguments together
            // it doesn't matter if there is a space after ','
            string argument = "/select, \"" + path + "\"";

            Process.Start("explorer.exe", argument);
        }
    }
}
