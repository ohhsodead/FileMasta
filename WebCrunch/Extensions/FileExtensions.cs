using System;
using System.IO;
using System.Net;

namespace WebCrunch.Extensions
{
    class FileExtensions
    {
        /// <summary>
        /// Checks if database file exists at users data directory, if so whether they're the same size, and downloads the latest one if either returns false
        /// </summary>
        /// <param name="webFile"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsLocalAndServerFileSizeEqual(string webFile, string fileName)
        {
            try
            {
                Program.log.Info($"Checking if file '{fileName}' needs to be updated");

                if (File.Exists(LocalExtensions.pathData + fileName)) {
                    var req = WebRequest.Create(webFile);
                    req.Method = "HEAD";
                    //req.Timeout = 1250;
                    using (var fileResponse = (HttpWebResponse)req.GetResponse()) {
                        if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out int ContentLength)) {
                            if (new FileInfo(LocalExtensions.pathData + fileName).Length == ContentLength)
                                return true;
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                }
                else
                    return false;
            }
            catch (Exception ex) { Program.log.Error($"Error checking file '{fileName}' for update", ex); return false;  }
        }

        /// <summary>
        /// Gets web file last modified date
        /// </summary>
        /// <param name="webUrl"></param>
        /// <returns></returns>
        public static DateTime GetFileLastModified(string webUrl)
        {
            try {
                Program.log.Info("Requesting file modified date from web file");

                WebRequest req = WebRequest.Create(webUrl);
                req.Method = "HEAD";
                req.Timeout = 7000;
                using (var fileResponse = (HttpWebResponse)req.GetResponse()) {
                    var fileModifiedTime = fileResponse.LastModified;
                    if (fileModifiedTime != null) {
                        Program.log.Info("Successfully returned file modified date from web file");
                        return fileModifiedTime;
                    }
                    else
                        return DateTime.MinValue;
                }
            }
            catch (Exception ex) { Program.log.Error("Error requesting file modified date from web file", ex); return DateTime.MinValue; }
        }

        /// <summary>
        /// Gets web file size
        /// </summary>
        /// <param name="webUrl"></param>
        /// <returns></returns>
        public static int GetFileSize(string webUrl)
        {
            try {
                Program.log.Info("Requesting file size from web file");

                var req = WebRequest.Create(webUrl);
                req.Method = "HEAD";
                req.Timeout = 7000;
                using (var fileResponse = (HttpWebResponse)req.GetResponse()) {
                    if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out int ContentLength)) {
                        Program.log.Info("Successfully returned file size from web file");
                        return ContentLength;
                    }
                    else
                        return 0;
                }
            }
            catch (Exception ex) { Program.log.Error("Error requesting file size from web file", ex); return 0; }
        }

        /// <summary>
        /// Checks for exact file name of a subtitle file that matches the web filename (e.g. File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
        /// </summary>
        /// <param name="fileURL"></param>
        /// <returns></returns>
        public static bool HasExistingLocalSubtitles(string fileURL)
        {
            if (File.Exists(LocalExtensions.userDownloadsDirectory + Path.GetFileNameWithoutExtension(new Uri(fileURL).LocalPath) + ".srt"))
                return true;
            else
                return false;
        }
    }
}