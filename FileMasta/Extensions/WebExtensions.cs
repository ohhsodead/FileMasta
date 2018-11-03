using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FileMasta.Extensions
{
    class WebExtensions
    {
        /// <summary>
        /// Gets size of ftp file in bytes
        /// </summary>
        /// <param name="fileURL">FTP File URL</param>
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
        /// <param name="fileURL">FTP File URL</param>
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
        /// <param name="fileURL">FTP File URL</param>
        /// <returns></returns>
        public static int WebFileSize(string fileURL)
        {
            try
            {
                var request = WebRequest.Create(fileURL);
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
        /// <param name="fileURL">FTP File URL</param>
        /// <returns></returns>
        public static DateTime WebFileTimestamp(string fileURL)
        {
            try
            {
                var request = WebRequest.Create(fileURL);
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
        /// Checks if URL exists on the server by requesting file size
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool URLExists(string url)
        {
            if (FtpFileSize(url) == 0) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Initialize new http web request
        /// </summary>
        /// <param name="requestUriString">File URL</param>
        /// <param name="httpMethod">Method for the request</param>
        /// <param name="allowAutoRedirect">Whether request should follow redirection responses</param>
        /// <param name="contentType">Sets content-type http header</param>
        /// <returns>Returns a new HTTP Web Request to Get Response from file</returns>
        public static HttpWebRequest GetRequest(string requestUriString, string httpMethod = "GET", bool allowAutoRedirect = true, string contentType = "text/plain")
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.ContentType = contentType;
            request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
            request.AllowAutoRedirect = allowAutoRedirect;
            request.Method = httpMethod;
            return request;
        }
    }
}