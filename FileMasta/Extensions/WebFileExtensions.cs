using System;
using System.Net;

namespace FileMasta.Extensions
{
    class WebFileExtensions
    {

        /// <summary>
        /// Gets web file last modified date
        /// </summary>
        /// <param name="WebFileURL"></param>
        /// <returns></returns>
        public static DateTime GetFileLastModified(string WebFileURL)
        {
            try {
                Program.log.Info("Requesting file modified date from web file");

                WebRequest req = WebRequest.Create(WebFileURL);
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
        /// <param name="WebFileURL"></param>
        /// <returns></returns>
        public static int GetFileSize(string WebFileURL)
        {
            try {
                Program.log.Info("Requesting file size from web file");

                var req = WebRequest.Create(WebFileURL);
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
    }
}