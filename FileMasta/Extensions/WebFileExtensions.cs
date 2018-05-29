using System;
using System.Net;

namespace FileMasta.Extensions
{
    class WebFileExtensions
    {
        /// <summary>
        /// Gets web file last modified date
        /// </summary>
        /// <param name="FileURL"></param>
        /// <returns></returns>
        public static DateTime FileLastModified(string FileURL)
        {
            try
            {
                Program.log.Info("Requesting file modified date from web file");

                var req = WebRequest.Create(FileURL);
                req.Method = "HEAD";
                req.Timeout = 7000;
                using (var fileResponse = (HttpWebResponse)req.GetResponse())
                    if (fileResponse.LastModified != null)
                    {
                        Program.log.Info("Successfully returned file modified date from web file");
                        return fileResponse.LastModified;
                    }
                    else
                        return DateTime.MinValue;
            }
            catch (Exception ex) { Program.log.Error("Error requesting file modified date from web file", ex); return DateTime.MinValue; }
        }

        /// <summary>
        /// Gets web file size in bytes
        /// </summary>
        /// <param name="FileURL"></param>
        /// <returns></returns>
        public static int FileSize(string FileURL)
        {
            try
            {
                Program.log.Info("Requesting file size from web file");

                var req = WebRequest.Create(FileURL);
                req.Method = "HEAD";
                req.Timeout = 7000;
                using (var fileResponse = (HttpWebResponse)req.GetResponse())
                    if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out int ContentLength))
                    {
                        Program.log.Info("Successfully returned file size from web file");
                        return ContentLength;
                    }
                    else
                        return 0;
            }
            catch (Exception ex) { Program.log.Error("Error requesting file size from web file", ex); return 0; }
        }

        /// <summary>
        /// Gets web file size in bytes
        /// </summary>
        /// <param name="FileURL"></param>
        /// <returns></returns>
        public static bool FileExists(string FileURL)
        {
            try
            {
                Program.log.Info("Requesting file from web");

                var req = WebRequest.Create(FileURL);
                req.Timeout = 90000; // miliseconds

                try
                {
                    using (var fileResponse = (HttpWebResponse)req.GetResponse())
                        return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex) { Program.log.Error("Error requesting file from web", ex); return false; }
        }
    }
}