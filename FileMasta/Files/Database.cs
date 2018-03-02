using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using FileMasta.Extensions;
using FileMasta.Models;

namespace FileMasta.Files
{
    class Database
    {
        /// <summary>
        /// URLs for database files
        /// </summary>
        public static string UrlOpenFiles { get; } = "https://dl.dropbox.com/s/charfmjveo2v1h3/open-files.json?dl=0";
        public static string UrlOpenDirectories { get; } = "https://raw.githubusercontent.com/HerbL27/FileMasta/master/API/open-directories.txt";
        public static string UrlTopSearches { get; } = "https://dl.dropbox.com/s/512qe4ogan92vea/top-searches.txt?dl=0";

        /* Runs in the background on load event.
         * Checks if database file exists at users data directory, if so whether they're
         * the same size, and downloads the latest one if either return false */
        public static void UpdateLocalDatabase()
        {
            Program.log.Info("Checking for database updates");

            if (UpdateLocalDatabaseFiles(UrlOpenDirectories, "open-directories.txt"))
            {
                using (var client = new WebClient()) { client.DownloadFile(new Uri(UrlOpenDirectories), $"{LocalExtensions.pathData}open-directories.txt"); }
                Program.log.Info("open-directories.txt updated");
            }
            MainForm.DataOpenDirectories.AddRange(File.ReadAllLines($"{LocalExtensions.pathData}open-directories.txt"));

            if (UpdateLocalDatabaseFiles(UrlOpenFiles, "open-files.json"))
            {
                using (var client = new WebClient()) { client.DownloadFile(new Uri(UrlOpenFiles), $"{LocalExtensions.pathData}open-files.json"); }
                Program.log.Info("open-files.json updated");
            }

            // Retrieve database items, skipping the first line (contains the meta info)
            foreach (var item in File.ReadAllLines($"{LocalExtensions.pathData}open-files.json").Skip(1))
                if (TextExtensions.IsValidJSON(item))
                    MainForm.FilesOpenDatabase.Add(JsonConvert.DeserializeObject<WebFile>(item));

            MainForm.DatabaseInfo = File.ReadLines($"{LocalExtensions.pathData}open-files.json").First(); // Gets first line in database which contains info
        }

        /// <summary>
        /// Checks if database file exists at users data directory, if so whether they're the same size, and downloads the latest one if either returns true
        /// </summary>
        /// <param name="webFile">String URL of the file to check for update</param>
        /// <param name="fileName">File name, used to check local directory</param>
        /// <returns></returns>
        public static bool UpdateLocalDatabaseFiles(string webFile, string fileName)
        {
            try
            {
                Program.log.Info($"Checking if file '{fileName}' needs to be updated");

                if (File.Exists(LocalExtensions.pathData + fileName))
                {
                    var req = WebRequest.Create(webFile);
                    req.Method = "HEAD";
                    using (var fileResponse = (HttpWebResponse)req.GetResponse())
                    {
                        if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out int ContentLength))
                            if (new FileInfo(LocalExtensions.pathData + fileName).Length == ContentLength)
                                return false;
                            else
                                return true;
                        else
                            return true;
                    }
                }
                else
                    return true;
            }
            catch (Exception ex) { Program.log.Error($"Unable to check database file '{fileName}' for update, URL : {webFile}", ex); return true; }
        }

        /// <summary>
        /// Get web file info from internal database, or creates a new object if it doesn't exist
        /// </summary>
        /// <param name="URL">Matches URL with WebFile.URL to return object</param>
        /// <returns>WebFile object</returns>
        public static WebFile FileInfoFromURL(string URL)
        {
            // Checks loaded files for a matching URL and returns the Web File object
            foreach (var file in MainForm.FilesOpenDatabase) 
                if (file.URL == URL)
                    return file;
        
            // Create a new Web File object as this URL doesn't exist in the database there anymore
            var newWebFile = new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), WebFileExtensions.GetFileSize(URL), WebFileExtensions.GetFileLastModified(URL), new Uri(URL).Host.Replace("www.", ""), new Uri(URL).AbsoluteUri);

            // Add the new Web File to current local database
            MainForm.FilesOpenDatabase.Add(newWebFile);

            // Return the new Web File
            return newWebFile;
        }
    }
}