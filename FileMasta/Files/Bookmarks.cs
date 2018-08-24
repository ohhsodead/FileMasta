using System;
using System.Collections.Generic;
using System.IO;
using FileMasta.Extensions;
using FileMasta.Models;
using FileMasta.Utilities;
using Newtonsoft.Json;

namespace FileMasta.Files
{
    class Bookmarks
    {
        /// <summary>
        /// Add File URL to Bookmarks
        /// </summary>
        /// <param name="url">URL to add</param>
        public static void AddFile(string url)
        {
            using (StreamWriter Bookmarked = File.AppendText(LocalExtensions.PathBookmarks))
            {
                var a = JsonConvert.SerializeObject(new Bookmark(url));
                Bookmarked.WriteLine(a);
                Bookmarked.Flush();
            }
        }

        /// <summary>
        /// Remove File URL from Bookmarks
        /// </summary>
        /// <param name="url">URL to remove</param>
        public static void RemoveFile(string url)
        {
            if (File.Exists(LocalExtensions.PathBookmarks))
                TextLineRemover.RemoveTextLines(new List<string> { JsonConvert.SerializeObject(new Bookmark(url)) }, LocalExtensions.PathBookmarks, LocalExtensions.PathBookmarks + ".tmp");
        }

        /// <summary>
        /// Checks if json string exists in Bookmarked Files
        /// </summary>
        /// <param name="url">URL of the File</param>
        /// <returns>Whether URL is bookmarked</returns>
        public static bool IsBookmarked(string url)
        {
            if (File.Exists(LocalExtensions.PathBookmarks))
                using (StreamReader reader = new StreamReader(LocalExtensions.PathBookmarks))
                    while (!reader.EndOfStream)
                    {
                        var a = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());
                        if (a.URL == url)
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
            Program.Log.Info("Getting users bookmarks files");

            var filesBookmarks = new List<FtpFile>();
            if (File.Exists(LocalExtensions.PathBookmarks))
                using (StreamReader reader = new StreamReader(LocalExtensions.PathBookmarks))
                    while (!reader.EndOfStream)
                        try
                        {
                            var jsonData = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());
                            filesBookmarks.Add(Database.FtpFile(jsonData.URL));
                        }
                        catch (Exception ex)
                        {
                            Program.Log.Error("Unable to get bookmarks", ex);
                        }

            Program.Log.Info("Users bookmarks returned successful");

            return filesBookmarks;
        }

        /// <summary>
        /// Removes all items in bookmarks
        /// </summary>
        public static void ClearBookmarks()
        {
            Program.Log.Info("Clearing all bookmarks");

            var filesBookmarks = new List<FtpFile>();
            if (File.Exists(LocalExtensions.PathBookmarks))
                using (StreamWriter stream = File.CreateText(LocalExtensions.PathBookmarks))
                    stream.Flush();

            Program.Log.Info("Bookmarks cleared successfully");
        }
    }
}