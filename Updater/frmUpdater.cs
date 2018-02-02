using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Updater
{
    public partial class frmUpdater : Form
    {
        public frmUpdater()
        {
            InitializeComponent();
        }

        private void frmUpdater_Load(object sender, EventArgs e)
        {
            new Installer(progressBar, statusLabel).Start("https://raw.githubusercontent.com/ekkash/WebCrunch/master/WebCrunch/Release.zip");
        }
    }

    public class Installer
    {
        private string FindByDisplayName(RegistryKey parentKey, string name)
        {
            string[] nameList = parentKey.GetSubKeyNames();
            for (int i = 0; i < nameList.Length; i++)
            {
                RegistryKey regKey = parentKey.OpenSubKey(nameList[i]);
                try
                {
                    if (regKey.GetValue("DisplayName").ToString() == name)
                    {
                        return regKey.GetValue("InstallLocation").ToString();
                    }
                }
                catch { }
            }
            return "";
        }

        string zipPath = KnownFolders.GetPath(KnownFolder.Downloads) + @"\Release.zip";

        ProgressBar progressBar;
        Label statusLabel;
        Boolean downloadDone;

        public Installer(ProgressBar _progressBar, Label _statusLabel)
        {
            progressBar = _progressBar;
            statusLabel = _statusLabel;
        }

        public async void Start(string fileUrl)
        {
            Task<bool> downloadArchiveTask = DownloadArchiveAsync(fileUrl);

            bool downloadArchiveDone = await downloadArchiveTask;

            if (downloadArchiveDone)
                statusLabel.BeginInvoke((Action)(() => {
                    statusLabel.Text = "Download Completed";
                }));
        }

        async Task<bool> DownloadArchiveAsync(string fileUrl)
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall");
            string extractPath = FindByDisplayName(regKey, "WebCrunch");

            var downloadLink = new Uri(fileUrl);
            var saveFilename = Path.GetFileName(downloadLink.AbsolutePath);

            void DownloadProgressChangedEvent(object s, DownloadProgressChangedEventArgs e)
            {
                progressBar.BeginInvoke((Action)(() =>
                {
                    progressBar.Value = e.ProgressPercentage;
                }));

                var downloadProgress = string.Format("{0} MB / {1} MB",
                        (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                        (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

                statusLabel.BeginInvoke((Action)(() =>
                {
                    statusLabel.Text = "Downloading " + downloadProgress + " ...";
                }));
            }

            AsyncCompletedEventHandler AsyncCompletedEvent = (s, e) =>
            {
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                downloadDone = true;
            };

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += DownloadProgressChangedEvent;
                webClient.DownloadFileCompleted += AsyncCompletedEvent;
                webClient.DownloadFileAsync(downloadLink, saveFilename);
            }

            await IsDownloadDone();

            return true;
        }

        async Task IsDownloadDone()
        {
            await Task.Run(() =>
            {
                while (!downloadDone) ;
            });
        }
    }
}
