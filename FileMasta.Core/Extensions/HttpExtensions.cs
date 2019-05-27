using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace FileMasta.Core.Extensions
{
    public abstract class HttpExtensions
    {
        /// <summary>
        /// Get the specified web file size in bytes
        /// </summary>
        /// <param name="url">File Url</param>
        /// <returns></returns>
        public static long GetFileSize(Uri uri)
        {
            WebRequest webRequest = WebRequest.Create(uri);
            webRequest.Method = "HEAD";

            using (var webResponse = webRequest.GetResponse())
            {
                var fileSize = webResponse.Headers.Get("Content-Length");
                return Convert.ToInt64(fileSize);
            }
        }

        /// <summary>
        /// Get the specified web file last modified date
        /// </summary>
        /// <param name="url">File Url</param>
        /// <returns></returns>
        public static DateTime GetFileLastModified(Uri url)
        {
            try
            {
                return GetWebResponse(url.AbsoluteUri).LastModified;
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Create new http web response
        /// </summary>
        /// <param name="url">URL to request</param>
        /// <returns>Returns a web response from the URL</returns>
        private static HttpWebResponse GetWebResponse(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "HEAD";
            request.Timeout = -1;
            return (HttpWebResponse)request.GetResponse();
        }

        /// <summary>
        /// Get the file contents as an array of lines
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetFileContents(string url)
        {
            List<string> items = new List<string>();
            HttpWebRequest request = GetRequest(url);
            using (WebResponse webResponse = request.GetResponse())
            using (StreamReader reader = new StreamReader(webResponse.GetResponseStream() ?? throw new InvalidOperationException("Error retrieving file contents")))
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
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.ContentType = contentType;
            request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
            request.AllowAutoRedirect = allowAutoRedirect;
            request.Method = httpMethod;
            return request;
        }

        public static Stream GetStream(string url)
        {
            return ((HttpWebResponse)GetRequest(url).GetResponse()).GetResponseStream();
        }

        /// <summary>
        /// Download a web file using given URL to users local hard disk
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public static void DownloadFile(string url, string path)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Accept: text/plain");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(url), path);
            }
        }
    }
}