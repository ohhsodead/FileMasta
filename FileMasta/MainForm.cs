using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FileMasta.Controls;
using FileMasta.Data;
using FileMasta.Extensions;
using FileMasta.Forms;
using FileMasta.Models;
using FileMasta.Utils;

namespace FileMasta
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Application splash screen
        /// </summary>
        private static readonly SplashScreen FormSplashScreen = new SplashScreen();
        
        /// <summary>
        /// Applcation database instannce
        /// </summary>
        private DataCache _dataCache;

        public MainForm()
        {
            Program.Log.Info("Initializing");
            InitializeComponent();
            var form = this;
            
            Controls.Add(FormSplashScreen);
            FormSplashScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            FormSplashScreen.Location = new Point(0, 0);
            FormSplashScreen.Size = form.ClientSize;
            FormSplashScreen.BringToFront();
            FormSplashScreen.Show();

            ListboxSearchType.SelectedIndex = 0;
            DropdownSearchSort.SelectedIndex = 0;
            DropdownSearchSizePrefix.SelectedIndex = 0;
            DatetimeSearchLastModifiedMax.Value = DateTime.Now;

            Program.Log.Info("Initialized");
        }

        /*************************************************************************/
        /* Form / Startup Events                                                 */
        /*************************************************************************/

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.Log.Info("Load events started");
            Utils.Update.CheckUpdate();
            WorkerExtensions.RunWorkAsync(() => _dataCache = new DataCache(), InitializeFinished);
        }

        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var keyword in DataHelper.GetSearchKeywords())
                FlowpanelKeywords.Controls.Add(ControlExtensions.KeywordLabel(keyword, LabelKeyword_Click));

            StatusStripDatabaseInfo.Text = string.Format(StatusStripDatabaseInfo.Text,
                StringExtensions.FormatNumber(_dataCache.GetTotalNoFiles()),
                StringExtensions.BytesToPrefix(_dataCache.GetTotalFilesSize()));

            Controls.Remove(FormSplashScreen);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dataCache?.CreateSavedFile();
            Program.Log.Info("Updated saved file");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Log.Info("Exited");
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }
        
        protected override void OnPaint(PaintEventArgs e) { }        

        /*************************************************************************/
        /* Menu Strip                                                            */
        /*************************************************************************/

        // File
        private void MenuFileMinimizeToTray_Click(object sender, EventArgs e)
        {
            Hide();
            NotifyTrayIcon.Visible = true;
            NotifyTrayIcon.ShowBalloonTip(1000);
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            NotifyTrayIcon.Visible = false;
        }

        // Saved
        private void MenuStripBookmarkedShowHide_Click(object sender, EventArgs e)
        {
            if (MenuStripBookmarkedShowHide.Checked)
                ShowSaved();
            else
                DataGridFiles.Rows.Clear();
        }

        private void MenuStripSavedClear_Click(object sender, EventArgs e)
        {
            _dataCache.WipeSaved();
        }

        // Tools
        private void MenuToolsOptions_Click(object sender, EventArgs e)
        {
            var optionsWindow = new OptionsDialog();
            optionsWindow.ShowDialog(this);
        }

        // Help
        private void MenuHelpChangelog_Click(object sender, EventArgs e)
        {
            ControlExtensions.ShowDataWindow(this, "Change Log", AppExtensions.ChangelogUrl);
        }
        
        private void MenuHelpReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start($"{AppExtensions.ProjectUrl}issues/new");
        }

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
            var aboutWindow = new AboutDialog();
            aboutWindow.ShowDialog(this);
        }

        private void MenuHelpCheckForUpdate_Click(object sender, EventArgs e)
        {
            Utils.Update.CheckUpdate();
        }
        
        /*************************************************************************/
        /* Searching Files                                                       */
        /*************************************************************************/

        /// <summary>
        /// Search preference: Type
        /// </summary>
        private string[] SearchFileType { get; set; } = Types.All.ToArray();

        /// <summary>
        /// Search preference: Type
        /// </summary>
        private string SearchSizePrefix { get; set; } = "Bytes";

        /// <summary>
        /// Search preference: Sort
        /// </summary>
        private DataCache.Sort SearchSortBy { get; set; } = DataCache.Sort.Name;

        private void TextBoxSearchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (TextboxSearchName.Text.Length > 2)
                BeginSearch();
            else
                SetStatus("Minimum 3 characters");
        }

        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            if (TextboxSearchName.Text.Length > 2)
                BeginSearch();
            else
                SetStatus("Minimum 3 characters");
        }

        private void ButtonSearchEngine_Click(object sender, EventArgs e)
        {
            ContextMenuSearchExternal.Show(ButtonSearchExternal, ButtonSearchExternal.PointToClient(Cursor.Position));
        }
        
        // External Searches
        private void MenuSearchGoogle_Click(object sender, EventArgs e)
        {
            Process.Start(
                $"{Engines.Google}{TextboxSearchName.Text} %2B({string.Join("|", SearchFileType.ToArray()).ToLower()}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)");
        }

        private void MenuSearchGoogol_Click(object sender, EventArgs e)
        {
            Process.Start(
                $"{Engines.Googol}{TextboxSearchName.Text} %2B({string.Join("|", SearchFileType.ToArray()).ToLower()}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)");
        }

        private void MenuSearchStartPage_Click(object sender, EventArgs e)
        {
            Process.Start(
                $"{Engines.StartPage}{TextboxSearchName.Text} %2B({string.Join("|", SearchFileType.ToArray()).ToLower()}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)");
        }

        private void MenuSearchSearx_Click(object sender, EventArgs e)
        {
            Process.Start(
                $"{Engines.Searx}{TextboxSearchName.Text} %2B({string.Join("|", SearchFileType.ToArray()).ToLower()}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)");
        }        

        private void ListboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ListboxSearchType.SelectedIndex)
            {
                case 0:
                    SearchFileType = Types.All;
                    break;
                case 1:
                    SearchFileType = Types.Audio;
                    break;
                case 2:
                    SearchFileType = Types.Compressed;
                    break;
                case 3:
                    SearchFileType = Types.Document;
                    break;
                case 4:
                    SearchFileType = Types.Executable;
                    break;
                case 5:
                    SearchFileType = Types.Picture;
                    break;
                case 6:
                    SearchFileType = Types.Video;
                    break;
            }
        }

        private void DropdownSearchSizePrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchSizePrefix = DropdownSearchSizePrefix.GetItemText(DropdownSearchSizePrefix.SelectedItem);
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropdownSearchSort.SelectedIndex)
            {
                case 0:
                    SearchSortBy = DataCache.Sort.Name;
                    break;
                case 1:
                    SearchSortBy = DataCache.Sort.Size;
                    break;
                case 2:
                    SearchSortBy = DataCache.Sort.Date;
                    break;
            }
        }

        private void LabelKeyword_Click(object sender, EventArgs e)
        {
            TextboxSearchName.Text = ((Label)sender).Text;
            BeginSearch();
        }

        private delegate void BeginSearchCallBack();
        private void BeginSearch()
        {
            SetStatus("Searching...");
            Program.Log.InfoFormat("Searching. Filters: Name: {0}, Sort: {1}, Type: {2}, Size : {3}, Last Modified : {4} to {5}", TextboxSearchName.Text, SearchSortBy.ToString(), SearchFileType.ToArray(), NumericSearchGreaterThan.Value, DatetimeSearchLastModifiedMin.Value, DatetimeSearchLastModifiedMax.Value);
            EnableSearchControls(false);
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            WorkerExtensions.RunWorkAsync(() => _dataCache.Search(SearchSortBy, TextboxSearchName.Text, SearchFileType, StringExtensions.ParseFileSize(NumericSearchGreaterThan.Value + " " + SearchSizePrefix), DatetimeSearchLastModifiedMin.Value, DatetimeSearchLastModifiedMax.Value), (data) =>
            {
                if (InvokeRequired)
                    Invoke(new BeginSearchCallBack(BeginSearch), new object[] { });
                else
                {
                    DataGridFiles.Rows.Clear();
                    foreach (var file in data)
                        DataGridFiles.Rows.Add(file.Name, StringExtensions.BytesToPrefix(file.Size), file.LastModified.ToLocalTime(), file.Url);
                    stopWatch.Stop();
                    SetStatus($"{StringExtensions.FormatNumber(DataGridFiles.Rows.Count)} Results ({stopWatch.Elapsed.TotalSeconds:0.000} seconds)");
                    stopWatch.Reset();
                    EnableSearchControls(true);
                }
            });
        }

        private delegate void ShowSavedCallBack();
        private void ShowSaved()
        {
            SetStatus("Showing saved files...");
            Program.Log.InfoFormat("Showing users saved files");
            EnableSearchControls(false);
            WorkerExtensions.RunWorkAsync(() => _dataCache.SavedFiles(), (data) =>
            {
                if (InvokeRequired)
                    Invoke(new ShowSavedCallBack(ShowSaved), new object[] { });
                else
                {
                    DataGridFiles.Rows.Clear();
                    foreach (var file in data)
                        DataGridFiles.Rows.Add(file.Name, StringExtensions.BytesToPrefix(file.Size), file.LastModified.ToLocalTime(), file.Url);
                    SetStatus("Saved files loaded");
                    EnableSearchControls(true);
                }
            });
        }

        private void DataGridFileItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                DisplayFileDetails(SelectedGridFile);
        }

        private void DataGridFileItems_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void DataGridFileItems_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus;
        }
        
        private void DataGridFileItems_SelectionChanged(object sender, EventArgs e)
        {
            PanelFileDetails.Enabled = DataGridFiles.SelectedRows.Count != 0;

            if (DataGridFiles.CurrentRow == null) return;
            SelectedGridFile = _dataCache.GetFile(DataGridFiles.CurrentRow.Cells[3].Value.ToString());
            DisplayFileDetails(SelectedGridFile);
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
                Process.Start(SelectedGridFile.Url);
        }

        private void MenuFileViewDetails_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
                DisplayFileDetails(SelectedGridFile);
        }

        private void MenuFileCopyURL_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count <= 0) return;
            Clipboard.SetText(SelectedGridFile.Url);
            SetStatus("Copied File URL to Clipboard");
        }

        private void MenuFileEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:" +
                $"?body={SelectedGridFile.Name} ({ListboxSearchType.SelectedItem})" +
                $"&subject={SelectedGridFile.Name} ({ListboxSearchType.SelectedItem})\n\n" +
                $"Size: {SelectedGridFile.Size}\n\n" +
                $"Last Modified: {SelectedGridFile.LastModified}\n\n" +
                $"Download: {SelectedGridFile.Url}\n\n\n\n" +
                "Auto-generated by FileMasta: https://github.com/mostlyash/filemasta");
        }

        private WebFile SelectedGridFile { get; set; }

        /// <summary>
        /// Display selected file information in the details pane
        /// </summary>
        /// <param name="file">WebFile object</param>
        private void DisplayFileDetails(WebFile file)
        {
            Program.Log.Info("Selected file properties " + file.Url);
            SelectedGridFile = file;
            LabelFileValueName.Text = file.Name;
            LabelFileValueSize.Text = StringExtensions.BytesToPrefix(file.Size);
            LabelFileValueDomain.Text = new Uri(file.Url).Host;
            LabelFileValueModified.Text = file.LastModified.ToString("dd MMMM yyyy");
            LabelFileValueAge.Text = StringExtensions.TimeSpanAge(file.LastModified);
            LabelFileValueExtension.Text = file.GetExtension();
            LabelFileValueURL.Text =  Uri.UnescapeDataString(file.Url);
            LabelFileUrlBG.Height = LabelFileValueURL.Height + 17;

            foreach (ToolStripMenuItem item in ContextFileOpenWith.Items)
                item.Visible = false;

            if (Types.Document.Contains(file.GetExtension()))
            {
                NitroReaderToolStripMenuItem.Visible = File.Exists(LocalExtensions.PathNitroReader);
            }

            if (Types.Video.Contains(file.GetExtension()) || Types.Audio.Contains(file.GetExtension()))
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

            ControlExtensions.SetControlTextWidth(ButtonFileSave, _dataCache.IsFileSaved(file.Url) ? "Unsave" : "Save");

            ButtonFileRequestSize.Visible = file.Size == 0;
            ButtonFileOpenWith.Visible = ContextFileOpenWith.Items.Count > 0;
        }

        private void ButtonFileRequestSize_Click(object sender, EventArgs e)
        {
            ButtonFileRequestSize.Visible = false;
            WorkerExtensions.RunWorkAsync(() => StringExtensions.BytesToPrefix(FtpExtensions.GetFileSize(SelectedGridFile.Url)), (data) => { LabelFileValueSize.Text = data; });
        }

        private void MenuFileSaved_Click(object sender, EventArgs e)
        {
            if (_dataCache.IsFileSaved(SelectedGridFile.Url))
            {
                _dataCache.UnsaveFile(SelectedGridFile.Url);
                ControlExtensions.SetControlTextWidth(ButtonFileSave, "Save");
            }
            else
            {
                _dataCache.SaveFile(SelectedGridFile.Url);
                ControlExtensions.SetControlTextWidth(ButtonFileSave, "Unsave");
            }
        }

        private void ButtonFileDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(SelectedGridFile.Url);
            }
            catch (Exception ex)
            {
                SetStatus("There was an issue downloading the file. " + ex.Message);
            }
        }

        private void ButtonFileOpenWith_Click(object sender, EventArgs e)
        {
            ContextFileOpenWith.Show(ButtonFileOpenWith, ButtonFileOpenWith.PointToClient(Cursor.Position));
        }

        private void ButtonFileSave_Click(object sender, EventArgs e)
        {
            if (_dataCache.IsFileSaved(SelectedGridFile.Url))
            {
                _dataCache.UnsaveFile(SelectedGridFile.Url);
                ControlExtensions.SetControlTextWidth(ButtonFileSave, "Save");
            }
            else
            {
                _dataCache.SaveFile(SelectedGridFile.Url);
                ControlExtensions.SetControlTextWidth(ButtonFileSave, "Unsave");
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
            ButtonSearchExternal.Enabled = isEnabled;
            NumericSearchGreaterThan.Enabled = isEnabled;
            DropdownSearchSizePrefix.Enabled = isEnabled;
            DatetimeSearchLastModifiedMin.Enabled = isEnabled;
            DatetimeSearchLastModifiedMax.Enabled = isEnabled;
            DropdownSearchSort.Enabled = isEnabled;
            foreach (var searchItem in FlowpanelKeywords.Controls)
                if (searchItem is Label label)
                    label.Enabled = isEnabled;
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
    }
}