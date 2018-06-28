using System;
using System.IO;
using System.Net;

namespace FileMasta.Extensions
{
    class WebFileExtensions
    {
        /// <summary>
        /// Gets size of ftp file in bytes
        /// </summary>
        /// <param name="fileURL">FTP File</param>
        /// <returns></returns>
        public static long FtpFileSize(string fileURL)
        {
            try
            {
                var request = (FtpWebRequest)WebRequest.Create(fileURL);
                request.Timeout = 300000;
                request.Credentials = new NetworkCredential("anonymous", "password");
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    return response.ContentLength;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Gets file DateTimestamp of ftp file
        /// </summary>
        /// <param name="fileURL">FTP File</param>
        /// <returns></returns>
        public static DateTime FtpFileTimestamp(string fileURL)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fileURL);
                request.Timeout = 300000;
                request.Credentials = new NetworkCredential("anonymous", "password");
                request.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    return response.LastModified;
            }
            catch { return DateTime.MinValue; }
        }


        /// <summary>
        /// Gets web file size in bytes
        /// </summary>
        /// <param name="FileURL"></param>
        /// <returns></returns>
        public static int WebFileSize(string FileURL)
        {
            try
            {
                var request = WebRequest.Create(FileURL);
                request.Method = "HEAD";
                request.Timeout = 300000;
                using (var responese = (HttpWebResponse)request.GetResponse())
                    if (int.TryParse(responese.Headers.Get("Content-Length"), out int ContentLength))
                        return ContentLength;
                    else
                        return 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Gets web file last modified date
        /// </summary>
        /// <param name="FileURL"></param>
        /// <returns></returns>
        public static DateTime WebFileTimestamp(string FileURL)
        {
            try
            {
                var request = WebRequest.Create(FileURL);
                request.Method = "HEAD";
                request.Timeout = 300000;
                using (var responese = (HttpWebResponse)request.GetResponse())
                    if (responese.LastModified != null)
                        return responese.LastModified;
                    else
                        return DateTime.MinValue;
            }
            catch { return DateTime.MinValue; }
        }

        /// <summary>
        /// Checks if web file exists on server
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static bool URLExists(string URL)
        {
            try
            {
                var request = (FtpWebRequest)WebRequest.Create(URL);
                request.Timeout = 300000;

                using (var fileResponse = (FtpWebResponse)request.GetResponse())
                    return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Checks if path is a local file and exists on machine
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool IsLocalFile(string filePath)
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// Checks if path is valid
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsUri(string uriString)
        {
            try
            {
                Uri uri = new Uri(uriString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}