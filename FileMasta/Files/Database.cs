using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using FileMasta.Extensions;
using FileMasta.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileMasta.Files
{
    class Database
    {
        /// <summary>
        /// URLs for database files
        /// </summary>
        public static string UrlOpenFiles { get; } = "https://www.dropbox.com/s/charfmjveo2v1h3/open-files.json?raw=true";
        public static string UrlTopSearches { get; } = "https://www.dropbox.com/s/512qe4ogan92vea/top-searches.txt?raw=true";
        public static string UrlOpenDirectories { get; } = "https://raw.githubusercontent.com/HerbL27/FileMasta/master/Public/open-directories.txt";
        
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
        /// Total size of all files in database
        /// </summary>
        /// <returns>Total Size as Long</returns>
        public static long GetTotalFileSize()
        {
            long totalSize = 0;

            foreach (var jsonData in MainForm.FilesOpenDatabase)
                totalSize += jsonData.Size;

            return totalSize;
        }

        /// <summary>
        /// Get database stats
        /// </summary>
        /// <returns></returns>
        public static DateTime GetLastUpdateDate()
        {
            DateTime updateDate = DateTime.MinValue;

            if (TextExtensions.IsValidJSON(MainForm.DatabaseInfo))
            {
                var dataJsonInfo = JsonConvert.DeserializeObject<DatabaseInfo>(MainForm.DatabaseInfo);
                updateDate = dataJsonInfo.LastUpdated;
            }

            return updateDate;
        }

        /// <summary>
        /// Gets some recently added files in the database by checking if file was uploaded in the last two weeks
        /// </summary>
        /// <returns></returns>
        public static List<WebFile> GetRecentlyAddedFiles()
        {
            var recentlyAddedFiles = new List<WebFile>();

            int itemCount = 1;
            var addedHosts = new List<string>();
            Program.log.Info("Getting recently added files");
            var copiedItems = new List<WebFile>(MainForm.FilesOpenDatabase);
            copiedItems.Shuffle();
            foreach (var jsonData in copiedItems)
                if (DateTime.Today < jsonData.DateUploaded.Date.AddDays(14) && jsonData.Size > 0 && !addedHosts.Contains(jsonData.Host) && itemCount <= 6)
                {
                    itemCount++;
                    addedHosts.Add(jsonData.Host);
                    recentlyAddedFiles.Add(jsonData);
                }

            Program.log.Info("Recently added files successful");

            return recentlyAddedFiles;
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