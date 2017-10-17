using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;


namespace openplex
{
    public partial class frmOpenPlex : Form
    {
        public frmOpenPlex()
        {
            InitializeComponent();
        }

        public static string linkBackground = "https://dl.dropbox.com/s/oxndc32ce358u0h/openplex-background.txt?dl=0";
        public static string linkDatabase = "https://dl.dropbox.com/s/b9e4y30bwaxehpt/openplex-db.txt?dl=0";
        public static string pathTempFolder = Environment.SpecialFolder.MyDocuments + @"\Open Plex\";

        public static Bitmap LoadPicture(string url)
        {
            System.Net.HttpWebRequest wreq;
            System.Net.HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (System.Net.HttpWebResponse)wreq.GetResponse();

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

        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }

        WebClient client = new WebClient();

        private void frmOpenPlex_Load(object sender, EventArgs e)
        {
            string MoviesContent = client.DownloadString(linkBackground);
            tabHome.BackgroundImage = ChangeOpacity(LoadPicture(MoviesContent), 0.4F);

            Directory.CreateDirectory(pathTempFolder);

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgressChanged);
                wc.DownloadFileAsync(new Uri(linkDatabase), pathTempFolder + @"\openplex-db.txt");
            }
        }

       
        private void btnSearch_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            searchDatabase(txtSearchBox.Text);
        }

        public void searchDatabase(string text)
        {
            dataGrid.Rows.Clear();

            if (File.Exists(pathTempFolder + @"\openplex-db.txt"))
            {
                string[] readDb = File.ReadAllLines(pathTempFolder + @"\openplex-db.txt");
                foreach (string file in readDb)
                {
                    if (file.Contains(text)) dataGrid.Rows.Add(file);
                }

                tab.SelectedTab = tabSearchResults;
            }
            else MessageBox.Show("Unable to locate database file. Please restart the app and try again.");
        }

        private void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //progressBar.Value = e.ProgressPercentage;
        }

        private void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void lblBackHome_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabHome;
        }
    }
}
