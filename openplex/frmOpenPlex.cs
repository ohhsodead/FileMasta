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
using openplex;
using System.Diagnostics;

namespace OpenPlex
{
    public partial class frmOpenPlex : Form
    {
        public frmOpenPlex()
        {
            InitializeComponent();
        }

        public static string linkBackground = "https://dl.dropbox.com/s/oxndc32ce358u0h/openplex-background.txt?dl=0";
        public static string linkDatabase = "https://dl.dropbox.com/s/b9e4y30bwaxehpt/openplex-db.txt?dl=0";
        public static string pathTempFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenPlex\";
        public static string pathDownloads = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenPlex\Downloads\";

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

        public string Random(ICollection<string> Items)
        {
            Random Rndm = new Random();
            List<string> StringList = new List<string>(Items);
            return StringList[Rndm.Next(0, Items.Count)];
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

        public static List<string> listMovieBackgrounds = new List<string>();

        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";

        private void frmOpenPlex_Load(object sender, EventArgs e)
        {
            frmClient = new frmDownloadClient();

            VLCToolStripMenuItem1.Visible = File.Exists(pathVLC);

            string movieBackground = client.DownloadString(linkBackground);
            string[] movieBackgroundDb = movieBackground.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string background in movieBackgroundDb)
            {
                listMovieBackgrounds.Add(background);
            }

            tabHome.BackgroundImage = ChangeOpacity(LoadPicture(Random(listMovieBackgrounds)), 0.2F);

            Directory.CreateDirectory(pathTempFolder);
            Directory.CreateDirectory(pathDownloads);

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(new Uri(linkDatabase), pathTempFolder + @"\openplex-db.txt");
            }

        }

        private void btnSearch_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (!(txtSearchBox.Text == "")) { searchDatabase(txtSearchBox.Text); }
        }

        public void searchDatabase(string text)
        {
            try
            {
                dataGrid.Rows.Clear();

                if (File.Exists(pathTempFolder + @"\openplex-db.txt"))
                {
                    string[] readDb = File.ReadAllLines(pathTempFolder + @"\openplex-db.txt");
                    string[] keyWords = text.Replace(" ", "").Split(',');
                    foreach (string file in readDb)
                    {
                        if (ContainsAll(file, keyWords) == true) dataGrid.Rows.Add(file);
                    }

                    tab.SelectedTab = tabSearchResults;
                }
                else MessageBox.Show("Unable to locate database file. Please restart the app and try again.");
            }
            catch { MessageBox.Show("Unable to search database. Please try again in a moment."); }
        }

        public static bool ContainsAll(string source, params string[] values)
        {
            return values.All(x => source.Contains(x));
        }

        private void lblBackHome_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabHome;
        }

        private frmDownloadClient frmClient;

        private void btnDownloadSelected_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            string value = dataGrid.CurrentRow.Cells[0].Value.ToString();

            if (!frmClient.Visible)
            {
                frmClient.Show();
                frmClient.doDownloadFile(value);
            }
            else
            {
                frmClient.doDownloadFile(value);
                frmClient.Focus();
            }
        }

        private void btnBack_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            tab.SelectedTab = tabHome;
        }


        private void imgAbout_Click(object sender, EventArgs e)
        {
            frmAboutUs frmAbout = new frmAboutUs();
            frmAbout.ShowDialog();
        }

        private void btnTag4_Click(object sender, EventArgs e)
        {
            CButtonLib.CButton ctrlTag = sender as CButtonLib.CButton;
            if (txtSearchBox.Text == "") txtSearchBox.Text += ctrlTag.Text + ", ";
            else if (txtSearchBox.Text.EndsWith(", ")) { txtSearchBox.Text += ctrlTag.Text + ", "; }
            else { txtSearchBox.Text += ", " + ctrlTag.Text + ", "; }
        }

        private void wMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string value = dataGrid.CurrentRow.Cells[0].Value.ToString();

                Process.Start("wmplayer.exe", value);
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Unable to open file"); }
        }

        private void VLCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string value = dataGrid.CurrentRow.Cells[0].Value.ToString();

                Process VLC = new Process();
                VLC.StartInfo.FileName = pathVLC;
                VLC.StartInfo.Arguments = ("-vvv " + value);
                VLC.Start();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Unable to open file"); }
        }
    }
}
