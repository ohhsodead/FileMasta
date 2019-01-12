using System;
using System.Collections.Generic;
using System.IO;
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
        /// Checks if local file is older than the one stored on the database
        /// </summary>
        /// <param name="webFile">String URL of the file to check for update</param>
        /// <param name="fileName">File name, used to check local directory</param>
        /// <returns></returns>
        public static bool IsLocalFileOld(string webFile, string fileName)
        {
            try
            {
                Program.Log.Info($"Checking if '{fileName}' needs to be updated");

                if (File.Exists($"{LocalExtensions.PathData}{fileName}"))
                    if (WebFileSize($"{webFile}") == new FileInfo($"{LocalExtensions.PathData}{fileName}").Length)
                        return false;
                    else
                        return true;
                else
                    return true;
            }
            catch (Exception ex) { Program.Log.Error($"Unable to check '{fileName}' for update, URL : {webFile}", ex); return true; }
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
        public static HttpWebResponse GetWebReponse(string url)
        {
            var request = WebRequest.Create(url);
            request.Method = "HEAD";
            request.Timeout = 300000;
            return (HttpWebResponse)request.GetResponse();
        }

        public static List<string> GetFileContents(string url)
        {
            var items = new List<string>();
            var request = GetRequest(url);
            using (WebResponse webResponse = request.GetResponse())
            using (var reader = new StreamReader(webResponse.GetResponseStream()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    items.Add(line);
            }
            return items;
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

        /// <summary>
        /// Download a web file using given URL to users local hard disk
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public static void DownloadFile(string url, string path)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Accept: text/plain");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(url), path);
            }
        }
    }
}