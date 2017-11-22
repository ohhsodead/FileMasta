using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace OpenTheatre
{
    public partial class ctrlDownloadItem : UserControl
    {
        public Size defaultSize = new Size(frmOpenTheatre.form.panelDownloads.ClientSize.Width - 7, 82), dropSize = new Size(frmOpenTheatre.form.panelDownloads.ClientSize.Width - 7, 118);

        public ctrlDownloadItem()
        {
            InitializeComponent();
        }

        private void ctrlDownloadItem_Load(object sender, EventArgs e)
        {
            
        }

        WebClient wc = new WebClient();
        Stopwatch sw = new Stopwatch();

        public void doDownloadFile(string url)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgressChanged);
            wc.DownloadFileAsync(new Uri(url), frmOpenTheatre.pathDownloads + Path.GetFileName(new Uri(url).LocalPath));
            lblFileName.Text = Path.GetFileName(new Uri(url).LocalPath);
            sw.Start();
        }

        private void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblSpeed.Text = "Speed: " + string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            lblDownloaded.Text = "Downloaded: " + string.Format("{0} MB's / {1} MB's",
       (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
       (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

            double Value = Convert.ToDouble(e.TotalBytesToReceive);

            progressBar1.Value = e.ProgressPercentage;
            lblPercentage.Text = "Downloading - " + progressBar1.Value + "%";
            lblSize.Text = "Size: " + ToFileSize(Value);
        }

        private void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();
            if (e.Cancelled == true) { lblPercentage.Text = "Download Cancelled"; lblCancel.Text = "Close"; }
            else if (e.Error != null) { lblPercentage.Text = "Download Failed - " + e.Error.Message; lblCancel.Text = "Close"; }
            else { lblPercentage.Text = "Download Complete"; lblCancel.Text = "Close"; }
        }

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
        private static string ThreeNonZeroDigits(double value)
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

        public static void openFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            // combine the arguments together
            // it doesn't matter if there is a space after ','
            string argument = "/select, \"" + path + "\"";

            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            openFile(frmOpenTheatre.pathDownloads + lblFileName.Text);
        }

        private void imgDropDown_Click(object sender, EventArgs e)
        {
            if (Size == defaultSize) { Size = dropSize; lblSpeed.Visible = true; lblDownloaded.Visible = true; } else { Size = defaultSize; lblSpeed.Visible = false; lblDownloaded.Visible = false; }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            wc.CancelAsync();
            wc.Dispose();
            Hide();
            Dispose();
        }
    }
}
