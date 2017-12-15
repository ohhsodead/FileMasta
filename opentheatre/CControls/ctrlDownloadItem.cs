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
using UnhandledExceptions;

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

        }

        Stopwatch sw = new Stopwatch();
        WebClient wc = new WebClient();
        DateTime startTime = new DateTime();

        public void doDownloadFile(string url)
        {
            if (!Directory.Exists(Properties.Settings.Default.downloadsDirectory)) { MessageBox.Show(frmOpenTheatre.rm.GetString("noDownloadDirectory")); return; }
            if (Properties.Settings.Default.connectionCustom == true) { if (Properties.Settings.Default.connectionHost != null && Properties.Settings.Default.connectionPort != null) { wc.Proxy = new WebProxy(Properties.Settings.Default.connectionHost, Convert.ToInt32(Properties.Settings.Default.connectionPort)); wc.Proxy.Credentials = new NetworkCredential(Properties.Settings.Default.connectionUsername, Properties.Settings.Default.connectionPassword); wc.UseDefaultCredentials = false; } }
            else { wc.Proxy = WebProxy.GetDefaultProxy(); wc.Proxy.Credentials = CredentialCache.DefaultCredentials; wc.UseDefaultCredentials = true; }
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgressChanged);
            wc.DownloadFileAsync(new Uri(url), Properties.Settings.Default.downloadsDirectory + Path.GetFileNameWithoutExtension(new Uri(url).LocalPath) + @"\" + Path.GetFileName(new Uri(url).LocalPath)); sw.Start(); startTime = DateTime.Now;
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

        public bool doRefreshDownload = false;

        private void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();
            if (e.Error != null)
            {
                infoStatus.Text = frmOpenTheatre.rm.GetString("error") + " (" + e.Error.Message + ")"; doRefreshDownload = true; imgStatus.Image = Properties.Resources.refresh; imgStatus.Visible = true; progressBar1.BackColor = Color.Red; infoStatus.ForeColor = Color.Red;
                Logger.log("FILE DOWNLOAD ERROR Message: " + e.Error.Message + " -File Name: " + infoFileName.Text + " -Host: " + new Uri(infoFileURL).Host);
            }
            else { infoStatus.Text = frmOpenTheatre.rm.GetString("complete"); imgStatus.Image = Properties.Resources.check; imgStatus.Visible = true; }

            frmOpenTheatre.currentDownloads.Remove(infoFileURL);
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            UtilityTools.openFile(Properties.Settings.Default.downloadsDirectory + infoFileName.Text);
        }

        private void imgCancel_Click(object sender, EventArgs e)
        {
            wc.CancelAsync();
            Hide();
            Dispose();
        }

        private void imgStatus_Click(object sender, EventArgs e)
        {
            frmOpenTheatre.currentDownloads.Remove(infoFileURL);

            if (doRefreshDownload == true)
            {
                frmOpenTheatre.form.doDownloadFile(infoFileURL);
            }

            wc.CancelAsync();
            Hide();
            Dispose();
        }
    }
}
