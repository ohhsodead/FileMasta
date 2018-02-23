using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WebCrunch.Extensions;
using WebCrunch.Models;
using WebCrunch.Utilities;

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
            if (File.Exists(LocalExtensions.pathDataBookmarked))            
                TextLineRemover.RemoveTextLines(new List<string> { JsonConvert.SerializeObject(new Bookmark(URL)) }, LocalExtensions.pathDataBookmarked, LocalExtensions.pathDataBookmarked + ".tmp");
        }

        /// <summary>
        /// Add URL to Bookmarks
        /// </summary>
        /// <param name="URL"></param>
        public static void SaveFile(string URL)
        {
            using (StreamWriter Bookmarked = File.AppendText(LocalExtensions.pathDataBookmarked)) {
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
            if (File.Exists(LocalExtensions.pathDataBookmarked))
                using (StreamReader reader = new StreamReader(LocalExtensions.pathDataBookmarked))
                    while (!reader.EndOfStream) {
                        var a = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());
                        if (a.URL == URL)                        
                            return true;                    
                    }

            return false;
        }
    }
}