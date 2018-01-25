using Dialogs;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utilities;

namespace WebCrunch.UserControls
{
    public partial class StreamInfo : UserControl
    {
        public StreamInfo()
        {
            InitializeComponent();
        }

        public bool isLocal;
        public string infoFileURL;
        public string infoFileSubtitles;

        public string infoMagnet = "";

        private void ctrlStreamInfo_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;

            VLCToolStripMenuItem.Visible = File.Exists(MainForm.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(MainForm.pathMPCCodec64) || File.Exists(MainForm.pathMPC64) || File.Exists(MainForm.pathMPC86);

            if (isLocal == true) { infoAge.Text = MainForm.rm.GetString("local"); imgDownload.Visible = false; imgReportBroken.Visible = false; imgCopyURL.Visible = false; }

            // Checks for exact file name of a subtitle file that matches the one being loaded (e.g. Media File Name: 'Jigsaw.2017.mp4' > Subtitle File Name: 'Jigsaw.2017.srt' will be loaded)
            if (infoFileSubtitles == null)
            {
                if (UtilityTools.isExistingSubtitlesFile(infoFileURL) == true)
                {
                    infoFileSubtitles = MainForm.userDownloadsDirectory + Path.GetFileNameWithoutExtension(infoFileURL) + ".srt";
                }
            }

            if (UtilityTools.isSaved(UtilityTools.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).ToUpper().Replace(".", ""), infoAge.Text)))
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
            VLC.StartInfo.FileName = MainForm.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + infoFileURL + " --sub-file=" + infoFileSubtitles);
            VLC.Start();
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process MPC = new Process();
            if (File.Exists(MainForm.pathMPCCodec64))
                MPC.StartInfo.FileName = MainForm.pathMPCCodec64;
            else if (File.Exists(MainForm.pathMPC64))
                MPC.StartInfo.FileName = MainForm.pathMPC64;
            else
                MPC.StartInfo.FileName = MainForm.pathMPC86;
            MPC.StartInfo.Arguments = (infoFileURL);
            MPC.Start();
        }

        private void imgAddToBookmarks_Click(object sender, EventArgs e)
        {
            if (!UtilityTools.isSaved(UtilityTools.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).Replace(".", "").ToUpper(), infoAge.Text)))
            {
                UtilityTools.saveFile(UtilityTools.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).Replace(".", "").ToUpper(), infoAge.Text));
                imgAddToBookmarks.Image = Properties.Resources.bookmark_remove;
            }
            else
            {
                UtilityTools.unsaveFile(UtilityTools.fileToJson(infoFileURL, infoName.Text, Path.GetExtension(infoName.Text).Replace(".", "").ToUpper(), infoAge.Text));
                imgAddToBookmarks.Image = Properties.Resources.bookmark_plus;
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
            Process.Start(infoFileURL);
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new VLCPlayer
            {
                Text = new Uri(infoFileURL).LocalPath
            };
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