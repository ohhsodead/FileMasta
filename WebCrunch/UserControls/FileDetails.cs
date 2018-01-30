using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using WebCrunch;
using Dialogs;
using WebCrunch.Extensions;
using WebCrunch.Bookmarks;
using WebCrunch.Utilities;
using CButtonLib;

namespace UserControls
{
    public partial class FileDetails : UserControl
    {
        public FileDetails()
        {
            InitializeComponent();
        }

        string infoFileSubtitles;

        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };

        private void ctrlFileDetails_Load(object sender, EventArgs e)
        {
            if (!Bookmarked.isBookmarked(Bookmarked.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text)))
            {
                ControlExtensions.ChangeControlText(btnSaveFile, "Add to Bookmarks");
            }
            else
            {
                ControlExtensions.ChangeControlText(btnSaveFile, "Remove from Bookmarks");
            }

            VLCToolStripMenuItem.Visible = File.Exists(MainForm.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(MainForm.pathMPCCodec64) || File.Exists(MainForm.pathMPC64) || File.Exists(MainForm.pathMPC86);

            if (videoFileTypes.Contains(infoType.Text.ToUpper()) || audioFileTypes.Contains(infoType.Text.ToUpper())) { btnPlayMedia.Visible = true; } // Shows 'Play Media' button if is valid file extension

            if (infoSize.Text == "0 Bytes") { btnRequestFileSize.Visible = true; } // Checks if file size isn't default

            if (infoFileSubtitles == null) // Add subtitle file to be played when opening external VLC
            {
                if (FileExtensions.hasExistingSubtitles(infoFileURL.Text) == true) // If downloads folder contains file matching web file name
                {
                    infoFileSubtitles = MainForm.userDownloadsDirectory + Path.GetFileNameWithoutExtension(infoFileURL.Text) + ".srt";
                }
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            MainForm.form.tab.SelectedTab = MainForm.form.currentTab;
            Parent.Controls.Clear();
        }

        private void btnDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Process.Start(infoFileURL.Text);
        }

        private void btnReportFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboboxReportFile.DroppedDown = true;
        }

        private void cmboboxReportFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboboxReportFile.SelectedIndex == 0)
            {
                ReportTemplates.openBrokenFileIssue(infoFileURL.Text);
            }
            else if (cmboboxReportFile.SelectedIndex == 1)
            {
                MessageBox.Show(this, "Please write an email to the application administrator with your appropriate details at bettercodes1@gmail.com\n\n Thank you.");
            }
            else if (cmboboxReportFile.SelectedIndex == 2)
            {
                ReportTemplates.openPoorQualityFileIssue(infoFileURL.Text);
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
                Process.Start("https://twitter.com/home?status=Check%20out%20this%20file%20I%20found%20on%20%40WebCrunch%20" + infoFileURL.Text);
            }
            else if (cmboBoxShareFile.SelectedIndex == 2)
            {
                Process.Start("https://plus.google.com/share?url=" + infoFileURL.Text);
            }
            else if (cmboBoxShareFile.SelectedIndex == 3)
            {
                Process.Start("http://reddit.com/submit?url=" + infoFileURL.Text + "&title=" + Path.GetFileNameWithoutExtension(new Uri(infoFileURL.Text).LocalPath) + "%20%5BWebCrunch%5D");
            }
            else if (cmboBoxShareFile.SelectedIndex == 4)
            {
                Process.Start("mailto:?&body=Check%20out%20this%20awesome%20file%20I%20found%20on%20WebCrunch%20-%20" + infoFileURL.Text);
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
                infoSize.Text = TextExtensions.bytesToString(FileExtensions.getFileSize(infoFileURL.Text));
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
            VLC.StartInfo.FileName = MainForm.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + infoFileURL.Text + " --sub-file=" + infoFileSubtitles);
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
            MPC.StartInfo.Arguments = (infoFileURL.Text);
            MPC.Start();
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new VLCPlayer
                {
                    Text = new Uri(infoFileURL.Text).LocalPath
                };
                a.axVLCPlugin21.playlist.add(infoFileURL.Text);
                a.axVLCPlugin21.playlist.play();
                a.Show();
            }
            catch { MessageBox.Show("Built-in player was unable to load. We are aware there are some issues with this function and are working to resolve this. For the time being, please install the VLC player on your computer and choose 'Play Media' > 'VLC' "); }
        }

        private void btnSaveFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (!Bookmarked.isBookmarked(Bookmarked.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text)))
            {
                Bookmarked.saveFile(Bookmarked.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text));
                ControlExtensions.ChangeControlText(btnSaveFile, "Remove from Bookmarks");
            }
            else
            {
                Bookmarked.unsaveFile(Bookmarked.fileToJson(infoFileURL.Text, infoName.Text, infoType.Text, infoReferrer.Text));
                ControlExtensions.ChangeControlText(btnSaveFile, "Add to Bookmarks");
            }
        }


        // Focus effect for Combobox/Button
        Bitmap tmpButtonImage = null;

        public void btnCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            tmpButtonImage = (Bitmap)ctrl.Image;
            if (ctrl.Image != null) { ctrl.Image = ImageExtensions.changeColor((Bitmap)ctrl.Image, Color.White); }
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Color.White;
            ctrl.ColorFillSolid = Colors.uiColorOrange;
        }

        public void btnCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.Image = tmpButtonImage;
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Colors.uiColorOrange;
            ctrl.ColorFillSolid = Color.Transparent;
        }

        public void comboboxCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ColorFillSolid = Colors.uiColorOrange;
        }

        public void comboboxCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorBorder;
            ctrl.ColorFillSolid = Color.Transparent;
        }

        private void infoFileURL_SideImageClicked(object Sender, MouseEventArgs e)
        {
            Clipboard.SetText(infoFileURL.Text);
            infoFileURL.SideImage = WebCrunch.Properties.Resources.clipboard_check_orange;
            infoFileURL.SideImageSize = new Size(24, 24);
        }
    }
}
