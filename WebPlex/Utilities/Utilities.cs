using DatabaseFileAPI;
using OMDbAPI;
using WebPlex;
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
using UnhandledExceptions;

namespace WebPlex
{
    public class Utilities
    {
        // Saved Files (Convert: File Link -> Json)
        public static string fileToJson(string Url, string Name, string Type, string Host)
        {
            var a = new DatabaseFilesEntity
            {
                URL = Url,
                Host = Host,
                Title = Path.GetFileNameWithoutExtension(new Uri(Url).LocalPath),
                Type = Type,
                Size = "-",
                DateAdded = "-"
            };

            return a.ToJson();
        }

        public static string pathDataSaved = frmWebPlex.pathRoot + "saved-files.json";

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

        // Resize Combobox Control to Longest Text Size
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
            Process.Start("https://github.com/invu/WebPlex/issues/new?title=" + "[Indexer Request] " + new Uri(webUrl).Host + "&body=" +
                "Website: " + webUrl + "%0A" +
                "----------------------- %0A" +
                "*Please include some information about this site e.g. What is the type of site? What's the content?*");
        }

        // Report Broken File issue
        public static void openBrokenFileIssue(string webFile)
        {
            Process.Start("https://github.com/invu/WebPlex/issues/new?title=" + "[Broken File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "----------------------- %0A" +
                "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server's permissions.*");
        }

        // Poor Quality File issue
        public static void openPoorQualityFileIssue(string webFile)
        {
            Process.Start("https://github.com/invu/WebPlex/issues/new?title=" + "[Poor Quality File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "----------------------- %0A" +
                "*Please explain the problem with the file, be clear and not vague.*");
        }

        // compare local and online files (used for updating database)
        public static bool doUpdateFile(string webFile, string fileName)
        {
            try
            {
                if (File.Exists(frmWebPlex.pathData + fileName) == true)
                {
                    WebRequest req = WebRequest.Create(webFile);
                    req.Method = "HEAD";
                    //req.Timeout = 1250;
                    using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                    {
                        int ContentLength;
                        if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out ContentLength))
                        {
                            if (new FileInfo(frmWebPlex.pathData + fileName).Length == ContentLength) { return false; }
                            else { return true; }
                        }
                        else { return true; }
                    }
                }
                else { return true; }
            }
            catch { return true; }
        }

        // compare file bytes
        public static bool isFileSizeIdentical(string fileURLSize, string fileURL)
        {
            if (File.Exists(frmWebPlex.userDownloadsDirectory + Path.GetFileName(new Uri(fileURL).LocalPath)) && fileURLSize == ToFileSize(Convert.ToDouble(new FileInfo(frmWebPlex.userDownloadsDirectory + Path.GetFileName(new Uri(fileURL).LocalPath)).Length))) { return true; }
            else { return false; }
        }

        // if user has file subtitles in their downloads direcotry
        public static bool isExistingSubtitlesFile(string fileURL)
        {
            // Checks for exact file name of a subtitle file that matches the one being loaded (e.g. File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
            if (File.Exists(frmWebPlex.userDownloadsDirectory + Path.GetFileNameWithoutExtension(new Uri(fileURL).LocalPath) + ".srt")) {
            return true; }
            else return false;
        }

        // load picturebox from web resource
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
        public static string ToFileSize(double value)
        {
            string[] suffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            for (int i = 0; i < suffixes.Length; i++)
            {
                if (value <= (Math.Pow(1024, i + 1)))
                {
                    return ThreeNonZeroDigits(value / Math.Pow(1024, i)) + " " + suffixes[i];
                }
            }

            return ThreeNonZeroDigits(value / Math.Pow(1024, suffixes.Length - 1)) +
                " " + suffixes[suffixes.Length - 1];
        }

        // Return the value formatted to include at most three
        // non-zero digits and at most two digits after the
        // decimal point. Examples:
        //         1
        //       123
        //        12.3
        //         1.23
        //         0.12
        public static string ThreeNonZeroDigits(double value)
        {
            if (value >= 100)
            {
                // No digits after the decimal.
                return value.ToString("0,0");
            }
            else if (value >= 10)
            {
                // One digit after the decimal.
                return value.ToString("0.0");
            }
            else
            {
                // Two digits after the decimal.
                return value.ToString("0.00");
            }
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

        // change image opacity
        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();
            return bmp;
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

        // check for updates, installs installer to downloads folder if available and opens it
        public static void checkForUpdate()
        {
            Version newVersion = null;
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(frmWebPlex.linkLatestVersion);
            StreamReader reader = new StreamReader(stream);
            newVersion = new Version(reader.ReadToEnd());
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            if (curVersion.CompareTo(newVersion) < 0)
            {
                MessageBox.Show("WebPlex " + newVersion.ToString() + " is ready to be installed.", "WebPlex - Update Available");

                client.DownloadFile(frmWebPlex.getLatestInstaller(newVersion), frmWebPlex.pathDownloadInstaller);
                Directory.Delete(frmWebPlex.pathData, true);
                Process.Start(frmWebPlex.pathDownloadInstaller);
                Application.Exit();
            }
        }
    }
}
