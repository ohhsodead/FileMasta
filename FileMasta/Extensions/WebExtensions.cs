using System;
using System.Net;

namespace FileMasta.Extensions
{
    class WebExtensions
    {
        /// <summary>
        /// Gets size of ftp file in bytes
        /// </summary>
        /// <param name="fileUrl">FTP File URL</param>
        /// <returns></returns>
        public static long FtpFileSize(string fileUrl)
        {
            try { return GetFtpReponse(fileUrl).ContentLength; }
            catch { return 0; }
        }

        /// <summary>
        /// Gets the last modified DateTime of ftp file
        /// </summary>
        /// <param name="fileUrl">FTP File URL</param>
        /// <returns></returns>
        public static DateTime FtpFileTimestamp(string fileUrl)
        {
            try { return GetFtpReponse(fileUrl).LastModified; }
            catch { return DateTime.MinValue; }
        }

        /// <summary>
        /// Gets web file size in bytes
        /// </summary>
        /// <param name="fileUrl">FTP File URL</param>
        /// <returns></returns>
        public static long WebFileSize(string fileUrl)
        {
            try
            {
                if (int.TryParse(GetWebReponse(fileUrl).Headers.Get("Content-Length"), out int ContentLength)) return ContentLength;
                else return 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Gets web file last modified date
        /// </summary>
        /// <param name="fileUrl">FTP File URL</param>
        /// <returns></returns>
        public static DateTime WebFileTimestamp(string fileUrl)
        {
            try { return GetWebReponse(fileUrl).LastModified; }
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
        /// Initialize new ftp web response
        /// </summary>
        /// <param name="url">URL to request</param>
        /// <returns>Returns a ftp response from the URL</returns>
        static FtpWebResponse GetFtpReponse(string url)
        {
            var request = WebRequest.Create(url);
            request.Method = "HEAD";
            request.Timeout = 300000;
            return (FtpWebResponse)request.GetResponse();
        }

        /// <summary>
        /// Initialize new http web response
        /// </summary>
        /// <param name="url">URL to request</param>
        /// <returns>Returns a web response from the URL</returns>
        static HttpWebResponse GetWebReponse(string url)
        {
            var request = WebRequest.Create(url);
            request.Method = "HEAD";
            request.Timeout = 300000;
            return (HttpWebResponse)request.GetResponse();
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