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
        public ctrlDownloadItem()
        {
            InitializeComponent();
        }

        string infoFileURL;

        private void ctrlDownloadItem_Load(object sender, EventArgs e)
        {
            BackColor = Parent.BackColor;
            progressBar1.BorderColor = BackColor;
        }

        Stopwatch sw = new Stopwatch();
        WebClient wc = new WebClient();
        DateTime startTime = new DateTime();

        public void doDownloadFile(string url)
        {
            if (!Directory.Exists(Properties.Settings.Default.downloadsDirectory)) { MessageBox.Show("Specified download directory doesn't exist. Please alter this in your settings."); return; }
            if (Properties.Settings.Default.connectionCustom == true) { if (Properties.Settings.Default.connectionHost != null && Properties.Settings.Default.connectionPort != null) { wc.Proxy = new WebProxy(Properties.Settings.Default.connectionHost, Convert.ToInt32(Properties.Settings.Default.connectionPort)); wc.Proxy.Credentials = new NetworkCredential(Properties.Settings.Default.connectionUsername, Properties.Settings.Default.connectionPassword); wc.UseDefaultCredentials = false; } }
            else { wc.Proxy = WebProxy.GetDefaultProxy(); wc.Proxy.Credentials = CredentialCache.DefaultCredentials; wc.UseDefaultCredentials = true; }
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgressChanged);
            wc.DownloadFileAsync(new Uri(url), Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(url).LocalPath)); sw.Start(); startTime = DateTime.Now;
            infoFileURL = url;
            infoFileName.Text = Path.GetFileName(new Uri(url).LocalPath);
        }

        private void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double totalReceivedValue = Convert.ToDouble(e.TotalBytesToReceive);
            double receivedValue = Convert.ToDouble(e.BytesReceived);

            progressBar1.Value = e.ProgressPercentage;
            infoStatus.Text = "Downloading";
            infoPercentage.Text = e.ProgressPercentage + "%";
            
            // Get remaining time 
            var elapsedTime = (DateTime.Now - startTime).TotalSeconds;
            var allTimeFordownloading = (elapsedTime * e.TotalBytesToReceive / e.BytesReceived);
            var remainingTime = allTimeFordownloading - elapsedTime;
            TimeSpan time = TimeSpan.FromSeconds(remainingTime);
            infoEstimatedTime.Text = string.Format("{0} Minutes {1} Seconds", time.Minutes, time.Seconds);

            infoDownloadedOutOfSize.Text = string.Format("{0}/{1}",  UtilityTools.ToFileSize(receivedValue), UtilityTools.ToFileSize(totalReceivedValue));
            infoSpeed.Text = string.Format("{0}/s ↓", UtilityTools.ToFileSize((e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds)));

            Refresh();
        }

        private void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();
            if (e.Cancelled == true) { infoStatus.Text = "Cancelled"; imgCancel.Image = Properties.Resources.check; progressBar1.ProgressColor = Color.Gray; panelDetails.ForeColor = Color.Gray; }
            else if (e.Error != null) { infoStatus.Text = "Error (" + e.Error.Message + ")"; ; imgCancel.Image = Properties.Resources.check; progressBar1.ProgressColor = Color.Red; infoStatus.ForeColor = Color.Red; }
            else { infoStatus.Text = "Complete"; imgCancel.Image = Properties.Resources.check; }

            frmOpenTheatre.currentDownloads.Remove(infoFileURL);
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            UtilityTools.openFile(Properties.Settings.Default.downloadsDirectory + infoFileName.Text);
        }

        private void imgCancel_Click(object sender, EventArgs e)
        {
            wc.CancelAsync();
            wc.Dispose();
            Hide();
            Dispose();
        }
    }
}
