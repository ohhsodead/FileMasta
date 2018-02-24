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
        public static string urlOpenFiles = "https://dl.dropbox.com/s/charfmjveo2v1h3/open-files.json?dl=0";
        public static string urlTopSearches = "https://dl.dropbox.com/s/512qe4ogan92vea/top-searches.txt?dl=0";
        public static string urlOpenDirectories = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/API/open-directories.txt";

        /// <summary>
        /// Get web file info from internal database, or creates a new object
        /// </summary>
        /// <param name="URL"></param>
        /// <returns>WebFile object</returns>
        public static WebFile FileInfoFromURL(string URL)
        {
            /* Checks loaded files for a matching URL and returns the Web File object */
            foreach (var file in MainForm.filesOpenDatabase) 
                if (file.URL == URL)
                    return file;
        
            /* Create a new Web File object as this URL doesn't exist in there anymore */
            var newWebFile = new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), FileExtensions.GetFileSize(URL), FileExtensions.GetFileLastModified(URL), new Uri(URL).Host.Replace("www.", ""), new Uri(URL).AbsoluteUri);

            /* Add new Web File object to local database */
            MainForm.filesOpenDatabase.Add(newWebFile);

            /* Return the new Web File object */
            return newWebFile;
        }
    }
}
