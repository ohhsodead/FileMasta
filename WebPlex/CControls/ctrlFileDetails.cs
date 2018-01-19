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
using System.IO;
using System.Net;

namespace WebPlex.CControls
{
    public partial class ctrlFileDetails : UserControl
    {
        public ctrlFileDetails()
        {
            InitializeComponent();
        }

        string infoFileSubtitles;

        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };

        private void ctrlFileDetails_Load(object sender, EventArgs e)
        {
            VLCToolStripMenuItem.Visible = File.Exists(frmWebPlex.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(frmWebPlex.pathMPCCodec64) || File.Exists(frmWebPlex.pathMPC64) || File.Exists(frmWebPlex.pathMPC86);

            if (videoFileTypes.Contains(infoType.Text.ToUpper()) || audioFileTypes.Contains(infoType.Text.ToUpper())) { btnPlayMedia.Visible = true; }

            if (infoAge.Text == "-")
            {
                try { infoAge.Text = Utilities.getTimeAgo(Convert.ToDateTime(Utilities.getLastModifiedTime(infoFileURL.Text))); } catch { infoAge.Text = "-"; }  
            }

            if (infoSize.Text == "-") { btnRequestFileSize.Visible = true; }

            if (infoFileSubtitles == null)
            {
                if (Utilities.isExistingSubtitlesFile(infoFileURL.Text) == true)
                {
                    infoFileSubtitles = frmWebPlex.userDownloadsDirectory + Path.GetFileNameWithoutExtension(infoFileURL.Text) + ".srt";
                }
            }

            if (Utilities.isSaved(Utilities.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text)))
            {
                btnSaveFile.Image = Properties.Resources.bookmark_remove;
            }
            else
            {
                btnSaveFile.Image = Properties.Resources.bookmark_plus;
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            frmWebPlex.form.tab.SelectedTab = frmWebPlex.form.currentTab;
            Parent.Controls.Clear();
        }

        private void btnDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Process.Start(infoFileURL.Text);
        }

        private void btnCopyURL_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Clipboard.SetText(infoFileURL.Text);
            btnCopyURL.SideImage = Properties.Resources.clipboard_check;
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
                Utilities.openBrokenFileIssue(infoFileURL.Text);
            }
            else if (cmboboxReportFile.SelectedIndex == 1)
            {
                MessageBox.Show(this, "Please write an email to the application administrator with your appropriate details at bettercodes1@gmail.com\n\n Thank you.");
            }
            else if (cmboboxReportFile.SelectedIndex == 2)
            {
                Utilities.openPoorQualityFileIssue(infoFileURL.Text);
            }
        }

        private void btnShareFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxShareFile.DroppedDown = true;
        }

        private void cmboBoxShareFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxShareFile.SelectedIndex == 0)
            {
                Process.Start("https://www.facebook.com/sharer/sharer.php?u=" + infoFileURL.Text);
            }
            else if (cmboBoxShareFile.SelectedIndex == 1)
            {
                Process.Start("https://twitter.com/home?status=Check%20out%20this%20file%20I%20found%20on%20%40WebPlex%20" + infoFileURL.Text);
            }
            else if (cmboBoxShareFile.SelectedIndex == 2)
            {
                Process.Start("https://plus.google.com/share?url=" + infoFileURL.Text);
            }
            else if (cmboBoxShareFile.SelectedIndex == 3)
            {
                Process.Start("http://reddit.com/submit?url=" + infoFileURL.Text + "&title=" + Path.GetFileNameWithoutExtension(new Uri(infoFileURL.Text).LocalPath) + "%20%5BWebPlex%5D");
            }
            else if (cmboBoxShareFile.SelectedIndex == 4)
            {
                Process.Start("mailto:?&body=Check%20out%20this%20awesome%20file%20I%20found%20on%20WebPlex%20-%20" + infoFileURL.Text);
            }
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
                        infoSize.Text = Utilities.bytesToString(ContentLength);
                    }
                    else { infoSize.Text = "Error"; }
                }
            }
            catch { infoSize.Text = "Error"; }
        }

        private void btnViewDirectory_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Uri uri = new Uri(infoFileURL.Text);
            string parentName = GetParentUriString(uri).Remove(GetParentUriString(uri).Length - 1);

            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = parentName;
            browser.Start();            
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
            VLC.StartInfo.FileName = frmWebPlex.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + infoFileURL.Text + " --sub-file=" + infoFileSubtitles);
            VLC.Start();
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process MPC = new Process();
            if (File.Exists(frmWebPlex.pathMPCCodec64))
                MPC.StartInfo.FileName = frmWebPlex.pathMPCCodec64;
            else if (File.Exists(frmWebPlex.pathMPC64))
                MPC.StartInfo.FileName = frmWebPlex.pathMPC64;
            else
                MPC.StartInfo.FileName = frmWebPlex.pathMPC86;
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
            if (!Utilities.isSaved(Utilities.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text)))
            {
                Utilities.saveFile(Utilities.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text));
                btnSaveFile.Image = Properties.Resources.bookmark_remove;
            }
            else
            {
                Utilities.unsaveFile(Utilities.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text));
                btnSaveFile.Image = Properties.Resources.bookmark_plus;
            }
        }
    }
}
