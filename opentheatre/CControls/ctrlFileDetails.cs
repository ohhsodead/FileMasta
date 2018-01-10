using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Utilities;
using System.IO;
using System.Net;
using DatabaseFilesAPI;

namespace OpenTheatre.CControls
{
    public partial class ctrlFileDetails : UserControl
    {
        public ctrlFileDetails()
        {
            InitializeComponent();
        }

        string infoFileSubtitles;

        static string[] videoFileTypes = { "MP4", "MKV", "AVI", "MPEG" };
        static string[] audioFileTypes = { "MP3", "WMA", "WAV", "M3U", "APE" };

        private void ctrlFileDetails_Load(object sender, EventArgs e)
        {
            VLCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(frmOpenTheatre.pathMPCCodec64) || File.Exists(frmOpenTheatre.pathMPC64) || File.Exists(frmOpenTheatre.pathMPC86);

            if (infoSize.Text == "-") { btnRequestFileSize.Visible = true; }
            if (videoFileTypes.Contains(infoType.Text.ToUpper()) || audioFileTypes.Contains(infoType.Text.ToUpper())) { btnPlayMedia.Visible = true; }
            if (infoAge.Text == "-")
            {
                try
                {
                    WebRequest req = WebRequest.Create(infoFileURL.Text);
                    req.Method = "HEAD";
                    req.Timeout = 3000;
                    using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                    {
                        DateTime fileModifiedTime = fileResponse.LastModified;
                        if (fileModifiedTime != null)
                        {
                            infoAge.Text = UtilityTools.getTimeAgo(Convert.ToDateTime(fileModifiedTime.ToString()));
                        }
                        else { infoAge.Text = "-"; }
                    }
                }
                catch { }          
            }

            if (infoFileSubtitles == null)
            {
                if (UtilityTools.isExistingSubtitlesFile(infoFileURL.Text) == true)
                {
                    infoFileSubtitles = frmOpenTheatre.userDownloadsDirectory + Path.GetFileNameWithoutExtension(infoFileURL.Text) + ".srt";
                }
            }

            if (UtilityTools.isSaved(UtilityTools.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text)))
            {
                btnSaveFile.Image = Properties.Resources.bookmark_remove_black;
            }
            else
            {
                btnSaveFile.Image = Properties.Resources.bookmark_plus_black;
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            frmOpenTheatre.form.tab.SelectedTab = frmOpenTheatre.form.currentTab;
            Parent.Controls.Clear();
        }

        private void btnDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Process.Start(infoFileURL.Text);
        }

        private void btnCopyURL_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Clipboard.SetText(infoFileURL.Text);
            btnCopyURL.SideImage = Properties.Resources.clipboard_check_black;
            btnCopyURL.SideImageSize = new Size(22, 22);
        }

        private void btnReportFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboboxReportFile.DroppedDown = true;
        }

        private void cmboboxReportFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboboxReportFile.SelectedIndex == 0)
            {
                UtilityTools.openBrokenFileIssue(infoFileURL.Text);
            }
            else if (cmboboxReportFile.SelectedIndex == 1)
            {
                MessageBox.Show("Please write an email to the database administrator with your appropriate details at bettercodes1@gmail.com\n\n Thank you.");
            }
            else if (cmboboxReportFile.SelectedIndex == 2)
            {
                UtilityTools.openPoorQualityFileIssue(infoFileURL.Text);
            }
        }

        private void btnShareFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            var a = new frmShareFile();
            a.infoFileURL = infoFileURL.Text;
            a.ShowDialog(this);
        }

        private void infoDirectory_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(infoFileURL.Text);
            string parentName = GetParentUriString(uri).Remove(GetParentUriString(uri).Length - 1);

            Process browser = new Process();

            // true is the default, but it is important not to set it to false
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = parentName;
            browser.Start();
        }

        static string GetParentUriString(Uri uri)
        {
            StringBuilder parentName = new StringBuilder();

            // Append the scheme: http, ftp etc.
            parentName.Append(uri.Scheme);

            // Appned the '://' after the http, ftp etc.
            parentName.Append("://");

            // Append the host name www.foo.com
            parentName.Append(uri.Host);

            // Append each segment except the last one. The last one is the
            // leaf and we will ignore it.
            for (int i = 0; i < uri.Segments.Length - 1; i++)
            {
                parentName.Append(uri.Segments[i]);
            }
            return parentName.ToString();
        }

        private void infoReferrer_Click(object sender, EventArgs e)
        {
            Process browser = new Process();

            // true is the default, but it is important not to set it to false
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = new Uri(infoFileURL.Text).GetLeftPart(UriPartial.Authority).ToString();
            browser.Start();
        }

        private void btnRequestFileSize_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try
            {
                btnRequestFileSize.Visible = false;

                WebRequest req = WebRequest.Create(infoFileURL.Text);
                req.Method = "HEAD";
                req.Timeout = 7000;
                using (HttpWebResponse fileResponse = (HttpWebResponse)req.GetResponse())
                {
                    int ContentLength;
                    if (int.TryParse(fileResponse.Headers.Get("Content-Length"), out ContentLength))
                    {
                        infoSize.Text = UtilityTools.ToFileSize(Convert.ToDouble(ContentLength));
                    }
                    else { infoSize.Text = "Error"; }
                }
            }
            catch { infoSize.Text = "Error"; }
        }

        private void btnViewDirectory_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            var url = new Uri(infoFileURL.Text);
            var directoryText = new StringBuilder(infoReferrer.Text);
            foreach (string path in url.LocalPath.Split('/'))
            {
                if (!Path.HasExtension(path)) { directoryText.Append(path + "/"); };
            }

            Process.Start(directoryText.ToString());
            Parent.Controls.Clear();
        }

        private void btnPlayMedia_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            contextFileName.Show(btnPlayMedia, btnPlayMedia.PointToClient(Cursor.Position));
        }

        private void WMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wmplayer.exe", infoFileURL.Text);
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
            MPC.StartInfo.Arguments = (infoFileURL.Text);
            MPC.Start();
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new frmVLCPlayer
            {
                Text = new Uri(infoFileURL.Text).LocalPath
            };
            a.axVLCPlugin21.playlist.add(infoFileURL.Text);
            a.axVLCPlugin21.playlist.play();
            a.Show();
        }

        private void btnSaveFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (!UtilityTools.isSaved(UtilityTools.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text)))
            {
                UtilityTools.saveFile(UtilityTools.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text));
                btnSaveFile.Image = Properties.Resources.bookmark_remove_black;
            }
            else
            {
                UtilityTools.unsaveFile(UtilityTools.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text));
                btnSaveFile.Image = Properties.Resources.bookmark_plus_black;
            }
        }
    }
}
