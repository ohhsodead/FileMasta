using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.Models;
using FileMasta.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class FileDetailsWindow : Form
    {
        public FileDetailsWindow()
        {
            InitializeComponent();
        }

        public FtpFile CurrentFile { get; set; }
        public string FileExtension { get; set; }
        public DataGridView ParentDataGrid { get; set; }

        /// <summary>
        /// Supported file types for all the external applications
        /// </summary>
        public static List<string> VideoFileTypes { get; } = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> AudioFileTypes { get; } = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };
        public static List<string> ImageFileTypes { get; } = new List<string>() { "TIFF", "TIF", "JPEG", "JPG", "BMP", "GIF", "PNG", "EPS", "RAW", "SVG" };
        public static List<string> BookFileTypes { get; } = new List<string>() { "MOBI", "CBZ", "CBR", "CBC", "CHM", "EPUB", "FB2", "LIT", "LRF", "ODT", "PDF", "PRC", "PDB", "PML", "RB", "RTF", "TCR", "DOC", "DOCX" };
        
        private void FileDetailsWindow_Load(object sender, EventArgs e)
        {
            CheckFileEvents();
        }

        public void CheckFileEvents()
        {
            // Hides all open file items
            foreach (ToolStripMenuItem item in ContextOpenFile.Items)
                item.Visible = false;

            // Shows Add/Remove Bookmarks button text
            if (MainForm.LocalData.IsBookmarked(CurrentFile))
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Remove from Bookmarks");
            else
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Add to Bookmarks");

            // Shows supported PDF readers installed on users machine
            if (BookFileTypes.Contains(FileExtension))
            {
                NitroReaderToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathNitroReader);
            }

            // Shows supported media players installed on users machine
            if (VideoFileTypes.Contains(FileExtension) || AudioFileTypes.Contains(FileExtension))
            {
                WMPToolStripMenuItem.Visible = true;
                VLCToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathVLC);
                MPCToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathMPCCodec64) || File.Exists(LocalExtensions._pathMPC64) || File.Exists(LocalExtensions._pathMPC86);
                KMPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathKMPlayer);
                PotPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathPotPlayer);
            }

            // Support download manangers installed on users machine
            IDMToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathIDM64) || File.Exists(LocalExtensions._pathIDM86);
            IDAToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathIDA);
            FDMToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathFDM);

            // Shows Open File button if context menu has items
            ButtonOpenWith.Visible = ContextOpenFile.Items.Count > 0;

            // Shows Request File Size button if size property returns 0
            ButtonRequestSize.Visible = CurrentFile.Size == 0;

            // Displays appropriate scrolling images
            ScrollButtonChecks();
        }

        private void ScrollButtonChecks()
        {
            if (ParentDataGrid.Rows.Count > 0)
            {
                if (ParentDataGrid.SelectedCells[0].OwningRow.Index == 0)
                    ImagePreviousFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_up, Color.DimGray);
                else
                    ImagePreviousFile.Image = Properties.Resources.chevron_up;

                if (ParentDataGrid.SelectedCells[0].OwningRow.Index == ParentDataGrid.Rows.Count - 1)
                    ImageNextFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_down, Color.DimGray);
                else
                    ImageNextFile.Image = Properties.Resources.chevron_down;
            }
            else
            {
                ImagePreviousFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_up, Color.DimGray);
                ImageNextFile.Image = ImageExtensions.ChangeColor(Properties.Resources.chevron_down, Color.DimGray);
            }
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
                ParentDataGrid.Rows[rowIndex - 1].Selected = true;

                MainForm.Form.DisplayFileDetails(MainForm.LocalData.GetFile(ParentDataGrid.CurrentRow.Cells[4].Value.ToString()));

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
                ParentDataGrid.Rows[rowIndex + 1].Selected = true;

                MainForm.Form.DisplayFileDetails(MainForm.LocalData.GetFile(ParentDataGrid.CurrentRow.Cells[4].Value.ToString()));

                ScrollButtonChecks();
            }
        }

        private void ImagePreviousFile_Click(object sender, EventArgs e)
        {
            SelectUpRow();
        }

        private void ImageNextFile_Click(object sender, EventArgs e)
        {
            SelectDownRow();
        }

        private void ButtonBookmark_Click(object sender, EventArgs e)
        {
            // Add/Remove file from users Bookmarks
            if (MainForm.LocalData.IsBookmarked(CurrentFile))
            {
                MainForm.LocalData.RemoveFile(CurrentFile);
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Add to Bookmarks");
            }
            else
            {
                MainForm.LocalData.AddFile(CurrentFile);
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Remove from Bookmarks");
            }
        }

        private void ButtonViewDirectory_Click(object sender, EventArgs e)
        {
            // Open parent directory of file in default web browser
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = StringExtensions.ParentDirectory(new Uri(CurrentFile.URL)).Remove(StringExtensions.ParentDirectory(new Uri(CurrentFile.URL)).Length - 1); ;
            browser.Start();
        }

        private void ButtonRequestSize_Click(object sender, EventArgs e)
        {
            // Request file size from URL
            ButtonRequestSize.Visible = false;
            BackGroundWorker.RunWorkAsync<string>(() => StringExtensions.BytesToPrefix(WebExtensions.FtpFileSize(CurrentFile.URL)), (data) => { LabelValueSize.Text = data; });
        }
        
        private void ButtonShare_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            ComboBoxShare.DroppedDown = true;
        }

        private void ComboBoxShare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxShare.SelectedIndex == 0)
                Process.Start("https://www.facebook.com/sharer/sharer.php?u=" + CurrentFile.URL);
            else if (ComboBoxShare.SelectedIndex == 1)
                Process.Start("https://twitter.com/home?status=Check%20out%20this%20file%20I%20found%20on%20%40FileMasta%20" + CurrentFile.URL);
            else if (ComboBoxShare.SelectedIndex == 2)
                Process.Start("https://plus.google.com/share?url=" + CurrentFile.URL);
            else if (ComboBoxShare.SelectedIndex == 3)
                Process.Start("http://reddit.com/submit?url=" + CurrentFile.URL + "&title=" + CurrentFile.Name + "%20%5BFileMasta%5D");
            else if (ComboBoxShare.SelectedIndex == 4)
                Process.Start("mailto:?&body=Check%20out%20this%20awesome%20file%20I%20found%20on%20FileMasta%20-%20" + CurrentFile.URL);
        }

        private void ButtonDirectLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try
            {
                // Open file in default web browser, or if local then default program
                // Crashes when no application set for the extension, so I used Try statement to catch and show these errors
                Process.Start(CurrentFile.URL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open file\n\n" + ex.Message);
            }
        }

        private void ButtonOpenWith_Click(object sender, EventArgs e)
        {
            ContextOpenFile.Show(ButtonOpenWith, ButtonOpenWith.PointToClient(Cursor.Position));
        }

        private void NitroPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Nitro Reader
            Process NitroReader = new Process();
            NitroReader.StartInfo.FileName = LocalExtensions._pathNitroReader;
            NitroReader.StartInfo.Arguments = (CurrentFile.URL);
            NitroReader.Start();
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
            VLC.StartInfo.FileName = LocalExtensions._pathVLC;
            VLC.StartInfo.Arguments = ("-vvv " + CurrentFile.URL);
            VLC.Start();
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Media Player Classic
            Process MPC = new Process();
            if (File.Exists(LocalExtensions._pathMPCCodec64))
                MPC.StartInfo.FileName = LocalExtensions._pathMPCCodec64;
            else if (File.Exists(LocalExtensions._pathMPC64))
                MPC.StartInfo.FileName = LocalExtensions._pathMPC64;
            else
                MPC.StartInfo.FileName = LocalExtensions._pathMPC86;
            MPC.StartInfo.Arguments = (CurrentFile.URL);
            MPC.Start();
        }

        private void KMPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in KM Player
            Process KMP = new Process();
            KMP.StartInfo.FileName = LocalExtensions._pathKMPlayer;
            KMP.StartInfo.Arguments = (CurrentFile.URL);
            KMP.Start();
        }

        private void PotPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Pot Player
            Process PP = new Process();
            PP.StartInfo.FileName = LocalExtensions._pathPotPlayer;
            PP.StartInfo.Arguments = (CurrentFile.URL);
            PP.Start();
        }

        private void IDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Internet Download Manager
            Process IDM = new Process();
            if (File.Exists(LocalExtensions._pathIDM64))
                IDM.StartInfo.FileName = LocalExtensions._pathIDM64;
            else
                IDM.StartInfo.FileName = LocalExtensions._pathIDM86;
            IDM.StartInfo.Arguments = ("-d " + CurrentFile.URL);
            IDM.Start();
        }

        private void InternetDownloadAccelaratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Internet Download Accelerator
            Process FDM = new Process();
            FDM.StartInfo.FileName = LocalExtensions._pathIDA;
            FDM.StartInfo.Arguments = (CurrentFile.URL);
            FDM.Start();
        }

        private void FDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Free Download Manger
            Process FDM = new Process();
            FDM.StartInfo.FileName = LocalExtensions._pathFDM;
            FDM.StartInfo.Arguments = (CurrentFile.URL);
            FDM.Start();
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
                    ButtonBookmark.PerformClick();
                    return true;
                // Clicks View Directory button
                case Keys.Control | Keys.V:
                    ButtonViewDirectory.PerformClick();
                    return true;
                // Clicks Direct Link button
                case Keys.Control | Keys.D:
                    ButtonDirectLink.PerformClick();
                    return true;
                // Click Share File button
                case Keys.Control | Keys.S:
                    ButtonShare.PerformClick();
                    return true;
                // Click Request File Size button
                case Keys.Control | Keys.R:
                    ButtonRequestSize.PerformClick();
                    return true;
                // Click Open File button
                case Keys.Control | Keys.O:
                    ButtonOpenWith.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}