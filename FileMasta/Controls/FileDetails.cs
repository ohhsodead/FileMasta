using FileMasta.Bookmarks;
using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.GitHub;
using FileMasta.Models;
using FileMasta.Windows;
using FileMasta.Worker;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System;

namespace FileMasta.Controls
{
    public partial class FileDetails : UserControl
    {
        public FileDetails()
        {
            InitializeComponent();
        }

        public WebFile CurrentFile { get; set; }
        public DataGridView ParentDataGrid { get; set; }
        public bool IsLocalFile { get; set; }
        string FileSubtitles { get; set; }

        /// <summary>
        /// Supported file types for all the external applications
        /// </summary>
        public static List<string> VideoFileTypes { get; } = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> AudioFileTypes { get; } = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };
        public static List<string> ImageFileTypes { get; } = new List<string>() { "TIFF", "TIF", "JPEG", "JPG", "BMP", "GIF", "PNG", "EPS", "RAW", "SVG" };
        public static List<string> BookFileTypes { get; } = new List<string>() { "MOBI", "CBZ", "CBR", "CBC", "CHM", "EPUB", "FB2", "LIT", "LRF", "ODT", "PDF", "PRC", "PDB", "PML", "RB", "RTF", "TCR", "DOC", "DOCX" };
        public static List<string> TextFileTypes { get; } = new List<string>() { "JSP", "PL", "PHP", "HTML", "ASPX", "XML", "TXT", "SQL", "CSV" };

        private void FileDetails_Load(object sender, EventArgs e)
        {
            CheckFileEvents();
        }

        public void CheckFileEvents()
        {
            // Hides all open file items
            foreach (ToolStripMenuItem item in contextOpenFile.Items)
                item.Visible = false;

            // Shows appropriate Bookmarks button text
            if (!UserBookmarks.IsBookmarked(CurrentFile.URL))
                ControlExtensions.SetControlText(buttonBookmarkFile, "Add to Bookmarks");            
            else
                ControlExtensions.SetControlText(buttonBookmarkFile, "Remove from Bookmarks");

            // Shows supported pdf readers installed on users machine
            if (BookFileTypes.Contains(CurrentFile.Type))
            {
                NitroReaderToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathNitroReader);
            }

            // Shows supported pdf readers installed on users machine
            if (TextFileTypes.Contains(CurrentFile.Type))
            {

            }

            // Shows supported media players installed on users machine
            if (VideoFileTypes.Contains(CurrentFile.Type) || AudioFileTypes.Contains(CurrentFile.Type))
            {
                VLC2ToolStripMenuItem.Visible = true;
                WMPToolStripMenuItem.Visible = true;
                VLCToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathVLC);
                MPCToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathMPCCodec64) || File.Exists(LocalExtensions.pathMPC64) || File.Exists(LocalExtensions.pathMPC86);
                KMPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathKMPlayer);
                PotPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathPotPlayer);
            }

            // Support download manangers installed on users machine, only shown if this isn't a local file
            if (!IsLocalFile)
            {
                IDMToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathIDM64) || File.Exists(LocalExtensions.pathIDM86) && !CurrentFile.URL.StartsWith(LocalExtensions.pathDownloadsDirectory);
                FDMToolStripMenuItem.Visible = File.Exists(LocalExtensions.pathFDM) && !CurrentFile.URL.StartsWith(LocalExtensions.pathDownloadsDirectory);
            }

            // Shows Open File button if context menu has items
            if (contextOpenFile.Items.Count > 0)
            {
                buttonOpenWith.Visible = true;
            }

            // Shows Request File Size button if size property returns 0
            if (CurrentFile.Size == 0)
                buttonRequestFileSize.Visible = true;
            else
                buttonRequestFileSize.Visible = false;

            // Hides features that aren't needed for local files (Bookmark, Share & Report)
            if (IsLocalFile)
            {
                buttonBookmarkFile.Visible = false;
                panelShare.Visible = false;
                panelReport.Visible = false;
            }

            // Add subtitle file to be played when opening external VLC
            if (LocalExtensions.IsSubtitlesAvailable(CurrentFile.URL)) // If users downloads folder contains a subtitle file matching web file name
                FileSubtitles = LocalExtensions.pathDownloadsDirectory + Path.GetFileNameWithoutExtension(CurrentFile.URL) + ".srt";
            else
                FileSubtitles = null;

            // Displays appropriate scroll images
            ScrollButtonChecks();
        }

        private void ScrollButtonChecks()
        {
            if (ParentDataGrid.Rows.Count > 0) {
                if (ParentDataGrid.SelectedCells[0].OwningRow.Index == 0)
                    imagePreviousFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_up, Color.Gray);
                else
                    imagePreviousFile.Image = Properties.Resources.chevron_up;

                if (ParentDataGrid.SelectedCells[0].OwningRow.Index == ParentDataGrid.Rows.Count - 1)
                    imageNextFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_down, Color.Gray);
                else
                    imageNextFile.Image = Properties.Resources.chevron_down;
            }
            else
            {
                imagePreviousFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_up, Color.Gray);
                imageNextFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_down, Color.Gray);
            }
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            // Close file details
            MainForm.Form.tab.SelectedTab = MainForm.Form.CurrentTab;
            MainForm.FrmFileDetails.Dispose();
        }

        private void BtnDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try
            {
                // Open file in default web browser, or if local then default program
                // Crashes when no application set for the extension, so I used Try to let the user know if this is the case
                Process.Start(CurrentFile.URL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open file\n\n" + ex.Message);
            }
        }
        
        // Bookmark Button
        private void BtnBookmarkFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            // Add/Remove file from users Bookmarks
            if (UserBookmarks.IsBookmarked(CurrentFile.URL))
            {
                UserBookmarks.RemoveFile(CurrentFile.URL);
                ControlExtensions.SetControlText(buttonBookmarkFile, "Add to Bookmarks");
            }
            else
            {
                UserBookmarks.AddFile(CurrentFile.URL);
                ControlExtensions.SetControlText(buttonBookmarkFile, "Remove from Bookmarks");
            }
        }

        // Report File button
        private void BtnReportFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            comboReportFile.DroppedDown = true;
        }

        private void ComboboxReportFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReportFile.SelectedIndex == 0)
                OpenLink.BrokenFileIssue(CurrentFile);
            else if (comboReportFile.SelectedIndex == 1)
                MessageBox.Show(this, "Please write an email to the application administrator with your appropriate details at bettercodes1@gmail.com\n\n Thank you.");
            else if (comboReportFile.SelectedIndex == 2)
                OpenLink.PoorQualityFileIssue(CurrentFile);
        }

        private void BtnShareFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            comboShareFile.DroppedDown = true;
        }

        // Share File button
        private void ComboBoxShareFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboShareFile.SelectedIndex == 0)
                Process.Start("https://www.facebook.com/sharer/sharer.php?u=" + CurrentFile.URL);
            else if (comboShareFile.SelectedIndex == 1)
                Process.Start("https://twitter.com/home?status=Check%20out%20this%20file%20I%20found%20on%20%40FileMasta%20" + CurrentFile.URL);
            else if (comboShareFile.SelectedIndex == 2)
                Process.Start("https://plus.google.com/share?url=" + CurrentFile.URL);
            else if (comboShareFile.SelectedIndex == 3)
                Process.Start("http://reddit.com/submit?url=" + CurrentFile.URL + "&title=" + CurrentFile.Name + "%20%5BFileMasta%5D");
            else if (comboShareFile.SelectedIndex == 4)
                Process.Start("mailto:?&body=Check%20out%20this%20awesome%20file%20I%20found%20on%20FileMasta%20-%20" + CurrentFile.URL);
        }

        private void InfoDirectory_Click(object sender, EventArgs e)
        {
            // Open file parent directory in default web browser
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = StringExtensions.ParentDirectory(new Uri(CurrentFile.URL)).Remove(StringExtensions.ParentDirectory(new Uri(CurrentFile.URL)).Length - 1);;
            browser.Start();
        }

        private void InfoReferrer_Click(object sender, EventArgs e)
        {
            if (!IsLocalFile)
            {
                // Open file host in default web browser
                Process browser = new Process();
                browser.StartInfo.UseShellExecute = true;
                browser.StartInfo.FileName = new Uri(CurrentFile.URL).GetLeftPart(UriPartial.Authority).ToString();
                browser.Start();
            }            
        }

        private void BtnRequestFileSize_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            // Request file size from URL
            buttonRequestFileSize.Visible = false;
            BackGroundWorker.RunWorkAsync<string>(() => StringExtensions.BytesToPrefix(WebFileExtensions.FileSize(CurrentFile.URL)), (data) => { labelValueSize.Text = data; });
        }

        private void BtnViewDirectory_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            // Open parent directory of file in default web browser
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = StringExtensions.ParentDirectory(new Uri(CurrentFile.URL)).Remove(StringExtensions.ParentDirectory(new Uri(CurrentFile.URL)).Length - 1); ;
            browser.Start();            
        }

        // Opening File...

        private void BtnOpenFile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            contextOpenFile.Show(buttonOpenWith, buttonOpenWith.PointToClient(Cursor.Position));
        }

        private void NitroPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Nitro Reader
            Process NitroReader = new Process();
            NitroReader.StartInfo.FileName = LocalExtensions.pathNitroReader;
            NitroReader.StartInfo.Arguments = (CurrentFile.URL);
            NitroReader.Start();
        }

        private void VLC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file in built-in VLC player
                var a = new VLCPlayer { Text = new Uri(CurrentFile.URL).LocalPath };
                a.axVLCPlugin21.playlist.add(CurrentFile.URL);
                a.axVLCPlugin21.playlist.play();
                a.Show();
            }
            catch { MessageBox.Show("Built-in player was unable to load. We are aware there are some issues with this function and are working to resolve this. For the time being, please install the VLC player on your computer and choose 'Play Media' > 'VLC' "); }
        }

        private void WMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Windows Media Player
            Process.Start("wmplayer.exe", CurrentFile.URL);
        }

        private void VLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in VLC player, with subtitles (if found)
            Process VLC = new Process();
            VLC.StartInfo.FileName = LocalExtensions.pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + CurrentFile.URL + " --sub-file=" + FileSubtitles);
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
            MPC.StartInfo.Arguments = (CurrentFile.URL);
            MPC.Start();
        }

        private void KMPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in KM Player
            Process KMP = new Process();
            KMP.StartInfo.FileName = LocalExtensions.pathKMPlayer;
            KMP.StartInfo.Arguments = (CurrentFile.URL);
            KMP.Start();
        }

        private void PotPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Pot Player
            Process PP = new Process();
            PP.StartInfo.FileName = LocalExtensions.pathPotPlayer;
            PP.StartInfo.Arguments = (CurrentFile.URL);
            PP.Start();
        }

        private void IDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Internet Download Manager
            Process IDM = new Process();
            if (File.Exists(LocalExtensions.pathIDM64))
                IDM.StartInfo.FileName = LocalExtensions.pathIDM64;
            else
                IDM.StartInfo.FileName = LocalExtensions.pathIDM86;
            IDM.StartInfo.Arguments = ("-d " + CurrentFile.URL);
            IDM.Start();
        }

        private void InternetDownloadAccelaratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Internet Download Accelerator
            Process FDM = new Process();
            FDM.StartInfo.FileName = LocalExtensions.pathIDA;
            FDM.StartInfo.Arguments = (CurrentFile.URL);
            FDM.Start();
        }

        private void FDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Free Download Manger
            Process FDM = new Process();
            FDM.StartInfo.FileName = LocalExtensions.pathFDM;
            FDM.StartInfo.Arguments = (CurrentFile.URL);
            FDM.Start();
        }

        private void InfoFileURL_SideImageClicked(object Sender, MouseEventArgs e)
        {
            // Set file URL to clipboard
            Clipboard.SetText(CurrentFile.URL);
            infoFileURL.SideImage = Properties.Resources.clipboard_check_orange;
            infoFileURL.SideImageSize = new Size(24, 24);
        }

        /// <summary>
        /// Go up a row on dataGridFiles and select it
        /// </summary>
        private void SelectUpRow()
        {
            if (ParentDataGrid.Rows.Count > 0)
            {
                int totalRows = ParentDataGrid.Rows.Count;
                int rowIndex = ParentDataGrid.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                int colIndex = ParentDataGrid.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = ParentDataGrid.Rows[rowIndex];
                ParentDataGrid.ClearSelection();
                ParentDataGrid.Rows[rowIndex - 1].Cells[colIndex].Selected = true;

                var URL = ParentDataGrid.CurrentRow.Cells[5].Value.ToString();

                if (ParentDataGrid.CurrentRow.Cells[4].Value.ToString() == "Local")
                    MainForm.Form.ShowFileDetails(new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), new FileInfo(URL).Length, File.GetCreationTime(URL), "Local", URL), ParentDataGrid, IsLocalFile, false);
                else 
                    MainForm.Form.ShowFileDetails(Database.WebFile(URL), ParentDataGrid, IsLocalFile, false);

                ScrollButtonChecks();
            }
        }

        /// <summary>
        /// Go down a row on dataGridFiles and select it
        /// </summary>
        private void SelectDownRow()
        {
            if (ParentDataGrid.Rows.Count > 0)
            {
                int totalRows = ParentDataGrid.Rows.Count;
                int rowIndex = ParentDataGrid.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                int colIndex = ParentDataGrid.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = ParentDataGrid.Rows[rowIndex];
                ParentDataGrid.ClearSelection();
                ParentDataGrid.Rows[rowIndex + 1].Cells[colIndex].Selected = true;

                var URL = ParentDataGrid.CurrentRow.Cells[5].Value.ToString();

                if (ParentDataGrid.CurrentRow.Cells[4].Value.ToString() == "Local")
                    MainForm.Form.ShowFileDetails(new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), new FileInfo(URL).Length, File.GetCreationTime(URL), "Local", URL), ParentDataGrid, IsLocalFile, false);
                else
                    MainForm.Form.ShowFileDetails(Database.WebFile(URL), ParentDataGrid, IsLocalFile, false);

                ScrollButtonChecks();
            }
        }

        // Navigate Files with arrows
        private void ImagePreviousFile_Click(object sender, EventArgs e)
        {
            SelectUpRow();
        }

        private void ImageNextFile_Click(object sender, EventArgs e)
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
                    buttonOpenWith.PerformClick();
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