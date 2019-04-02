using FileMasta.Extensions;
using FileMasta.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileMasta.Data
{
    internal static class DataHelper
    {
        private static string AppDataPath { get; } = $@"{Application.UserAppDataPath}\";
        public static string DatabaseFilePath { get; } = $@"{AppDataPath}{AppExtensions.DatabaseFilename}";
        public static string SavedFilePath { get; } = $@"{AppDataPath}{AppExtensions.SavedFilename}";
        
        public static WebFile CreateFile(string fileUrl)
        {
            return new WebFile(Path.GetFileName(fileUrl), FtpExtensions.GetFileSize(fileUrl), FtpExtensions.GetFileLastModified(fileUrl), fileUrl);
        }

        /// <summary>
        /// Retrieve list of keywords from database
        /// </summary>
        /// <returns>List containing all keywords returned</returns>
        public static IEnumerable<string> GetSearchKeywords()
        {
            return HttpExtensions.GetFileContents("https://www.dropbox.com/s/4x2nypfiyuoyxjj/searches.txt?raw=true");
        }
    }
}
