using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Utilities;

namespace OpenTheatre
{
    public partial class ctrlStreamInfo : UserControl
    {
        public ctrlStreamInfo()
        {
            InitializeComponent();
        }

        public bool isLocal;
        public string infoFileURL;
        public string infoFileSubtitles;

        public object IO { get; private set; }

        private void ctrlStreamInfo_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;

            VLCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathMPCCodec64) || File.Exists(frmOpenTheatre.pathMPC64) || File.Exists(frmOpenTheatre.pathMPC86);

            if (Properties.Settings.Default.dataBookmarks.Contains(infoFileURL)) { imgAddToBookmarks.Image = Properties.Resources.bookmark_remove; } else { imgAddToBookmarks.Image = Properties.Resources.bookmark_plus; }
            if (frmOpenTheatre.currentDownloads.Contains(infoFileURL)) { imgDownload.Image = Properties.Resources.cloud_sync; } 

            if (isLocal == false)
            {
                try
                {
                    WebRequest req = WebRequest.Create(infoFileURL);
                    req.Method = "HEAD";
                    req.Timeout = 1500;
                    using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                    {
                        DateTime fileModifiedTime = fileResponse.LastModified;
                        if (fileModifiedTime != null)
                        {
                            infoFileAge.Text = UtilityTools.getTimeAgo(fileModifiedTime);
                        }
                        else { infoFileAge.Text = "n/a"; }

                        int ContentLength;
                        if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out ContentLength))
                        {
                            infoFileSize.Text = UtilityTools.ToFileSize(Convert.ToDouble(ContentLength));
                        }
                        else { infoFileSize.Text = "n/a"; }
                    }
                }
                catch { infoFileSize.Text = "n/a"; infoFileAge.Text = "n/a"; }
            }
            else { infoFileSize.Text = UtilityTools.ToFileSize(new FileInfo(infoFileURL).Length);infoFileAge.Text = UtilityTools.getTimeAgo(File.GetLastWriteTime(infoFileURL)); imgDownload.Visible = false; imgReportBroken.Visible = false; imgShare.Visible = false; imgCopyURL.Visible = false; }

            // Compares the two file sizes; must have the same file name
            if (UtilityTools.isFileSizeIdentical(infoFileSize.Text, infoFileURL) == true) { imgDownload.Image = Properties.Resources.cloud_done; }

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
            try
            {
                Process.Start("wmplayer.exe", infoFileURL);
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error"); }
        }

        private void VLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Open source file in VLC with subtitles
                Process VLC = new Process();
                VLC.StartInfo.FileName = frmOpenTheatre.pathVLC;
                VLC.StartInfo.Arguments = ("-vvv " + infoFileURL + " --sub-file=" + infoFileSubtitles);
                VLC.Start();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error"); }
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error"); }
        }

        private void imgAddToBookmarks_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dataBookmarks.Contains(infoFileURL))
            {
                Properties.Settings.Default.dataBookmarks.Remove(infoFileURL); imgAddToBookmarks.Image = Properties.Resources.bookmark_plus;
            }
            else { Properties.Settings.Default.dataBookmarks.Add(infoFileURL); imgAddToBookmarks.Image = Properties.Resources.bookmark_remove; }
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
            if (File.Exists(Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(infoFileURL).LocalPath)) && infoFileSize.Text == UtilityTools.ToFileSize(Convert.ToDouble(new FileInfo(Properties.Settings.Default.downloadsDirectory + Path.GetFileName(new Uri(infoFileURL).LocalPath)).Length))) { imgDownload.Image = Properties.Resources.cloud_done; }
        }

        private void imgShare_Click(object sender, EventArgs e)
        {
            var a = new frmShareFile();
            a.infoFileURL = infoFileURL;
            a.ShowDialog(this);
        }
    }
}