using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Utilities;

namespace WebCrunch.SavedFiles
{
    class Saved
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
            var a = new Models.WebFile
            {
                URL = Url,
                Host = Host,
                Name = Path.GetFileNameWithoutExtension(new Uri(Url).LocalPath),
                Type = Type,
                Size = 0,
                DateUploaded = default(DateTime)
            };

            return JsonConvert.SerializeObject(a);
        }

        /// <summary>
        /// Remove json string from Saved Files
        /// </summary>
        /// <param name="Json"></param>
        public static void unsaveFile(string Json)
        {
            if (File.Exists(MainForm.pathDataSaved))
            {
                TextLineRemover.RemoveTextLines(new List<string> { Json }, MainForm.pathDataSaved, MainForm.pathDataSaved + ".tmp");
            }
        }

        /// <summary>
        /// Add json string from Saved Files
        /// </summary>
        /// <param name="Json"></param>
        public static void saveFile(string Json)
        {
            using (StreamWriter saved = File.AppendText(MainForm.pathDataSaved))
            {
                saved.WriteLine(Json);
                saved.Flush();
            }
        }

        /// <summary>
        /// Checks if json string exists in Saved Files
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static bool isSaved(string Json)
        {
            if (File.Exists(MainForm.pathDataSaved))
            {
                using (StreamReader reader = new StreamReader(MainForm.pathDataSaved))
                {
                    while (!reader.EndOfStream)
                    {
                        if (reader.ReadLine() == Json)
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
