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
        public const string dbOpenFiles = "https://www.dropbox.com/s/0dwmqk1pkj2ndkz/ftp-files.json?raw=true";
        public const string dbOpenServers = "https://raw.githubusercontent.com/HerbL27/FileMasta/master/Public/ftp-servers.txt";
        public const string dbTopSearches = "https://www.dropbox.com/s/512qe4ogan92vea/top-searches.txt?raw=true";

        /// <summary>
        /// Database file names
        /// </summary>
        const string fileNameFiles = "ftp-files.json";
        const string fileNameServers = "ftp-servers.txt";

        /* Checks if database files exists at users data directory, if so whether they're
         * the same size, and downloads the latest one if either return false */
        public static void UpdateLocalDatabase()
        {
            Program.log.Info("Starting database updates");

            try
            {
                if (IsFileOutOfDate(dbOpenFiles, fileNameFiles))
                {
                    Program.log.Info($"Updating {fileNameFiles}...");
                    using (var client = new WebClient())
                        client.DownloadFile(new Uri(dbOpenFiles), $"{LocalExtensions.pathData}{fileNameFiles}");
                    Program.log.Info($"{fileNameFiles} updated");
                }
            }
            catch (WebException webEx)
            {
                Program.log.Error($"UPDATE FAILED {fileNameFiles}", webEx);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + webEx.Message);
            }
            catch (Exception ex)
            {
                Program.log.Error($"UPDATE FAILED {fileNameFiles}", ex);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + ex.Message);
            }
            finally
            {
                // Store files in the main form, skipping the first line as it contains the db metadata
                foreach (var item in File.ReadAllLines($"{LocalExtensions.pathData}{fileNameFiles}").Skip(1))
                    if (StringExtensions.IsValidJSON(item))
                        MainForm.DbOpenFiles.Add(JsonConvert.DeserializeObject<WebFile>(item));

                MainForm.DatabaseInfo = File.ReadLines($"{LocalExtensions.pathData}{fileNameFiles}").First(); // Gets first line in database which contains info
            }

            try
            {
                if (IsFileOutOfDate(dbOpenServers, fileNameServers))
                {
                    Program.log.Info($"Updating {fileNameServers}...");
                    using (var client = new WebClient())
                        client.DownloadFile(new Uri(dbOpenServers), $"{LocalExtensions.pathData}{fileNameServers}");
                    Program.log.Info($"{fileNameServers} updated");
                }
            }
            catch (WebException webEx)
            {
                Program.log.Error($"UPDATE FAILED {fileNameServers}", webEx);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + webEx.Message);
            }
            catch (Exception ex)
            {
                Program.log.Error($"UPDATE FAILED {fileNameServers}", ex);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + ex.Message);
            }
            finally
            {
                MainForm.DbOpenServers.AddRange(File.ReadAllLines($"{LocalExtensions.pathData}{fileNameServers}"));
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

                if (File.Exists($"{LocalExtensions.pathData}{fileName}"))
                    if (WebFileExtensions.WebFileSize($"{webFile}") == new FileInfo($"{LocalExtensions.pathData}{fileName}").Length)
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

            foreach (var jsonData in MainForm.DbOpenFiles)
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
                return JsonConvert.DeserializeObject<DatabaseInfo>(MainForm.DatabaseInfo).Updated;

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
            foreach (var file in MainForm.DbOpenFiles) 
                if (file.URL == URL)
                    return file;
        
            // Create a new Web File object as this URL doesn't exist in the database there anymore
            var newWebFile = new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), WebFileExtensions.FtpFileSize(URL), WebFileExtensions.FtpFileTimestamp(URL), new Uri(URL).Host.Replace("www.", ""), new Uri(URL).AbsoluteUri);

            // Add the new Web File to this instance of application
            MainForm.DbOpenFiles.Add(newWebFile);

            // Return the new Web File
            return newWebFile;
        }
    }
}