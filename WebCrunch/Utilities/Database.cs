using Extensions;
using Models;
using Newtonsoft.Json;
using System;
using System.IO;
using WebCrunch;

namespace Utilities
{
    class Database
    {
        /// <summary>
        /// Get file info from local database
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
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
