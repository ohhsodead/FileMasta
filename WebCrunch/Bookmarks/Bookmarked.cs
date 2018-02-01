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
        /// Returns string form of file objects
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Name"></param>
        /// <param name="Type"></param>
        /// <param name="Host"></param>
        /// <returns></returns>
        public static string fileToJson(string Url, string Name, string Type, string Host)
        {
            return JsonConvert.SerializeObject(new WebFile(Type, Name, 0, default(DateTime), Host, Url));
        }

        /// <summary>
        /// Remove json string from Bookmarks
        /// </summary>
        /// <param name="Json"></param>
        public static void unsaveFile(string Json)
        {
            if (File.Exists(MainForm.pathDataBookmarked))
            {
                TextLineRemover.RemoveTextLines(new List<string> { Json }, MainForm.pathDataBookmarked, MainForm.pathDataBookmarked + ".tmp");
            }
        }

        /// <summary>
        /// Add json string to Bookmarks
        /// </summary>
        /// <param name="Json"></param>
        public static void saveFile(string Json)
        {
            using (StreamWriter Bookmarked = File.AppendText(MainForm.pathDataBookmarked))
            {
                Bookmarked.WriteLine(Json);
                Bookmarked.Flush();
            }
        }

        /// <summary>
        /// Checks if json string exists in Bookmarked Files
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static bool isBookmarked(string URL)
        {
            if (File.Exists(MainForm.pathDataBookmarked))
            {
                using (StreamReader reader = new StreamReader(MainForm.pathDataBookmarked))
                {
                    while (!reader.EndOfStream)
                    {
                        var a = JsonConvert.DeserializeObject<WebFile>(reader.ReadLine());

                        if (a.URL == URL)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}