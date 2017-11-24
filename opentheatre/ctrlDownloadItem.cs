using Utilities;
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

        Stopwatch sw = new Stopwatch();
        WebClient wc = new WebClient();

        public void doDownloadFile(string url)
        {
            if (!Directory.Exists(Properties.Settings.Default.downloadsDirectory)) { MessageBox.Show("Specified download directory doesn't exist"); return; }
            if (Properties.Settings.Default.connectionCustom == true) { if (Properties.Settings.Default.connectionHost != null && Properties.Settings.Default.connectionPort != null) { wc.Proxy = new WebProxy(Properties.Settings.Default.connectionHost, Convert.ToInt32(Properties.Settings.Default.connectionPort)); wc.Proxy.Credentials = new NetworkCredential(Properties.Settings.Default.connectionUsername, Properties.Settings.Default.connectionPassword); wc.UseDefaultCredentials = false; } }
            else { wc.Proxy = WebProxy.GetDefaultProxy(); wc.Proxy.Credentials = CredentialCache.DefaultCredentials; wc.UseDefaultCredentials = true; }
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgressChanged);
            wc  .DownloadFileAsync(new Uri(url), Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(url).LocalPath));
            lblFileName.Text = Path.GetFileName(new Uri(url).LocalPath);
            sw.Start();
        }

        private void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double totalReceivedValue = Convert.ToDouble(e.TotalBytesToReceive);
            double receivedValue = Convert.ToDouble(e.BytesReceived);

            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = "Downloading - " + progressBar1.Value + "%";

            lblSpeed.Text = "Speed: " + string.Format("{0}/s", UtilityTools.ToFileSize((e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds)));
            lblDownloaded.Text = "Downloaded: " + UtilityTools.ToFileSize(receivedValue);
            lblSize.Text = "Size: " + UtilityTools.ToFileSize(totalReceivedValue);
        }

        private void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();
            if (e.Cancelled == true) { lblStatus.Text = "Download Cancelled"; lblCancel.Text = "Close"; }
            else if (e.Error != null) { lblStatus.Text = "Download Failed - " + e.Error.Message; lblCancel.Text = "Close"; }
            else { lblStatus.Text = "Download Complete"; lblCancel.Text = "Close"; }
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            UtilityTools.openFile(Properties.Settings.Default.downloadsDirectory + lblFileName.Text);
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
