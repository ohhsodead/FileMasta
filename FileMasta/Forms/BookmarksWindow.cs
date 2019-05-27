using FileMasta.Core;
using FileMasta.Core.Extensions;
using FileMasta.Core.Models;
using FileMasta.Extensions;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileMasta
{
    public partial class BookmarksWindow : Form
    {
        public OdDatabase DataCache { get; set; }

        public BookmarksWindow()
        {
            InitializeComponent();

            ListboxSearchType.SelectedIndex = 0;
            DropdownSearchSort.SelectedIndex = 0;
            DropdownSearchSizePrefix.SelectedIndex = 0;
            DateTimeMaxMTime.Value = DateTime.Now;
        }

        private void BookmarksWindow_Load(object sender, EventArgs e)
        {
            SetStatus("Loading bookmarked files");
            Program.Log.InfoFormat("Loading bookmarked files");
            EnableSearchControls(false);

            ListboxSearchType.SelectedIndex = 0;
            DropdownSearchSort.SelectedIndex = 0;
            DropdownSearchSizePrefix.SelectedIndex = 0;
            DateTimeMaxMTime.Value = DateTime.Now;

            DataGridFiles.Rows.Clear();
            foreach (FileItem file in MainForm.Form.DataCache.Bookmarked)
            {
                _ = DataGridFiles.Rows.Add(file.Name, StringExtensions.BytesToPrefix(file.Size), file.Mtime.ToLocalTime(), file.Url);
            }

            StatusStripDatabaseInfo.Text = string.Format(StatusStripDatabaseInfo.Text, MainForm.Form.DataCache.Bookmarked);
            SetStatus("Loaded bookmarked files");
            EnableSearchControls(true);
        }

        /// <summary>
        /// Search preference: Type
        /// </summary>
        private string[] SearchFileType { get; set; } = FileType.All.ToArray();

        /// <summary>
        /// Search preference: Type
        /// </summary>
        private string SearchSizePrefix { get; set; } = "Bytes";

        /// <summary>
        /// Search preference: Sort
        /// </summary>
        private Sort SearchSortBy { get; set; } = Sort.Name;

        private void TextboxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            PerformSearchAsync();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            PerformSearchAsync();
        }

        private void ListboxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ListboxSearchType.SelectedIndex)
            {
                case 0:
                    SearchFileType = FileType.All;
                    break;
                case 1:
                    SearchFileType = FileType.Audio;
                    break;
                case 2:
                    SearchFileType = FileType.Compressed;
                    break;
                case 3:
                    SearchFileType = FileType.Document;
                    break;
                case 4:
                    SearchFileType = FileType.Executable;
                    break;
                case 5:
                    SearchFileType = FileType.Picture;
                    break;
                case 6:
                    SearchFileType = FileType.Video;
                    break;
            }
        }

        private void DropdownSearchSizePrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchSizePrefix = DropdownSearchSizePrefix.GetItemText(DropdownSearchSizePrefix.SelectedItem);
        }

        private void DropdownSearchSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropdownSearchSort.SelectedIndex)
            {
                case 0:
                    SearchSortBy = Sort.Name;
                    break;
                case 1:
                    SearchSortBy = Sort.Size;
                    break;
                case 2:
                    SearchSortBy = Sort.Date;
                    break;
            }
        }

        private async void PerformSearchAsync()
        {
            SetStatus("Searching...");

            Program.Log.InfoFormat(
                "Searching bookmarks with the following filters: Name: {0}, Sort: {1}, Type: {2}, Size : {3}, Last Modified : {4} to {5}",
                TextboxSearchName.Text,
                SearchSortBy.ToString(),
                SearchFileType.ToArray(),
                NumericSearchGreaterThan.Value,
                DateTimeMinMTime.Value,
                DateTimeMaxMTime.Value);

            EnableSearchControls(false);
            DataGridFiles.Rows.Clear();
            var timer = new Stopwatch();
            timer.Start();

            foreach (FileItem file in
                from DataItem bookmark in
                    await DataCache.SearchBookmarked(
                        TextboxSearchName.Text,
                        SearchFileType,
                        StringExtensions.ParseFileSize($"{NumericSearchGreaterThan.Value} {SearchSizePrefix}"),
                        DateTimeMinMTime.Value,
                        DateTimeMaxMTime.Value)
                let file = FileExtensions.DataItemToFile(bookmark)
                select file)
            {
                _ = DataGridFiles.Rows.Add(file.Name,
                    StringExtensions.BytesToPrefix(file.Size),
                    file.Mtime.ToLocalTime(),
                    file.Url);
            }

            timer.Stop();
            SetStatus($"{StringExtensions.FormatNumber(DataGridFiles.Rows.Count)} Results ({timer.Elapsed.TotalSeconds:0.000} seconds)");
            timer.Reset();
            EnableSearchControls(true);
        }

        private void DataGridFiles_SelectionChanged(object sender, EventArgs e)
        {
            PanelFileDetails.Enabled = DataGridFiles.SelectedRows.Count != 0;

            if (DataGridFiles.CurrentRow == null) return;
            SelectedFile = FileExtensions.CreateFile(DateTime.Parse(DataGridFiles.CurrentRow.Cells[2].Value.ToString()), StringExtensions.ParseFileSize(DataGridFiles.CurrentRow.Cells[1].Value.ToString()), DataGridFiles.CurrentRow.Cells[3].Value.ToString());
            DisplayFileDetails(SelectedFile);
        }

        private void DataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus;
        }

        private void DataGridFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                DisplayFileDetails(SelectedFile);
        }

        private void DataGridFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void ButtonFileRequestSize_Click(object sender, EventArgs e)
        {
            ButtonRequestSize.Visible = false;
            LabelFileValueSize.Text = StringExtensions.BytesToPrefix(SelectedFile.Size);
        }

        private void ButtonFileDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(SelectedFile.Url);
            }
            catch (Exception ex)
            {
                SetStatus("There was an issue downloading the file. " + ex.Message);
            }
        }

        private void ButtonFileOpenWith_Click(object sender, EventArgs e)
        {
            ContextFileOpenWith.Show(ButtonOpenWith, ButtonOpenWith.PointToClient(Cursor.Position));
        }

        private void ButtonFileSave_Click(object sender, EventArgs e)
        {
            if (DataCache.IsBookmarked(SelectedFile))
            {
                DataCache.RemoveBookmark(SelectedFile);
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Bookmark");
            }
            else
            {
                DataCache.AddBookmark(SelectedFile);
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Unbookmark");
            }
        }

        private FileItem SelectedFile { get; set; }

        /// <summary>
        /// Display selected file information in the details pane
        /// </summary>
        /// <param name="file">WebFile object</param>
        private void DisplayFileDetails(FileItem file)
        {
            Program.Log.Info("Selected file " + file.Url);

            SelectedFile = file;
            LabelFileValueName.Text = Path.GetFileNameWithoutExtension(file.Name);
            LabelFileValueSize.Text = StringExtensions.BytesToPrefix(file.Size);
            LabelFileValueDomain.Text = new Uri(file.Url).Host;
            LabelFileValueModified.Text = file.Mtime.ToShortTimeString();
            LabelFileValueAge.Text = DateTimeExtensions.TimeSpanAge(file.Mtime);
            LabelFileValueExtension.Text = file.GetExtension().ToUpper();
            LabelFileValueURL.Text = Uri.UnescapeDataString(file.Url);
            LabelFileUrlBG.Height = LabelFileValueURL.Height + 17;

            foreach (ToolStripMenuItem item in ContextFileOpenWith.Items)
                item.Visible = false;

            if (FileType.Document.Contains(StringExtensions.GetFileExtension(file.Url)))
            {
                NitroReaderToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathNitroReader);
            }

            if (FileType.Video.Contains(StringExtensions.GetFileExtension(file.Url)) || FileType.Audio.Contains(file.GetExtension()))
            {
                WMPToolStripMenuItem.Visible = true;
                VLCToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathVlc);
                MPCToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathMpcCodec64) || File.Exists(LocalExtensions.PathMpc64) || File.Exists(LocalExtensions.PathMpc86);
                KMPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathKmPlayer);
                PotPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathPotPlayer);
            }

            IDMToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathIdm64) || File.Exists(LocalExtensions.PathIdm86);
            IDAToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathIda);
            FDMToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathFdm);

            ControlExtensions.SetControlTextWidth(ButtonBookmark, DataCache.IsBookmarked(file) ? "Unbookmark" : "Bookmark");

            ButtonRequestSize.Visible = file.Size.ToString() == "0";
            ButtonOpenWith.Visible = ContextFileOpenWith.Items.Count > 0;
        }

        private void NitroReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Nitro Reader
            Process NitroReader = new Process();
            NitroReader.StartInfo.FileName = LocalExtensions.PathNitroReader;
            NitroReader.StartInfo.Arguments = (SelectedFile.Url);
            NitroReader.Start();
        }

        private void VLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in VLC player, with subtitles (if found)
            using (Process VLC = new Process())
            {
                VLC.StartInfo.FileName = LocalExtensions.PathVlc;
                VLC.StartInfo.Arguments = ("-vvv " + SelectedFile.Url);
                VLC.Start();
            }
        }

        private void WMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Windows Media Player
            Process.Start("wmplayer.exe", SelectedFile.Url);
        }

        private void MPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Media Player Classic
            using (Process MPC = new Process())
            {
                if (File.Exists(LocalExtensions.PathMpcCodec64))
                    MPC.StartInfo.FileName = LocalExtensions.PathMpcCodec64;
                else if (File.Exists(LocalExtensions.PathMpc64))
                    MPC.StartInfo.FileName = LocalExtensions.PathMpc64;
                else
                    MPC.StartInfo.FileName = LocalExtensions.PathMpc86;
                MPC.StartInfo.Arguments = (SelectedFile.Url);
                MPC.Start();
            }
        }

        private void KMPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in KM Player
            using (Process KMP = new Process())
            {
                KMP.StartInfo.FileName = LocalExtensions.PathKmPlayer;
                KMP.StartInfo.Arguments = (SelectedFile.Url);
                KMP.Start();
            }
        }

        private void PotPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Pot Player
            using (Process PP = new Process())
            {
                PP.StartInfo.FileName = LocalExtensions.PathPotPlayer;
                PP.StartInfo.Arguments = (SelectedFile.Url);
                PP.Start();
            }
        }

        private void IDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Internet Download Manager
            using (Process IDM = new Process())
            {
                if (File.Exists(LocalExtensions.PathIdm64))
                    IDM.StartInfo.FileName = LocalExtensions.PathIdm64;
                else
                    IDM.StartInfo.FileName = LocalExtensions.PathIdm86;
                IDM.StartInfo.Arguments = ("-d " + SelectedFile.Url);
                IDM.Start();
            }
        }

        private void IDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Internet Download Accelerator
            using (Process FDM = new Process())
            {
                FDM.StartInfo.FileName = LocalExtensions.PathIda;
                FDM.StartInfo.Arguments = (SelectedFile.Url);
                FDM.Start();
            }
        }

        private void FDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file in Free Download Manger
            using (Process FDM = new Process())
            {
                FDM.StartInfo.FileName = LocalExtensions.PathFdm;
                FDM.StartInfo.Arguments = (SelectedFile.Url);
                FDM.Start();
            }
        }

        /// <summary>
        /// Enable/Disable search controls, to prevent another search process which causes a crash
        /// </summary>
        /// <param name="isEnabled">Enable/Disable Controls</param>
        private void EnableSearchControls(bool isEnabled)
        {
            TextboxSearchName.Enabled = isEnabled;
            ListboxSearchType.Enabled = isEnabled;
            ButtonSearch.Enabled = isEnabled;
            NumericSearchGreaterThan.Enabled = isEnabled;
            DropdownSearchSizePrefix.Enabled = isEnabled;
            DateTimeMinMTime.Enabled = isEnabled;
            DateTimeMaxMTime.Enabled = isEnabled;
            DropdownSearchSort.Enabled = isEnabled;
        }

        /// <summary>
        /// Set the current status of the application
        /// </summary>
        /// <param name="message">Message/status to be displayed</param>
        private void SetStatus(string message)
        {
            StatusStripStatus.Text = message;
        }

        /*************************************************************************/
        /* Keyboard Shortcuts                                                    */
        /*************************************************************************/

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // Focus on Search Box
                case Keys.Control | Keys.F:
                    TextboxSearchName.Focus();
                    return true;
                // Close application
                case Keys.Control | Keys.W:
                    Application.Exit();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MenuFileViewDetails_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
                DisplayFileDetails(SelectedFile);
        }

        private void MenuFileBookmark_Click(object sender, EventArgs e)
        {
            if (DataCache.IsBookmarked(SelectedFile))
            {
                DataCache.RemoveBookmark(SelectedFile);
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Bookmark");
            }
            else
            {
                DataCache.AddBookmark(SelectedFile);
                ControlExtensions.SetControlTextWidth(ButtonBookmark, "Unbookmark");
            }
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
                Process.Start(SelectedFile.Url);
        }

        private void MenuFileCopyURL_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count <= 0) return;
            Clipboard.SetText(SelectedFile.Url);
            SetStatus("Copied File URL to Clipboard");
        }

        private void MenuFileEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:" +
                $"?body=File Report ({ListboxSearchType.SelectedItem})" +
                $"&subject=" +
                $"Name: {StringExtensions.GetFileName(SelectedFile.Url)} ({ListboxSearchType.SelectedItem})\n\n" +
                $"Direct URL: {SelectedFile}\n\n\n\n" +
                "Auto-generated by FileMasta: " + Configuration.ProjectUrl);
        }
    }
}