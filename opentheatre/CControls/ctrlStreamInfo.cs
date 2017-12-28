using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Utilities;
using UnhandledExceptions;

namespace OpenTheatre
{
    public partial class ctrlStreamInfo : UserControl
    {
        public ctrlStreamInfo()
        {
            InitializeComponent();
        }

        public bool isLocal;
        public bool isTorrent;
        public string infoFileURL;
        public string infoFileSubtitles;

        public string infoMagnet = "";

        private void ctrlStreamInfo_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;

            VLCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathMPCCodec64) || File.Exists(frmOpenTheatre.pathMPC64) || File.Exists(frmOpenTheatre.pathMPC86);

            if (Properties.Settings.Default.dataBookmarks.Contains(infoFileURL)) { imgAddToBookmarks.Image = Properties.Resources.bookmark_remove; } else { imgAddToBookmarks.Image = Properties.Resources.bookmark_plus; }
            if (frmOpenTheatre.currentDownloads.Contains(infoFileURL)) { imgDownload.Image = Properties.Resources.cloud_sync; } else if (File.Exists(Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(infoFileURL).LocalPath)) && infoFileSize.Text == UtilityTools.ToFileSize(Convert.ToDouble(new FileInfo(Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(infoFileURL).LocalPath)).Length))) { imgDownload.Image = Properties.Resources.cloud_done; }

            if (isTorrent == true)
            {
                imgReportBroken.Visible = false;
                imgWatch.Visible = false;
                imgMagnet.Visible = true;
            }
            else if (isLocal == true)
            { infoFileHost.Text = frmOpenTheatre.rm.GetString("local"); infoFileSize.Text = UtilityTools.ToFileSize(new FileInfo(infoFileURL).Length); infoFileAge.Text = UtilityTools.getTimeAgo(File.GetLastWriteTime(infoFileURL)); imgDownload.Visible = false; imgReportBroken.Visible = false; imgShare.Visible = false; imgCopyURL.Visible = false; }

            // Checks for exact file name of a subtitle file that matches the one being loaded (e.g. Media File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
            if (infoFileSubtitles == null)
            {
                if (UtilityTools.isExistingSubtitlesFile(infoFileURL) == true)
                {
                    infoFileSubtitles = Properties.Settings.Default.downloadsDirectory + Path.GetFileNameWithoutExtension(infoFileURL) + ".srt";
                }
            }
        }

        private void WMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wmplayer.exe", infoFileURL);
        }

        private void VLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open source file in VLC with subtitles
            Process VLC = new Process();
            VLC.StartInfo.FileName = frmOpenTheatre.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + infoFileURL + " --sub-file=" + infoFileSubtitles);
            VLC.Start();
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process MPC = new Process();
            if (File.Exists(frmOpenTheatre.pathMPCCodec64))
                MPC.StartInfo.FileName = frmOpenTheatre.pathMPCCodec64;
            else if (File.Exists(frmOpenTheatre.pathMPC64))
                MPC.StartInfo.FileName = frmOpenTheatre.pathMPC64;
            else
                MPC.StartInfo.FileName = frmOpenTheatre.pathMPC86;
            MPC.StartInfo.Arguments = (infoFileURL);
            MPC.Start();
        }

        private void imgAddToBookmarks_Click(object sender, EventArgs e)
        {
            if (!isTorrent)
            {
                if (Properties.Settings.Default.dataBookmarks.Contains(infoFileURL))
                {
                    Properties.Settings.Default.dataBookmarks.Remove(infoFileURL); imgAddToBookmarks.Image = Properties.Resources.bookmark_plus;
                }
                else { Properties.Settings.Default.dataBookmarks.Add(infoFileURL); imgAddToBookmarks.Image = Properties.Resources.bookmark_remove; }
            }
        }

        private void imgWatch_Click(object sender, EventArgs e)
        {
            contextFileName.Show(imgWatch, imgWatch.PointToClient(Cursor.Position));
        }

        private void imgReportBroken_Click(object sender, EventArgs e)
        {
            UtilityTools.openBrokenFileIssue(infoFileURL);
        }

        private void imgDownload_Click(object sender, EventArgs e)
        {
            if (isTorrent == true)
            {
                Process.Start(infoFileURL);
                return;
            }

            if (!frmOpenTheatre.currentDownloads.Contains(infoFileURL)) { imgDownload.Image = Properties.Resources.cloud_sync; frmOpenTheatre.form.doDownloadFile(infoFileURL); }
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new frmVLCPlayer();
            a.Text = new Uri(infoFileURL).LocalPath;
            a.axVLCPlugin21.playlist.add(infoFileURL);
            a.axVLCPlugin21.playlist.play();
            a.Show();
        }

        private void imgCopyURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(infoFileURL);
            imgCopyURL.Image = Properties.Resources.clipboard_check;
        }

        private void timerUpdateInfo_Tick(object sender, EventArgs e)
        {
            // Checks for local file, and get/compare file size
            if (infoFileURL != null)
            {
                if (File.Exists(Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(infoFileURL).LocalPath)))
                {
                    if (infoFileSize.Text == UtilityTools.ToFileSize(Convert.ToDouble(new FileInfo(Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(infoFileURL).LocalPath)).Length)))
                    {
                        imgDownload.Image = Properties.Resources.cloud_done;
                    }
                }
            }
        }

        private void imgShare_Click(object sender, EventArgs e)
        {
            var a = new frmShareFile();
            a.infoFileURL = infoFileURL;
            a.ShowDialog(this);
        }

        private void imgMagnet_Click(object sender, EventArgs e)
        {
            Process.Start(infoMagnet);
        }
    }
}