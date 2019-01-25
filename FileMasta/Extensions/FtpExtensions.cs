using System;
using System.Net;

namespace FileMasta.Extensions
{
    public static class FtpExtensions
    {
        public static long GetFileSize(string fileUrl)
        {
            try
            {
                return FtpWebResponse(fileUrl).ContentLength;
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime GetFileLastModified(string fileUrl)
        {
            try
            {
                return FtpWebResponse(fileUrl).LastModified;
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        private static FtpWebResponse FtpWebResponse(string url)
        {
            var request = WebRequest.Create(url);
            request.Method = "HEAD";
            request.Timeout = 300000;
            return (FtpWebResponse) request.GetResponse();
        }
    }
}