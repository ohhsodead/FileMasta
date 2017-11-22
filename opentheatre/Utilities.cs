using DatabaseFilesAPI;
using OpenTheatre;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public class UtilityTools
    {
        public static string getContainingListOfURL(string fileUrl)
        {
            foreach (string file in frmOpenTheatre.dataFilesMovies)
            {
                var data = DatabaseFilesEntity.FromJson(file);
                if (data.URL == fileUrl) { return "Movies"; }
            }
            foreach (string file in frmOpenTheatre.dataFilesSeries)
            {
                var data = DatabaseFilesEntity.FromJson(file);
                if (data.URL == fileUrl) { return "Series"; }
            }
            foreach (string file in frmOpenTheatre.dataFilesAnime)
            {
                var data = DatabaseFilesEntity.FromJson(file);
                if (data.URL == fileUrl) { return "Anime"; }
            }
            foreach (string file in frmOpenTheatre.dataFilesSubtitles)
            {
                var data = DatabaseFilesEntity.FromJson(file);
                if (data.URL == fileUrl) { return "Subtitles"; }
            }
            foreach (string file in frmOpenTheatre.dataFilesTorrents)
            {
                var data = DatabaseFilesEntity.FromJson(file);
                if (data.URL == fileUrl) { return "Torrents"; }
            }

            return "null";
        }

        public static bool ContainsAll(string source, params string[] values)
        {
            return values.All(x => source.ToLower().Contains(x));
        }

        public static bool IsBelowThreshold(string filename, int hours)
        {
            return new FileInfo(filename).LastAccessTime < DateTime.Now.AddHours(-hours);
        }

        public static string Random(ICollection<string> Items)
        {
            Random Rndm = new Random();
            List<string> StringList = new List<string>(Items);
            return StringList[Rndm.Next(0, Items.Count)];
        }

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

        public static void checkForUpdate()
        {
            Version newVersion = null;
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(frmOpenTheatre.linkLatestVersion);
            StreamReader reader = new StreamReader(stream);
            newVersion = new Version(reader.ReadToEnd());
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            if (curVersion.CompareTo(newVersion) < 0)
            {
                MessageBox.Show("There is a new update available ready to be installed.", "OpenTheatre - Update Available");

                try
                {
                    client.DownloadFile(frmOpenTheatre.getLatestInstaller(newVersion), frmOpenTheatre.pathDownloadInstaller);
                    Process.Start(frmOpenTheatre.pathDownloadInstaller);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to run installer." + Environment.NewLine + Environment.NewLine + ex.Message, "OpenTheatre - Update Error");
                }
            }
        }
    }
}
