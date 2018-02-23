using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using CButtonLib;
using WebCrunch.Bookmarks;
using WebCrunch.Models;
using WebCrunch.Extensions;
using WebCrunch.GitHub;
using WebCrunch.Asynchronous;
using WebCrunch.Dialogs;
using WebCrunch.Files;

namespace WebCrunch.Controls
{
    public partial class FileDetails : UserControl
    {
        public FileDetails()
        {
            InitializeComponent();
        }

        public WebFile currentFile;
        string infoFileSubtitles;

        /* Support file types for the players */
        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };

        private void ctrlFileDetails_Load(object sender, EventArgs e)
        {
            CheckFileEvents();
        }

        public void CheckFileEvents()
        {
            /* Shows appropriate Bookmarks button text */
            if (!Bookmarked.IsBookmarked(currentFile.URL))
                ControlExtensions.SetControlText(btnBookmarkFile, "Add to Bookmarks");            
            else
                ControlExtensions.SetControlText(btnBookmarkFile, "Remove from Bookmarks");            

            /* Support media players installed on users machine */
            VLCToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathVLC);
            MPCToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathMPCCodec64) || File.Exists(LocalExtensions.pathMPC64) || File.Exists(LocalExtensions.pathMPC86);

            /* Shows 'Play Media' button if is valid file extension */
            if (videoFileTypes.Contains(currentFile.Type) || audioFileTypes.Contains(currentFile.Type))
                btnPlayMedia.Visible = true;
            else
                btnPlayMedia.Visible = false;

            /* Checks if file size isn't default */
            if (currentFile.Size == 0)
                btnRequestFileSize.Visible = true;
            else
                btnRequestFileSize.Visible = false;

            /* Add subtitle file to be played when opening external VLC */
            if (FileExtensions.HasExistingLocalSubtitles(currentFile.URL) == true) /* If users downloads folder contains a subtitle file matching web file name */
                infoFileSubtitles = LocalExtensions.userDownloadsDirectory + Path.GetFileNameWithoutExtension(currentFile.URL) + ".srt";
            else
                infoFileSubtitles = null;

            /* Displays appropriate scroll images */
            ScrollButtonChecks();
        }

        private void ScrollButtonChecks()
        {
            if (MainForm.form.dataGridFiles.Rows.Count > 0) {
                if (MainForm.form.dataGridFiles.SelectedCells[0].OwningRow.Index == 0)
                    imgPreviousFile.Image = ImageExtensions.ChangeColor(WebCrunch.Properties.Resources.chevron_left, Color.Gray);
                else
                    imgPreviousFile.Image = WebCrunch.Properties.Resources.chevron_left;

                if (MainForm.form.dataGridFiles.SelectedCells[0].OwningRow.Index == MainForm.form.dataGridFiles.Rows.Count - 1)
                    imgNextFile.Image = ImageExtensions.ChangeColor(WebCrunch.Properties.Resources.chevron_right, Color.Gray);
                else
                    imgNextFile.Image = WebCrunch.Properties.Resources.chevron_right;
            }
            else {
                imgPreviousFile.Image = ImageExtensions.ChangeColor(WebCrunch.Properties.Resources.chevron_left, Color.Gray);
                imgNextFile.Image = ImageExtensions.ChangeColor(WebCrunch.Properties.Resources.chevron_right, Color.Gray);
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            MainForm.form.tab.SelectedTab = MainForm.form.CurrentTab;
            MainForm.frmFileDetails.Dispose();
        }

        private void btnDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Process.Start(currentFile.URL);
        }

        private void btnReportFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboboxReportFile.DroppedDown = true;
        }

        private void cmboboxReportFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboboxReportFile.SelectedIndex == 0)
                OpenLink.BrokenFileIssue(currentFile);
            else if (cmboboxReportFile.SelectedIndex == 1)
                MessageBox.Show(this, "Please write an email to the application administrator with your appropriate details at bettercodes1@gmail.com\n\n Thank you.");
            else if (cmboboxReportFile.SelectedIndex == 2)
                OpenLink.PoorQualityFileIssue(currentFile);
        }

        private void btnShareFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxShareFile.DroppedDown = true;
        }

        private void cmboBoxShareFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxShareFile.SelectedIndex == 0)
                Process.Start("https://www.facebook.com/sharer/sharer.php?u=" + currentFile.URL);
            else if (cmboBoxShareFile.SelectedIndex == 1)
                Process.Start("https://twitter.com/home?status=Check%20out%20this%20file%20I%20found%20on%20%40WebCrunch%20" + currentFile.URL);
            else if (cmboBoxShareFile.SelectedIndex == 2)
                Process.Start("https://plus.google.com/share?url=" + currentFile.URL);
            else if (cmboBoxShareFile.SelectedIndex == 3)
                Process.Start("http://reddit.com/submit?url=" + currentFile.URL + "&title=" + currentFile.Name + "%20%5BWebCrunch%5D");
            else if (cmboBoxShareFile.SelectedIndex == 4)
                Process.Start("mailto:?&body=Check%20out%20this%20awesome%20file%20I%20found%20on%20WebCrunch%20-%20" + currentFile.URL);
        }

        private void infoDirectory_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(currentFile.URL);
            string parentName = GetParentUriString(uri).Remove(GetParentUriString(uri).Length - 1);
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = parentName;
            browser.Start();
        }

        static string GetParentUriString(Uri uri)
        {
            StringBuilder parentName = new StringBuilder();
            parentName.Append(uri.Scheme);
            parentName.Append("://");
            parentName.Append(uri.Host);
            for (int i = 0; i < uri.Segments.Length - 1; i++)
                parentName.Append(uri.Segments[i]);
            return parentName.ToString();
        }

        private void infoReferrer_Click(object sender, EventArgs e)
        {
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = new Uri(currentFile.URL).GetLeftPart(UriPartial.Authority).ToString();
            browser.Start();
        }

        private void btnRequestFileSize_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try {
                btnRequestFileSize.Visible = false;
                BackGroundWorker.RunWorkAsync<string>(() => TextExtensions.BytesToString(FileExtensions.GetFileSize(currentFile.URL)), (data) => { infoSize.Text = data; });
            }
            catch { infoSize.Text = "Error"; }
        }

        private void btnViewDirectory_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            string parentName = GetParentUriString(new Uri(currentFile.URL)).Remove(GetParentUriString(new Uri(currentFile.URL)).Length - 1);

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
            Process.Start("wmplayer.exe", currentFile.URL);
        }

        private void VLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open source file in VLC with subtitles
            Process VLC = new Process();
            VLC.StartInfo.FileName = LocalExtensions.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + currentFile.URL + " --sub-file=" + infoFileSubtitles);
            VLC.Start();
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process MPC = new Process();
            if (File.Exists(LocalExtensions.pathMPCCodec64))
                MPC.StartInfo.FileName = LocalExtensions.pathMPCCodec64;
            else if (File.Exists(LocalExtensions.pathMPC64))
                MPC.StartInfo.FileName = LocalExtensions.pathMPC64;
            else
                MPC.StartInfo.FileName = LocalExtensions.pathMPC86;
            MPC.StartInfo.Arguments = (currentFile.URL);
            MPC.Start();
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new VLCPlayer { Text = new Uri(currentFile.URL).LocalPath };
                a.axVLCPlugin21.playlist.add(currentFile.URL);
                a.axVLCPlugin21.playlist.play();
                a.Show();
            }
            catch { MessageBox.Show("Built-in player was unable to load. We are aware there are some issues with this function and are working to resolve this. For the time being, please install the VLC player on your computer and choose 'Play Media' > 'VLC' "); }
        }

        private void BtnBookmarkFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (Bookmarked.IsBookmarked(currentFile.URL)) {
                Bookmarked.UnsaveFile(currentFile.URL);
                ControlExtensions.SetControlText(btnBookmarkFile, "Add to Bookmarks");
            }
            else {
                Bookmarked.SaveFile(currentFile.URL);
                ControlExtensions.SetControlText(btnBookmarkFile, "Remove from Bookmarks");
            }
        }

        // Focus effect for Combobox/Button
        public void ComboboxCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Color.White;
            ctrl.ColorFillSolid = Colors.uiColorOrange;
        }

        public void ComboboxCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorGray;
            ctrl.ForeColor = Colors.uiColorGray;
            ctrl.ColorFillSolid = Color.Transparent;
        }

        private void infoFileURL_SideImageClicked(object Sender, MouseEventArgs e)
        {
            Clipboard.SetText(currentFile.URL);
            infoFileURL.SideImage = WebCrunch.Properties.Resources.clipboard_check_orange;
            infoFileURL.SideImageSize = new Size(24, 24);
        }

        private void SelectUpRow()
        {
            DataGridView dgv = MainForm.form.dataGridFiles;
            if (dgv.Rows.Count > 0) {
                int totalRows = dgv.Rows.Count;
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.ClearSelection();
                dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;

                if (MainForm.form.dataGridFiles.CurrentRow.Cells[4].Value.ToString() == "Local")
                    MainForm.form.ShowFileDetails(Database.FileInfoFromURL(MainForm.form.dataGridFiles.CurrentRow.Cells[5].Value.ToString()), false);                
                else 
                    MainForm.form.ShowFileDetails(Database.FileInfoFromURL(MainForm.form.dataGridFiles.CurrentRow.Cells[5].Value.ToString()), false);

                ScrollButtonChecks();
            }
        }

        private void SelectDownRow()
        {
            DataGridView dgv = MainForm.form.dataGridFiles;
            if (dgv.Rows.Count > 0) {
                int totalRows = dgv.Rows.Count;
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;

                if (MainForm.form.dataGridFiles.CurrentRow.Cells[4].Value.ToString() == "local")
                    MainForm.form.ShowFileDetails(Database.FileInfoFromURL(MainForm.form.dataGridFiles.CurrentRow.Cells[5].Value.ToString()), false);
                else
                    MainForm.form.ShowFileDetails(Database.FileInfoFromURL(MainForm.form.dataGridFiles.CurrentRow.Cells[5].Value.ToString()), false);

                ScrollButtonChecks();
            }
        }

        private void imgPreviousFile_Click(object sender, EventArgs e)
        {
            SelectUpRow();
        }

        private void imgNextFile_Click(object sender, EventArgs e)
        {
            SelectDownRow();
        }
    }
}
