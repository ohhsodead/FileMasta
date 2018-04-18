using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using FileMasta.Bookmarks;
using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.GitHub;
using FileMasta.Models;
using FileMasta.Windows;
using FileMasta.Worker;

namespace FileMasta.Controls
{
    public partial class FileDetails : UserControl
    {
        public FileDetails()
        {
            InitializeComponent();
        }

        public WebFile currentFile;
        public DataGridView parentDataGrid;
        string infoFileSubtitles;

        // Support file types for the players
        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };

        private void ctrlFileDetails_Load(object sender, EventArgs e)
        {
            CheckFileEvents();
        }

        public void CheckFileEvents()
        {
            // Shows appropriate Bookmarks button text
            if (!UserBookmarks.IsBookmarked(currentFile.URL))
                ControlExtensions.SetControlText(buttonBookmarkFile, "Add to Bookmarks");            
            else
                ControlExtensions.SetControlText(buttonBookmarkFile, "Remove from Bookmarks");

            // Shows 'Play Media' button if this file has a supported file extension
            if (videoFileTypes.Contains(currentFile.Type) || audioFileTypes.Contains(currentFile.Type))
            {
                // Support media players installed on users machine
                VLC2ToolStripMenuItem.Visible = true;
                WMPToolStripMenuItem.Visible = true;
                VLCToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathVLC);
                MPCToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathMPCCodec64) || File.Exists(LocalExtensions.pathMPC64) || File.Exists(LocalExtensions.pathMPC86);
            }

            // Support download manangers installed on users machine, shown if this isn't a local file
            IDMToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathIDMAN64) || File.Exists(LocalExtensions.pathIDMAN86) && !currentFile.URL.StartsWith(LocalExtensions.userDownloadsDirectory);

            if (contextOpenFile.Items.Count != 0)
            {
                buttonOpenFile.Visible = true;
            }

            // Shows Request File Size button if size property returns 0
            if (currentFile.Size == 0)
                buttonRequestFileSize.Visible = true;
            else
                buttonRequestFileSize.Visible = false;

            // Add subtitle file to be played when opening external VLC
            if (LocalExtensions.HasExistingSubtitle(currentFile.URL) == true) // If users downloads folder contains a subtitle file matching web file name
                infoFileSubtitles = LocalExtensions.userDownloadsDirectory + Path.GetFileNameWithoutExtension(currentFile.URL) + ".srt";
            else
                infoFileSubtitles = null;

            // Displays appropriate scroll images
            ScrollButtonChecks();
        }

        private void ScrollButtonChecks()
        {
            if (parentDataGrid.Rows.Count > 0) {
                if (parentDataGrid.SelectedCells[0].OwningRow.Index == 0)
                    imagePreviousFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_up, Color.Gray);
                else
                    imagePreviousFile.Image = Properties.Resources.chevron_up;

                if (parentDataGrid.SelectedCells[0].OwningRow.Index == parentDataGrid.Rows.Count - 1)
                    imageNextFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_down, Color.Gray);
                else
                    imageNextFile.Image = Properties.Resources.chevron_down;
            }
            else {
                imagePreviousFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_up, Color.Gray);
                imageNextFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_down, Color.Gray);
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            // Close file details
            MainForm.Form.tab.SelectedTab = MainForm.Form.CurrentTab;
            MainForm.FrmFileDetails.Dispose();
        }

        private void btnDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try
            {
                // Open file in default web browser, or if local then default program
                // Crashes when no application set for the extension, so I used Try to let the user know if this is the case
                Process.Start(currentFile.URL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open file\n\n" + ex.Message);
            }
        }

        // Report File button
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

        // Share File button
        private void cmboBoxShareFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxShareFile.SelectedIndex == 0)
                Process.Start("https://www.facebook.com/sharer/sharer.php?u=" + currentFile.URL);
            else if (cmboBoxShareFile.SelectedIndex == 1)
                Process.Start("https://twitter.com/home?status=Check%20out%20this%20file%20I%20found%20on%20%40FileMasta%20" + currentFile.URL);
            else if (cmboBoxShareFile.SelectedIndex == 2)
                Process.Start("https://plus.google.com/share?url=" + currentFile.URL);
            else if (cmboBoxShareFile.SelectedIndex == 3)
                Process.Start("http://reddit.com/submit?url=" + currentFile.URL + "&title=" + currentFile.Name + "%20%5BFileMasta%5D");
            else if (cmboBoxShareFile.SelectedIndex == 4)
                Process.Start("mailto:?&body=Check%20out%20this%20awesome%20file%20I%20found%20on%20FileMasta%20-%20" + currentFile.URL);
        }

        private void infoDirectory_Click(object sender, EventArgs e)
        {
            // Open file parent directory in default web browser
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = TextExtensions.GetParentUriString(new Uri(currentFile.URL)).Remove(TextExtensions.GetParentUriString(new Uri(currentFile.URL)).Length - 1);;
            browser.Start();
        }

        private void infoReferrer_Click(object sender, EventArgs e)
        {
            // Open file host in default web browser
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = new Uri(currentFile.URL).GetLeftPart(UriPartial.Authority).ToString();
            browser.Start();
        }

        private void btnRequestFileSize_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            // Request file size from URL
            buttonRequestFileSize.Visible = false;
            BackGroundWorker.RunWorkAsync<string>(() => TextExtensions.BytesToString(WebFileExtensions.GetFileSize(currentFile.URL)), (data) => { infoSize.Text = data; });
        }

        private void btnViewDirectory_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            // Open parent directory of file in default web browser
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = TextExtensions.GetParentUriString(new Uri(currentFile.URL)).Remove(TextExtensions.GetParentUriString(new Uri(currentFile.URL)).Length - 1); ;
            browser.Start();            
        }

        private void btnPlayMedia_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            contextOpenFile.Show(buttonOpenFile, buttonOpenFile.PointToClient(Cursor.Position));
        }


        // Opening File...

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file in built-in VLC player
                var a = new VLCPlayer { Text = new Uri(currentFile.URL).LocalPath };
                a.axVLCPlugin21.playlist.add(currentFile.URL);
                a.axVLCPlugin21.playlist.play();
                a.Show();
            }
            catch { MessageBox.Show("Built-in player was unable to load. We are aware there are some issues with this function and are working to resolve this. For the time being, please install the VLC player on your computer and choose 'Play Media' > 'VLC' "); }
        }

        private void WMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Windows Media Player
            Process.Start("wmplayer.exe", currentFile.URL);
        }

        private void VLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in VLC player, with subtitles (if found)
            Process VLC = new Process();
            VLC.StartInfo.FileName = LocalExtensions.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + currentFile.URL + " --sub-file=" + infoFileSubtitles);
            VLC.Start();
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Media Player Classic
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

        private void IDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Internet Download Manager
            Process IDM = new Process();
            if (File.Exists(LocalExtensions.pathIDMAN64))
                IDM.StartInfo.FileName = LocalExtensions.pathIDMAN64;
            else
                IDM.StartInfo.FileName = LocalExtensions.pathIDMAN86;
            IDM.StartInfo.Arguments = ("-d " + currentFile.URL);
            IDM.Start();
        }

        private void BtnBookmarkFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            // Add/Remove file from users Bookmarks
            if (UserBookmarks.IsBookmarked(currentFile.URL)) {
                UserBookmarks.RemoveFile(currentFile.URL);
                ControlExtensions.SetControlText(buttonBookmarkFile, "Add to Bookmarks");
            }
            else {
                UserBookmarks.AddFile(currentFile.URL);
                ControlExtensions.SetControlText(buttonBookmarkFile, "Remove from Bookmarks");
            }
        }

        private void infoFileURL_SideImageClicked(object Sender, MouseEventArgs e)
        {
            // Set file URL to clipboard
            Clipboard.SetText(currentFile.URL);
            infoFileURL.SideImage = Properties.Resources.clipboard_check_orange;
            infoFileURL.SideImageSize = new Size(24, 24);
        }

        /// <summary>
        /// Go up a row on dataGridFiles and select it
        /// </summary>
        private void SelectUpRow()
        {
            if (parentDataGrid.Rows.Count > 0) {
                int totalRows = parentDataGrid.Rows.Count;
                int rowIndex = parentDataGrid.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                int colIndex = parentDataGrid.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = parentDataGrid.Rows[rowIndex];
                parentDataGrid.ClearSelection();
                parentDataGrid.Rows[rowIndex - 1].Cells[colIndex].Selected = true;

                var URL = parentDataGrid.CurrentRow.Cells[5].Value.ToString();

                if (parentDataGrid.CurrentRow.Cells[4].Value.ToString() == "Local")
                    MainForm.Form.ShowFileDetails(new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), new FileInfo(URL).Length, File.GetCreationTime(URL), "Local", URL), parentDataGrid, false);
                else 
                    MainForm.Form.ShowFileDetails(Database.FileInfoFromURL(URL), parentDataGrid, false);

                ScrollButtonChecks();
            }
        }

        /// <summary>
        /// Go down a row on dataGridFiles and select it
        /// </summary>
        private void SelectDownRow()
        {
            if (parentDataGrid.Rows.Count > 0) {
                int totalRows = parentDataGrid.Rows.Count;
                int rowIndex = parentDataGrid.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                int colIndex = parentDataGrid.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = parentDataGrid.Rows[rowIndex];
                parentDataGrid.ClearSelection();
                parentDataGrid.Rows[rowIndex + 1].Cells[colIndex].Selected = true;

                var URL = parentDataGrid.CurrentRow.Cells[5].Value.ToString();

                if (parentDataGrid.CurrentRow.Cells[4].Value.ToString() == "Local")
                    MainForm.Form.ShowFileDetails(new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), new FileInfo(URL).Length, File.GetCreationTime(URL), "Local", URL), parentDataGrid, false);
                else
                    MainForm.Form.ShowFileDetails(Database.FileInfoFromURL(URL), parentDataGrid, false);

                ScrollButtonChecks();
            }
        }

        // Navigate Files with arrows
        private void imgPreviousFile_Click(object sender, EventArgs e)
        {
            SelectUpRow();
        }

        private void imgNextFile_Click(object sender, EventArgs e)
        {
            SelectDownRow();
        }

        /*************************************************************************/
        /* Keyboard Shortcuts                                                    */
        /*************************************************************************/

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // Scroll through files with up/down arrow keys
                case Keys.Up:
                    SelectUpRow();
                    return true;
                case Keys.Down:
                    SelectDownRow();
                    return true;
                // Click Bookmarks button
                case Keys.Control | Keys.B:
                    buttonBookmarkFile.PerformClick();
                    return true;
                // Clicks View Directory button
                case Keys.Control | Keys.V:
                    buttonViewDirectory.PerformClick();
                    return true;
                // Clicks Direct Link button
                case Keys.Control | Keys.D:
                    buttonDirectLink.PerformClick();
                    return true;
                // Click Report File button
                case Keys.Control | Keys.E:
                    buttonReport.PerformClick();
                    return true;
                // Click Share File button
                case Keys.Control | Keys.S:
                    buttonShare.PerformClick();
                    return true;
                // Click Request File Size button
                case Keys.Control | Keys.R:
                    buttonRequestFileSize.PerformClick();
                    return true;
                // Click Open File button
                case Keys.Control | Keys.O:
                    buttonOpenFile.PerformClick();
                    return true;
                // Close this instance
                case Keys.Escape:
                    MainForm.Form.tab.SelectedTab = MainForm.Form.CurrentTab;
                    MainForm.FrmFileDetails.Dispose();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}