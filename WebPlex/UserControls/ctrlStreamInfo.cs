using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WebPlex.CControls
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

            VLCToolStripMenuItem.Visible = File.Exists(Main.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(Main.pathMPCCodec64) || File.Exists(Main.pathMPC64) || File.Exists(Main.pathMPC86);

            if (Properties.Settings.Default.dataBookmarks.Contains(infoFileURL)) { imgAddToBookmarks.Image = Properties.Resources.bookmark_remove; } else { imgAddToBookmarks.Image = Properties.Resources.bookmark_plus; }

            if (isTorrent == true)
            {
                imgReportBroken.Visible = false;
                imgWatch.Visible = false;
                imgMagnet.Visible = true;
            }
            else if (isLocal == true)
            { infoAge.Text = Main.rm.GetString("local"); imgDownload.Visible = false; imgReportBroken.Visible = false; imgCopyURL.Visible = false; }

            // Checks for exact file name of a subtitle file that matches the one being loaded (e.g. Media File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
            if (infoFileSubtitles == null)
            {
                if (Utilities.isExistingSubtitlesFile(infoFileURL) == true)
                {
                    infoFileSubtitles = Main.userDownloadsDirectory + Path.GetFileNameWithoutExtension(infoFileURL) + ".srt";
                }
            }

            if (Utilities.isSaved(Utilities.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).ToUpper().Replace(".", ""), infoAge.Text)))
            {
                imgAddToBookmarks.Image = Properties.Resources.bookmark_remove;
            }
            else
            {
                imgAddToBookmarks.Image = Properties.Resources.bookmark_plus;
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
            VLC.StartInfo.FileName = Main.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + infoFileURL + " --sub-file=" + infoFileSubtitles);
            VLC.Start();
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process MPC = new Process();
            if (File.Exists(Main.pathMPCCodec64))
                MPC.StartInfo.FileName = Main.pathMPCCodec64;
            else if (File.Exists(Main.pathMPC64))
                MPC.StartInfo.FileName = Main.pathMPC64;
            else
                MPC.StartInfo.FileName = Main.pathMPC86;
            MPC.StartInfo.Arguments = (infoFileURL);
            MPC.Start();
        }

        private void imgAddToBookmarks_Click(object sender, EventArgs e)
        {
            if (!isTorrent)
            {
                if (!Utilities.isSaved(Utilities.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).Replace(".", "").ToUpper(), infoAge.Text)))
                {
                    Utilities.saveFile(Utilities.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).Replace(".", "").ToUpper(), infoAge.Text));
                    imgAddToBookmarks.Image = Properties.Resources.bookmark_remove;
                }
                else
                {
                    Utilities.unsaveFile(Utilities.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).Replace(".", "").ToUpper(), infoAge.Text));
                    imgAddToBookmarks.Image = Properties.Resources.bookmark_plus;
                }
            }
        }

        private void imgWatch_Click(object sender, EventArgs e)
        {
            contextFileName.Show(imgWatch, imgWatch.PointToClient(Cursor.Position));
        }

        private void imgReportBroken_Click(object sender, EventArgs e)
        {
            Utilities.openBrokenFileIssue(infoFileURL);
        }

        private void imgDownload_Click(object sender, EventArgs e)
        {
            Process.Start(infoFileURL);
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new VLCPlayer();
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

        private void imgMagnet_Click(object sender, EventArgs e)
        {
            Process.Start(infoMagnet);
        }
    }
}