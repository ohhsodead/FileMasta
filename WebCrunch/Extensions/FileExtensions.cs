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
                Program.log.Info("Checking if file '" + fileName + "' needs to be updated");

                if (File.Exists(MainForm.pathData + fileName) == true)
                {
                    WebRequest req = WebRequest.Create(webFile);
                    req.Method = "HEAD";
                    //req.Timeout = 1250;
                    using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                    {
                        if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out int ContentLength))
                        {
                            if (new FileInfo(MainForm.pathData + fileName).Length == ContentLength) { return false; }
                            else { return true; }
                        }
                        else { return true; }
                    }
                }
                else { return true; }
            }
            catch (Exception ex) { Program.log.Error("Errro checking file '" + fileName + "' for update", ex); return true;  }
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
                Program.log.Info("Requesting file modified date from web file");

                WebRequest req = WebRequest.Create(webUrl);
                req.Method = "HEAD";
                req.Timeout = -1;
                using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                {
                    DateTime fileModifiedTime = fileResponse.LastModified;
                    if (fileModifiedTime != null)
                    {
                        Program.log.Info("Succesffuly returned file modified date from web file");
                        return fileModifiedTime;
                    }
                    else { return default(DateTime); ; }
                }
            }
            catch (Exception ex) { Program.log.Error("Error requesting file modified date from web file", ex); return default(DateTime); }
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
                Program.log.Info("Requesting file size from web file");

                WebRequest req = WebRequest.Create(webUrl);
                req.Method = "HEAD";
                req.Timeout = 7000;
                using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                {
                    if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out int ContentLength))
                    {
                        Program.log.Info("Successfully returned file size from web file");
                        return ContentLength;
                    }
                    else { return 0; }
                }
            }
            catch (Exception ex) { Program.log.Error("Error requesting file size from web file", ex); return 0; }
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
