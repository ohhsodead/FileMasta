using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace WebCrunch.Bookmarks
{
    class Bookmarked
    {
        /// <summary>
        /// Remove URL from Bookmarks
        /// </summary>
        /// <param name="URL"></param>
        public static void UnsaveFile(string URL)
        {
            if (File.Exists(MainForm.pathDataBookmarked))
            {
                TextLineRemover.RemoveTextLines(new List<string> { JsonConvert.SerializeObject(new Bookmark(URL)) }, MainForm.pathDataBookmarked, MainForm.pathDataBookmarked + ".tmp");
            }
        }

        /// <summary>
        /// Add URL to Bookmarks
        /// </summary>
        /// <param name="URL"></param>
        public static void SaveFile(string URL)
        {
            using (StreamWriter Bookmarked = File.AppendText(MainForm.pathDataBookmarked))
            {
                var a = JsonConvert.SerializeObject(new Bookmark(URL));
                Bookmarked.WriteLine(a);
                Bookmarked.Flush();
            }
        }

        /// <summary>
        /// Checks if json string exists in Bookmarked Files
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static bool IsBookmarked(string URL)
        {
            if (File.Exists(MainForm.pathDataBookmarked))
            {
                using (StreamReader reader = new StreamReader(MainForm.pathDataBookmarked))
                {
                    while (!reader.EndOfStream)
                    {
                        var a = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());

                        if (a.URL == URL)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Get file info from local database
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static WebFile FileInfoFromURL(string URL)
        {
            foreach (var file in MainForm.dataOpenFiles)
            {
                if (file.URL == URL)
                {
                    return file;
                }
            }

            return null;
        }
    }
}