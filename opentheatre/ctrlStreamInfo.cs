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

        public string infoFileURL;

        private void ctrlStreamInfo_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            VLCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathMPCCodec64) || File.Exists(frmOpenTheatre.pathMPC64) || File.Exists(frmOpenTheatre.pathMPC86);
            if (Properties.Settings.Default.Bookmarks.Contains(infoFileURL)) { imgAddToBookmarks.Image = Properties.Resources.bookmark_remove; } else { imgAddToBookmarks.Image = Properties.Resources.bookmark_plus; }

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
                        infoFileDateAdded.Text = UtilityTools.getTimeAgo(fileModifiedTime);
                    }
                    else { infoFileDateAdded.Text = "n/a"; }

                    int ContentLength;
                    if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out ContentLength))
                    {
                        infoFileSize.Text = UtilityTools.ToFileSize(Convert.ToDouble(ContentLength));
                    } else { infoFileSize.Text = "n/a"; }
                }
            }
            catch { infoFileSize.Text = "n/a"; infoFileDateAdded.Text = "n/a"; }
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
                Process VLC = new Process();
                VLC.StartInfo.FileName = frmOpenTheatre.pathVLC;
                VLC.StartInfo.Arguments = ("-vvv " + infoFileURL);
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
            if (Properties.Settings.Default.Bookmarks.Contains(infoFileURL))
            {
                Properties.Settings.Default.Bookmarks.Remove(infoFileURL); imgAddToBookmarks.Image = Properties.Resources.bookmark_plus;
            }
            else { Properties.Settings.Default.Bookmarks.Add(infoFileURL); imgAddToBookmarks.Image = Properties.Resources.bookmark_remove; }
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
            frmOpenTheatre.form.Show();
            frmOpenTheatre.form.doDownloadFile(infoFileURL);
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new frmVLCPlayer();
            a.Text = new Uri(infoFileURL).AbsoluteUri;
            a.axVLCPlugin21.playlist.add(infoFileURL);
            a.axVLCPlugin21.playlist.play();
            a.Show();
        }

        private void imgCopyURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(infoFileURL);
            MessageBox.Show("Successfully copied URL!");
        }
    }
}