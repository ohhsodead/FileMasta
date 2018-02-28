using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.Models;
using FileMasta.Utilities;

namespace FileMasta.Bookmarks
{
    class UserBookmarks
    {
        /// <summary>
        /// Add File URL to Bookmarks
        /// </summary>
        /// <param name="URL">URL to add</param>
        public static void AddFile(string URL)
        {
            using (StreamWriter Bookmarked = File.AppendText(LocalExtensions.pathDataBookmarked))
            {
                var a = JsonConvert.SerializeObject(new Bookmark(URL));
                Bookmarked.WriteLine(a);
                Bookmarked.Flush();
            }
        }

        /// <summary>
        /// Remove File URL from Bookmarks
        /// </summary>
        /// <param name="URL">URL to remove</param>
        public static void RemoveFile(string URL)
        {
            if (File.Exists(LocalExtensions.pathDataBookmarked))            
                TextLineRemover.RemoveTextLines(new List<string> { JsonConvert.SerializeObject(new Bookmark(URL)) }, LocalExtensions.pathDataBookmarked, LocalExtensions.pathDataBookmarked + ".tmp");
        }

        /// <summary>
        /// Checks if json string exists in Bookmarked Files
        /// </summary>
        /// <param name="URL">URL to check for</param>
        /// <returns>Whether URL is bookmarked</returns>
        public static bool IsBookmarked(string URL)
        {
            if (File.Exists(LocalExtensions.pathDataBookmarked))
                using (StreamReader reader = new StreamReader(LocalExtensions.pathDataBookmarked))
                    while (!reader.EndOfStream) {
                        var a = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());
                        if (a.URL == URL)                        
                            return true;                    
                    }

            return false;
        }

        /// <summary>
        /// Load bookmarked files
        /// </summary>
        /// <returns>Bookmark item as a WebFile</returns>
        public static List<WebFile> GetBookmarks()
        {
            Program.log.Info("Getting users bookmarks files");

            var filesBookmarks = new List<WebFile>();
            if (File.Exists(LocalExtensions.pathDataBookmarked))
                using (StreamReader reader = new StreamReader(LocalExtensions.pathDataBookmarked))
                    while (!reader.EndOfStream)
                        try
                        {
                            var jsonData = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());
                            filesBookmarks.Add(Database.FileInfoFromURL(jsonData.URL));
                        }
                        catch (Exception ex)
                        {
                            Program.log.Error("Unable to get bookmarks", ex);
                        }

            Program.log.Info("Users bookmarks returned successful");

            return filesBookmarks;
        }
    }
}