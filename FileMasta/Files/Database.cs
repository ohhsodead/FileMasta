using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using FileMasta.Extensions;
using FileMasta.Models;
using Newtonsoft.Json;

namespace FileMasta.Files
{
    class Database
    {
        /// <summary>
        /// URLs for database files
        /// </summary>
        public const string dbOpenFiles = "https://www.dropbox.com/s/charfmjveo2v1h3/open-files.json?raw=true";
        public const string dbOpenDirectories = "https://raw.githubusercontent.com/HerbL27/FileMasta/master/Public/open-directories.txt";
        public const string dbTopSearches = "https://www.dropbox.com/s/512qe4ogan92vea/top-searches.txt?raw=true";

        /// <summary>
        /// Database file names
        /// </summary>
        const string fileNameOpenFiles = "open-files.json";
        const string fileNameOpenDirectories = "open-directories.txt";

        /* Checks if database files exists at users data directory, if so whether they're
         * the same size, and downloads the latest one if either return false */
        public static void UpdateLocalDatabase()
        {
            Program.log.Info("Starting database updates");

            try
            {
                if (IsFileOutOfDate(dbOpenFiles, fileNameOpenFiles))
                {
                    using (var client = new WebClient())
                        client.DownloadFile(new Uri(dbOpenFiles), $"{LocalExtensions.pathData}{fileNameOpenFiles}");
                    Program.log.Info($"{fileNameOpenFiles} updated");
                }
            }
            catch (WebException webEx)
            {
                Program.log.Error($"UPDATE FAILED {fileNameOpenFiles}", webEx);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + webEx.Message);
            }
            catch (Exception ex)
            {
                Program.log.Error($"UPDATE FAILED {fileNameOpenFiles}", ex);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + ex.Message);
            }
            finally
            {
                // Store files in the main form, skipping the first line as it contains the db metadata
                foreach (var item in File.ReadAllLines($"{LocalExtensions.pathData}{fileNameOpenFiles}").Skip(1))
                    if (StringExtensions.IsValidJSON(item))
                        MainForm.FilesOpenDatabase.Add(JsonConvert.DeserializeObject<WebFile>(item));

                MainForm.DatabaseInfo = File.ReadLines($"{LocalExtensions.pathData}{fileNameOpenFiles}").First(); // Gets first line in database which contains info
            }

            try
            {
                if (IsFileOutOfDate(dbOpenDirectories, fileNameOpenDirectories))
                {
                    using (var client = new WebClient())
                        client.DownloadFile(new Uri(dbOpenDirectories), $"{LocalExtensions.pathData}{fileNameOpenDirectories}");
                    Program.log.Info($"{fileNameOpenDirectories} updated");
                }
            }
            catch (WebException webEx)
            {
                Program.log.Error($"UPDATE FAILED {fileNameOpenDirectories}", webEx);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + webEx.Message);
            }
            catch (Exception ex)
            {
                Program.log.Error($"UPDATE FAILED {fileNameOpenDirectories}", ex);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + ex.Message);
            }
            finally
            {
                MainForm.DataOpenDirectories.AddRange(File.ReadAllLines($"{LocalExtensions.pathData}{fileNameOpenDirectories}"));
            }            
        }

        /// <summary>
        /// Checks if local database needs to be updated
        /// </summary>
        /// <param name="webFile">String URL of the file to check for update</param>
        /// <param name="fileName">File name, used to check local directory</param>
        /// <returns></returns>
        public static bool IsFileOutOfDate(string webFile, string fileName)
        {
            try
            {
                Program.log.Info($"Checking if file '{fileName}' needs to be updated");

                if (File.Exists(LocalExtensions.pathData + fileName))
                    if (WebFileExtensions.FileSize($"{webFile}") == new FileInfo(LocalExtensions.pathData + fileName).Length)
                        return false;
                    else
                        return true;
                else
                    return true;
            }
            catch (Exception ex) { Program.log.Error($"Unable to check database file '{fileName}' for update, URL : {webFile}", ex); return true; }
        }

        /// <summary>
        /// Total size of all files in database
        /// </summary>
        /// <returns>Total Size as Long</returns>
        public static long TotalFilesSize()
        {
            long totalSize = 0;

            foreach (var jsonData in MainForm.FilesOpenDatabase)
                totalSize += jsonData.Size;

            return totalSize;
        }

        /// <summary>
        /// Gets last database update time
        /// </summary>
        /// <returns></returns>
        public static DateTime LastUpdate()
        {
            if (StringExtensions.IsValidJSON(MainForm.DatabaseInfo))
                return JsonConvert.DeserializeObject<DatabaseInfo>(MainForm.DatabaseInfo).LastUpdated;

            return DateTime.MinValue;
        }

        /// <summary>
        /// Get web file info from internal database, or creates a new object if it doesn't exist
        /// </summary>
        /// <param name="URL">Used to match with WebFile.URL to return class</param>
        /// <returns>WebFile object</returns>
        public static WebFile WebFile(string URL)
        {
            // Checks loaded files for a matching URL and returns the Web File object
            foreach (var file in MainForm.FilesOpenDatabase) 
                if (file.URL == URL)
                    return file;
        
            // Create a new Web File object as this URL doesn't exist in the database there anymore
            var newWebFile = new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), WebFileExtensions.FileSize(URL), WebFileExtensions.FileLastModified(URL), new Uri(URL).Host.Replace("www.", ""), new Uri(URL).AbsoluteUri);

            // Add the new Web File to this instance of application
            MainForm.FilesOpenDatabase.Add(newWebFile);

            // Return the new Web File
            return newWebFile;
        }
    }
}