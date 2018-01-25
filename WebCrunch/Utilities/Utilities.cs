using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections;
using Newtonsoft.Json;
using WebCrunch;

namespace Utilities
{
    public class UtilityTools
    {
        public static string fileToJson(string Url, string Name, string Type, string Host)
        {
            var a = new Models.WebFile
            {
                URL = Url,
                Host = Host,
                Title = Path.GetFileNameWithoutExtension(new Uri(Url).LocalPath),
                Type = Type,
                Size = "-",
                DateAdded = "-"
            };

            return JsonConvert.SerializeObject(a);
        }

        public static string pathDataSaved = MainForm.pathRoot + "saved-files.json";

        public static void unsaveFile(string Json)
        {
            if (File.Exists(pathDataSaved))
            {
                TextLineRemover.RemoveTextLines(new List<string> { Json }, pathDataSaved, pathDataSaved + ".tmp");
            }
        }

        public static void saveFile(string Json)
        {
            using (StreamWriter saved = File.AppendText(pathDataSaved))
            {
                saved.WriteLine(Json);
                saved.Flush();
            }
        }

        public static bool isSaved(string Json)
        {
            if (File.Exists(pathDataSaved))
            {
                using (StreamReader reader = new StreamReader(pathDataSaved))
                {
                    while (!reader.EndOfStream)
                    {
                        if (reader.ReadLine() == Json)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }

        // Submit link (open directory/indexer)
        public static void submitLink(string webUrl)
        {
            Process.Start("https://github.com/invu/WebCrunch/issues/new?title=" + "[Indexer Request] " + new Uri(webUrl).Host + "&body=" +
                "Website: " + new Uri(webUrl).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Please include some information about this site e.g. What is the type of site? What's the content?*");
        }

        // Report Broken File issue
        public static void openBrokenFileIssue(string webFile)
        {
            Process.Start("https://github.com/invu/WebCrunch/issues/new?title=" + "[Broken File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "URL: " + new Uri(webFile).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server's permissions.*");
        }

        // Poor Quality File issue
        public static void openPoorQualityFileIssue(string webFile)
        {
            Process.Start("https://github.com/invu/WebCrunch/issues/new?title=" + "[Poor Quality File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "URL: " + new Uri(webFile).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Please explain the problem with the file, be clear and not vague.*");
        }

        // compare local and online files (used for updating database)
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

        public static string getLastModifiedTime(string webUrl)
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
                        return fileModifiedTime.ToString();
                    }
                    else { return "n/a"; }
                }
            }
            catch { return "n/a"; }
        }

        public static bool isFileSizeIdentical(string fileSize, string fileURL)
        {
            if (File.Exists(MainForm.userDownloadsDirectory + Path.GetFileName(new Uri(fileURL).LocalPath)) && fileSize == bytesToString(new FileInfo(MainForm.userDownloadsDirectory + Path.GetFileName(new Uri(fileURL).LocalPath)).Length)) { return true; }
            else { return false; }
        }

        public static bool isExistingSubtitlesFile(string fileURL)
        {
            // Checks for exact file name of a subtitle file that matches the one being loaded (e.g. File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
            if (File.Exists(MainForm.userDownloadsDirectory + Path.GetFileNameWithoutExtension(new Uri(fileURL).LocalPath) + ".srt")) {
            return true; }
            else return false;
        }

        public static Bitmap LoadPicture(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            catch
            {
                // Do nothing... 
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }

        // return file size with suffix
        public static String bytesToString(long byteCount)
        {
            string[] suf = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB" }; // Longs run out around EB
            if (byteCount == 0)
                return "0" + " " + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
        }

        // open file
        public static void openFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            // combine the arguments together
            // it doesn't matter if there is a space after ','
            string argument = "/select, \"" + path + "\"";

            Process.Start("explorer.exe", argument);
        }

        // if text contains words = true
        public static bool ContainsAll(string source, params string[] values)
        {
            return values.All(x => source.ToLower().Contains(x));
        }

        // if file date below hours
        public static bool IsAboveThreshold(string filename, int hours)
        {
            return new FileInfo(filename).LastAccessTime < DateTime.Now.AddHours(-hours);
        }

        public static string Random(ICollection<string> Items)
        {
            Random Rndm = new Random();
            List<string> StringList = new List<string>(Items);
            return StringList[Rndm.Next(0, Items.Count)];
        }

        // get words from text
        public static string[] GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");

            var words = from m in matches.Cast<Match>()
                        where !string.IsNullOrEmpty(m.Value)
                        select TrimSuffix(m.Value);

            return words.ToArray();
        }

        public static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }

        // Return Number with Comma's for Thousands
        public static string getFormattedNumber(string value)
        {
            return string.Format("{0:n0}", Convert.ToInt32(value));
        }

        public static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
        new float[] {1, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, a, 0},
        new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

        // get time ago
        public static string getTimeAgo(DateTime date)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = new TimeSpan(DateTime.UtcNow.Ticks - date.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return ts.Seconds == 1 ? "1 second" : ts.Seconds + " seconds";

            if (delta < 2 * MINUTE)
                return "1 minute";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " minutes";

            if (delta < 90 * MINUTE)
                return "1 hour";

            if (delta < 24 * HOUR)
                return ts.Hours + " hours";

            if (delta < 48 * HOUR)
                return "1 day";

            if (delta < 30 * DAY)
                return ts.Days + " days";

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "1 month" : months + " months";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "1 year" : years + " years";
            }
        }

        // check for internet connection
        public static bool checkForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://google.com"))
                {
                    return true;
                }
            } catch { return false; }
        }

        public static string[] getFiles(string SourceFolder, string Filter, SearchOption searchOption)
        {
            // ArrayList will hold all file names
            ArrayList alFiles = new ArrayList();

            // Create an array of filter string
            string[] MultipleFilters = Filter.Split('|');

            // for each filter find mathing file names
            foreach (string FileFilter in MultipleFilters)
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(SourceFolder, FileFilter, searchOption));
            }

            // returns string array of relevant file names
            return (string[])alFiles.ToArray(typeof(string));
        }

        // Replaces Colour of image https://stackoverflow.com/a/17209284
        public static Bitmap changeColor(Bitmap scrBitmap, Color newColor)
        {
            //You can change your new color here. Red,Green,LawnGreen any..
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actualColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }

        // check for updates, installs installer to downloads folder if available and opens it
        public static void checkForUpdate()
        {
            Version newVersion = null;
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(MainForm.linkLatestVersion);
            StreamReader reader = new StreamReader(stream);
            newVersion = new Version(reader.ReadToEnd());
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            if (curVersion.CompareTo(newVersion) < 0)
            {
                MessageBox.Show(MainForm.form, "WebCrunch " + newVersion.ToString() + " is ready to be installed.", "WebCrunch - Update Available");

                client.DownloadFile(MainForm.getLatestInstaller(newVersion), MainForm.pathDownloadInstaller);
                Directory.Delete(MainForm.pathData, true);
                Process.Start(MainForm.pathDownloadInstaller);
                Application.Exit();
            }
        }
    }
}
