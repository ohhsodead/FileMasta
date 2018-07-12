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
        const string dbOpenFiles = "https://www.dropbox.com/s/0dwmqk1pkj2ndkz/ftp-files.json?raw=true";
        const string dbOpenServers = "https://raw.githubusercontent.com/HerbL27/FileMasta/master/Public/ftp-servers.txt";
        public const string dbTopSearches = "https://www.dropbox.com/s/512qe4ogan92vea/top-searches.txt?raw=true";

        /// <summary>
        /// Database file names
        /// </summary>
        const string fileNameFiles = "ftp-files.json";
        const string fileNameServers = "ftp-servers.txt";

        /// <summary>
        /// Checks if database files exists at users data directory, if so whether they're 
        /// the same size, and downloads the latest one if either return false 
        /// </summary>
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
            catch (Exception ex)
            {
                Program.log.Error($"Failed to update {fileNameFiles}", ex);
                MessageBox.Show(MainForm.Form, "Unable to update database.\n\n" + ex.Message);
            }
            finally
            { 
                // Deserializes database first line containing meta info
                MainForm.DbMetaData = JsonConvert.DeserializeObject<Metadata>(File.ReadLines($"{LocalExtensions.pathData}{fileNameFiles}").First());

                // Store files in the main form, skipping the first line as it contains the db metadata
                foreach (var item in File.ReadAllLines($"{LocalExtensions.pathData}{fileNameFiles}").Skip(1))
                    if (StringExtensions.IsValidJSON(item))
                        MainForm.DbOpenFiles.Add(JsonConvert.DeserializeObject<FtpFile>(item));
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
        /// Checks if local file needs to be updated
        /// </summary>
        /// <param name="webFile">String URL of the file to check for update</param>
        /// <param name="fileName">File name, used to check local directory</param>
        /// <returns></returns>
        public static bool IsFileOutOfDate(string webFile, string fileName)
        {
            try
            {
                Program.log.Info($"Checking if '{fileName}' needs to be updated");

                if (File.Exists($"{LocalExtensions.pathData}{fileName}"))
                    if (WebExtensions.WebFileSize($"{webFile}") == new FileInfo($"{LocalExtensions.pathData}{fileName}").Length)
                        return false;
                    else
                        return true;
                else
                    return true;
            }
            catch (Exception ex) { Program.log.Error($"Unable to check '{fileName}' for update, URL : {webFile}", ex); return true; }
        }

        /// <summary>
        /// Total size of all files in database
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public static long TotalFilesSize()
        {
            long totalSize = 0;

            foreach (var jsonData in MainForm.DbOpenFiles)
                totalSize += jsonData.Size;

            return totalSize;
        }

        /// <summary>
        /// Get web file info from internal database, or creates a new object if it doesn't exist
        /// </summary>
        /// <param name="URL">Used to match with WebFile.URL to return class</param>
        /// <returns>WebFile object</returns>
        public static FtpFile FtpFile(string URL)
        {
            // Checks loaded files for a matching URL and returns the Web File object
            foreach (var file in MainForm.DbOpenFiles) 
                if (file.URL == URL)
                    return file;
        
            // Create a new Web File object as this URL doesn't exist in the database there anymore
            var newWebFile = new FtpFile(Path.GetFileName(new Uri(URL).LocalPath), WebExtensions.FtpFileSize(URL), WebExtensions.FtpFileTimestamp(URL), new Uri(URL).AbsoluteUri);

            // Add the new Web File to this instance of application
            MainForm.DbOpenFiles.Add(newWebFile);

            // Return the new Web File
            return newWebFile;
        }
    }
}