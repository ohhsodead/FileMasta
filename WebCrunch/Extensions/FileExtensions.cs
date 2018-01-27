using System;
using System.IO;
using System.Net;
using WebCrunch;

namespace WebCrunch.Extensions
{
    class FileExtensions
    {
        /// <summary>
        /// Checks if file exists, whether they're the same size and then returns the output
        /// </summary>
        /// <param name="webFile"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool doUpdateFile(string webFile, string fileName)
        {
            try
            {
                if (File.Exists(MainForm.pathData + fileName) == true)
                {
                    WebRequest req = WebRequest.Create(webFile);
                    req.Method = "HEAD";
                    //req.Timeout = 1250;
                    using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                    {
                        int ContentLength;
                        if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out ContentLength))
                        {
                            if (new FileInfo(MainForm.pathData + fileName).Length == ContentLength) { return false; }
                            else { return true; }
                        }
                        else { return true; }
                    }
                }
                else { return true; }
            }
            catch { return true; }
        }

        /// <summary>
        /// Gets web file last modified date
        /// </summary>
        /// <param name="webUrl"></param>
        /// <returns></returns>
        public static DateTime getFileLastModified(string webUrl)
        {
            try
            {
                WebRequest req = WebRequest.Create(webUrl);
                req.Method = "HEAD";
                req.Timeout = -1;
                using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                {
                    DateTime fileModifiedTime = fileResponse.LastModified;
                    if (fileModifiedTime != null)
                    {
                        return fileModifiedTime;
                    }
                    else { return default(DateTime); ; }
                }
            }
            catch { return default(DateTime); }
        }

        /// <summary>
        /// Gets web file size
        /// </summary>
        /// <param name="webUrl"></param>
        /// <returns></returns>
        public static int getFileSize(string webUrl)
        {
            try
            {
                WebRequest req = WebRequest.Create(webUrl);
                req.Method = "HEAD";
                req.Timeout = 7000;
                using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                {
                    if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out int ContentLength))
                    {
                        return ContentLength;
                    }
                    else { return 0; }
                }
            }
            catch { return 0; }
        }

        /// <summary>
        /// Checks for exact file name of a subtitle file that matches the web filename (e.g. File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
        /// </summary>
        /// <param name="fileURL"></param>
        /// <returns></returns>
        public static bool hasExistingSubtitles(string fileURL)
        {
            if (File.Exists(MainForm.userDownloadsDirectory + Path.GetFileNameWithoutExtension(new Uri(fileURL).LocalPath) + ".srt"))
            {
                return true;
            }
            else return false;
        }
    }
}
