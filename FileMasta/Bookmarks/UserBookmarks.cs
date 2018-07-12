using System;
using System.Collections.Generic;
using System.IO;
using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.Models;
using FileMasta.Utilities;
using Newtonsoft.Json;

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
            using (StreamWriter Bookmarked = File.AppendText(LocalExtensions.pathBookmarks))
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
            if (File.Exists(LocalExtensions.pathBookmarks))
                TextLineRemover.RemoveTextLines(new List<string> { JsonConvert.SerializeObject(new Bookmark(URL)) }, LocalExtensions.pathBookmarks, LocalExtensions.pathBookmarks + ".tmp");
        }

        /// <summary>
        /// Checks if json string exists in Bookmarked Files
        /// </summary>
        /// <param name="URL">URL to check for</param>
        /// <returns>Whether URL is bookmarked</returns>
        public static bool IsBookmarked(string URL)
        {
            if (File.Exists(LocalExtensions.pathBookmarks))
                using (StreamReader reader = new StreamReader(LocalExtensions.pathBookmarks))
                    while (!reader.EndOfStream)
                    {
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
        public static List<FtpFile> BookmarkedFiles()
        {
            Program.log.Info("Getting users bookmarks files");

            var filesBookmarks = new List<FtpFile>();
            if (File.Exists(LocalExtensions.pathBookmarks))
                using (StreamReader reader = new StreamReader(LocalExtensions.pathBookmarks))
                    while (!reader.EndOfStream)
                        try
                        {
                            var jsonData = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());
                            filesBookmarks.Add(Database.FtpFile(jsonData.URL));
                        }
                        catch (Exception ex)
                        {
                            Program.log.Error("Unable to get bookmarks", ex);
                        }

            Program.log.Info("Users bookmarks returned successful");

            return filesBookmarks;
        }

        /// <summary>
        /// Removes all items in bookmarks
        /// </summary>
        public static void ClearBookmarks()
        {
            Program.log.Info("Clearing all bookmarks");

            var filesBookmarks = new List<FtpFile>();
            if (File.Exists(LocalExtensions.pathBookmarks))
                using (StreamWriter stream = File.CreateText(LocalExtensions.pathBookmarks))
                    stream.Flush();

            Program.log.Info("Bookmarks cleared successfully");
        }
    }
}