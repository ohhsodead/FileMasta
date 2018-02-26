using System;
using System.IO;
using WebCrunch.Extensions;
using WebCrunch.Models;

namespace WebCrunch.Files
{
    class Database
    {
        /// <summary>
        /// URLs for file database
        /// </summary>
        public static string urlOpenFiles { get; } = "https://dl.dropbox.com/s/charfmjveo2v1h3/open-files.json?dl=0";
        public static string urlOpenDirectories { get; } = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/API/open-directories.txt";
        public static string urlTopSearches { get; } = "https://dl.dropbox.com/s/512qe4ogan92vea/top-searches.txt?dl=0";

        /// <summary>
        /// Get web file info from internal database, or creates a new object
        /// </summary>
        /// <param name="URL">WebFile.URL to return</param>
        /// <returns>WebFile object</returns>
        public static WebFile FileInfoFromURL(string URL)
        {
            // Checks loaded files for a matching URL and returns the Web File object
            foreach (var file in MainForm.filesOpenDatabase) 
                if (file.URL == URL)
                    return file;
        
            // Create a new Web File object as this URL doesn't exist in the database there anymore
            var newWebFile = new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), FileExtensions.GetFileSize(URL), FileExtensions.GetFileLastModified(URL), new Uri(URL).Host.Replace("www.", ""), new Uri(URL).AbsoluteUri);

            // Add the new Web File to current local database
            MainForm.filesOpenDatabase.Add(newWebFile);

            // Return the new Web File
            return newWebFile;
        }
    }
}