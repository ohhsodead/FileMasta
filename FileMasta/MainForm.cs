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
using FileMasta.Utilities;

namespace FileMasta
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Store the instance of the this application
        /// </summary>
        public static MainForm Form { get; set; } = null;

        /// <summary>
        /// Store the current instance of the database
        /// </summary>
        public static OpenFiles LocalData { get; set; } = null;

        /// <summary>
        /// Create an instance of the splash screen
        /// </summary>
        public static SplashScreen FormSplashScreen { get; } = new SplashScreen();

        /// <summary>
        /// Proxy Connection Settings
        /// </summary>
        public static bool UseWebProxyCustom { get; set; } = Properties.Settings.Default.proxyUseCustom;

        public MainForm()
        {
            Program.Log.Info("Initializing");
            InitializeComponent();
            Form = this;
            
            // Show splash window inside form
            Controls.Add(FormSplashScreen);
            FormSplashScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            FormSplashScreen.Location = new Point(0, 0);
            FormSplashScreen.Size = Form.ClientSize;
            FormSplashScreen.BringToFront();
            FormSplashScreen.Show();

            // Set default search control properties
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
            Program.Log.Info("Load events starting");
            Utilities.Update.CheckUpdate();
            WorkerExt.RunWorkAsync(() => { LocalData = new OpenFiles(); }, InitializeFinished);
        }

        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            int noKeywords = 0;
            foreach (var keyword in LocalData.GetKeywords())
                if (noKeywords <= 100)
                    FlowpanelKeywords.Controls.Add(ControlExt.LabelKeyword(keyword, noKeywords)); noKeywords++;
            SetMetadata();
            Controls.Remove(FormSplashScreen);
            Program.Log.Info("Startup events completed");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LocalData.SaveBookmarked();
            Program.Log.Info("Bookmarked file saved");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.ApplicationExitCall)
                if (Properties.Settings.Default.clearDataOnClose)
                    if (Directory.Exists(LocalExt.PathData))
                        Directory.Delete(LocalExt.PathData, true);
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

        // Bookmarks
        private void MenuStripBookmarksClear_Click(object sender, EventArgs e)
        {
            LocalData.ClearBookmarked();
        }

        // Tools
        private void MenuToolsFtpServerList_Click(object sender, EventArgs e)
        {
            Process.Start(GitHub.URL_SERVERS);
        }

        private void MenuToolsSubmitFtpServer_Click(object sender, EventArgs e)
        {
            var submitWindow = new SubmitDialog();
            submitWindow.ShowDialog(this);
        }

        private void MenuToolsOptions_Click(object sender, EventArgs e)
        {
            var optionsWindow = new OptionsDialog();
            optionsWindow.ShowDialog(this);
        }

        // Help
        private void MenuHelpFAQ_Click(object sender, EventArgs e)
        {
            //ControlExtensions.ShowDataWindow("Frequently Asked Questions", GitHub.URL_FAQ);
        }

        private void MenuHelpTermsOfUse_Click(object sender, EventArgs e)
        {
            Process.Start(GitHub.URL_TERMSOFUSE);
        }

        private void MenuHelpChangelog_Click(object sender, EventArgs e)
        {
            ControlExt.ShowDataWindow("Change Log", GitHub.URL_CHANGELOG);
        }
        
        private void MenuHelpReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start($"{GitHub.URL_PROJECT}issues/new");
        }

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
            var aboutWindow = new AboutDialog();
            aboutWindow.ShowDialog(this);
        }

        private void MenuHelpCheckForUpdate_Click(object sender, EventArgs e)
        {
            Utilities.Update.CheckUpdate();
        }

        /// <summary>
        /// Set database meta data to the toolstrip
        /// </summary>
        public void SetMetadata()
        {
            StatusStripDatabaseInfo.Text = string.Format(StatusStripDatabaseInfo.Text,
                StringExt.FormatNumber(LocalData.TotalFiles().ToString()),
                StringExt.BytesToPrefix(LocalData.TotalFileSize()),
                LocalData.MetaData.Updated.ToShortDateString());
        }
        
        /*************************************************************************/
        /* Search Files                                                          */
        /*************************************************************************/

        /// <summary>
        /// Search preference: Type
        /// </summary>
        public string[] SearchFileType { get; set; } = FileType.All.ToArray();

        /// <summary>
        /// Search preference: Type
        /// </summary>
        public string SearchSizePrefix { get; set; } = "Bytes";

        /// <summary>
        /// Search preference: Sort
        /// </summary>
        public OpenFiles.SortBy SearchSortBy { get; set; } = OpenFiles.SortBy.Name;

        private void TextBoxSearchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (TextboxSearchName.Text.Length > 2)
                    GoSearch();
                else
                    SetStatus("Minimum 3 characters");
        }

        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            if (TextboxSearchName.Text.Length > 2)
                GoSearch();
            else
                SetStatus("Minimum 3 characters");
        }

        private void ButtonSearchEngine_Click(object sender, EventArgs e)
        {
            ContextMenuSearchExternal.Show(ButtonSearchExternal, PointToScreen(ButtonSearchExternal.Location));
        }
        
        // External Searches
        private void MenuSearchGoogle_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalEngine.URL_GOOGLE, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }

        private void MenuSearchGoogol_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalEngine.URL_GOOGOL, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }

        private void MenuSearchStartPage_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalEngine.URL_STARTPAGE, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }

        private void MenuSearchSearx_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalEngine.URL_SEARX, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }        

        private void ListboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListboxSearchType.SelectedIndex == -1)
                SearchFileType = FileType.All;
            else if (ListboxSearchType.SelectedIndex == 0)
                SearchFileType = FileType.All;
            else if (ListboxSearchType.SelectedIndex == 1)
                SearchFileType = FileType.Audio;
            else if (ListboxSearchType.SelectedIndex == 2)
                SearchFileType = FileType.Compressed;
            else if (ListboxSearchType.SelectedIndex == 3)
                SearchFileType = FileType.Document;
            else if (ListboxSearchType.SelectedIndex == 4)
                SearchFileType = FileType.Executable;
            else if (ListboxSearchType.SelectedIndex == 5)
                SearchFileType = FileType.Picture;
            else if (ListboxSearchType.SelectedIndex == 6)
                SearchFileType = FileType.Video;
        }

        private void DropdownSearchSizePrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchSizePrefix = DropdownSearchSizePrefix.GetItemText(DropdownSearchSizePrefix.SelectedItem);
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownSearchSort.SelectedIndex == 0)
                SearchSortBy = OpenFiles.SortBy.Name;
            else if (DropdownSearchSort.SelectedIndex == 1)
                SearchSortBy = OpenFiles.SortBy.Size;
            else if (DropdownSearchSort.SelectedIndex == 2)
                SearchSortBy = OpenFiles.SortBy.Date;
        }

        /// <summary>
        /// Begin to search files 
        /// </summary>
        public void GoSearch()
        {
            if (Uri.TryCreate(TextboxSearchName.Text, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeFtp) && uriResult != null)
                try
                {
                    DisplayFileDetails(SelectedGridFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue requesting file information. Make sure the server / files allows for anonymous authentication access, otherwise make sure sure there's no typo.\n\n" + ex.Message);
                }
            else
                 SearchFiles();
        }

        delegate void SearchFilesCallBack();
        public void SearchFiles()
        {
            SetStatus("Searching...");
            Program.Log.InfoFormat("Searching. Filters: Name: {0}, Sort: {1}, Type: {2}, Size : {3}, Last Modified : {4} to {5}", TextboxSearchName.Text, SearchSortBy.ToString(), SearchFileType.ToArray(), NumericSearchGreaterThan.Value, DatetimeSearchLastModifiedMin.Value, DatetimeSearchLastModifiedMax.Value);
            EnableSearchControls(false);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            WorkerExt.RunWorkAsync(() => LocalData.Search(MenuStripBookmarkedShowHide.Checked, SearchSortBy, TextboxSearchName.Text, SearchFileType, StringExt.ParseFileSize(string.Format("{0} {1}", (long)NumericSearchGreaterThan.Value, SearchSizePrefix)), DatetimeSearchLastModifiedMin.Value, DatetimeSearchLastModifiedMax.Value), (files) =>
            {
                if (InvokeRequired)
                    Invoke(new SearchFilesCallBack(SearchFiles), new object[] { });
                else
                {
                    DatagridFileItems.Rows.Clear();

                    foreach (var file in files)
                    {
                        DatagridFileItems.Rows.Add(file.Name + "." + file.GetExtension().ToLower(), StringExt.BytesToPrefix(file.Size), file.DateModified, new Uri(file.URL).Host, file.URL);
                    }

                    stopWatch.Stop();
                    SetStatus(string.Format("{0} Results ({1} seconds)", StringExt.FormatNumber(DatagridFileItems.Rows.Count.ToString()), string.Format("{0:0.000}", stopWatch.Elapsed.TotalSeconds)));
                    stopWatch.Reset();

                    EnableSearchControls(true);
                    Program.Log.Info("Search completed");
                }
            });
        }

        private void DatagridFileItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                DisplayFileDetails(SelectedGridFile);
        }

        private void DatagridFileItems_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void DatagridFileItems_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus;
        }
        
        private void DatagridFileItems_SelectionChanged(object sender, EventArgs e)
        {
            PanelFileDetails.Enabled = DatagridFileItems.SelectedRows.Count != 0;

            if (DatagridFileItems.SelectedRows.Count != 0)
                SelectedGridFile = LocalData.GetFile(DatagridFileItems.CurrentRow.Cells[4].Value.ToString());
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            if (DatagridFileItems.SelectedRows.Count > 0)
                Process.Start(SelectedGridFile.URL);
        }

        private void MenuFileViewDetails_Click(object sender, EventArgs e)
        {
            if (DatagridFileItems.SelectedRows.Count > 0)
                DisplayFileDetails(SelectedGridFile);
        }

        private void MenuFileCopyURL_Click(object sender, EventArgs e)
        {
            if (DatagridFileItems.SelectedRows.Count > 0)
            {
                Clipboard.SetText(SelectedGridFile.URL);
                SetStatus("Copied File URL to Clipboard");
            }
        }

        private void MenuFileEmail_Click(object sender, EventArgs e)
        {
            Process.Start($"mailto:" +
                $"?body={string.Format("{0} ({1})", SelectedGridFile.Name, ListboxSearchType.SelectedItem.ToString())}" +
                $"&subject={string.Format("{0} ({1})\n\nSize: {2}\n\nLast Modified: {3}\n\nDownload: {4}\n\n\n\nAuto-generated by FileMasta: https://github.com/herbL27/filemasta", SelectedGridFile.Name, ListboxSearchType.SelectedItem.ToString(), SelectedGridFile.Size, SelectedGridFile.DateModified, SelectedGridFile.URL)}");
        }

        public FtpFile SelectedGridFile { get; set; } = null;

        /// <summary>
        /// Display selected file information in the details pane
        /// </summary>
        /// <param name="file">WebFile object</param>
        public void DisplayFileDetails(FtpFile file)
        {
            Program.Log.Info("Selected file properties " + file.URL);
            SelectedGridFile = file;
            LabelFileValueName.Text = file.Name;
            LabelFileValueSize.Text = StringExt.BytesToPrefix(file.Size);
            LabelFileValueDomain.Text = new Uri(file.URL).Host;
            LabelFileValueModified.Text = file.DateModified.ToString("dd MMMM yyyy");
            LabelFileValueAge.Text = StringExt.TimeSpanAge(file.DateModified);
            LabelFileValueExtension.Text = file.GetExtension();
            LabelFileValueURL.Text =  Uri.UnescapeDataString(file.URL);
            LabelFileUrlBG.Height = LabelFileValueURL.Height + 17;

            foreach (ToolStripMenuItem item in ContextFileOpenWith.Items)
                item.Visible = false;

            if (FileType.Document.Contains(file.GetExtension()))
            {
                NitroReaderToolStripMenuItem.Visible = File.Exists(LocalExt._pathNitroReader);
            }

            if (FileType.Video.Contains(file.GetExtension()) || FileType.Audio.Contains(file.GetExtension()))
            {
                WMPToolStripMenuItem.Visible = true;
                VLCToolStripMenuItem.Visible = File.Exists(LocalExt._pathVLC);
                MPCToolStripMenuItem.Visible = File.Exists(LocalExt._pathMPCCodec64) || File.Exists(LocalExt._pathMPC64) || File.Exists(LocalExt._pathMPC86);
                KMPlayerToolStripMenuItem.Visible = File.Exists(LocalExt._pathKMPlayer);
                PotPlayerToolStripMenuItem.Visible = File.Exists(LocalExt._pathPotPlayer);
            }

            IDMToolStripMenuItem.Visible = File.Exists(LocalExt._pathIDM64) || File.Exists(LocalExt._pathIDM86);
            IDAToolStripMenuItem.Visible = File.Exists(LocalExt._pathIDA);
            FDMToolStripMenuItem.Visible = File.Exists(LocalExt._pathFDM);

            if (LocalData.IsBookmarked(file))
                ControlExt.SetControlTextWidth(ButtonFileBookmark, "Unbookmark");
            else
                ControlExt.SetControlTextWidth(ButtonFileBookmark, "Bookmark");

            ButtonFileRequestSize.Visible = file.Size == 0;
            ButtonFileOpenWith.Visible = ContextFileOpenWith.Items.Count > 0;
        }

        private void ButtonFileRequestSize_Click(object sender, EventArgs e)
        {
            ButtonFileRequestSize.Visible = false;
            WorkerExt.RunWorkAsync(() => StringExt.BytesToPrefix(WebExt.FtpFileSize(SelectedGridFile.URL)), (data) => { LabelFileValueSize.Text = data; });
        }

        private void MenuFileBookmark_Click(object sender, EventArgs e)
        {
            if (LocalData.IsBookmarked(SelectedGridFile))
            {
                LocalData.Unbookmark(SelectedGridFile);
                ControlExt.SetControlTextWidth(ButtonFileBookmark, "Bookmark");
            }
            else
            {
                LocalData.Bookmark(SelectedGridFile);
                ControlExt.SetControlTextWidth(ButtonFileBookmark, "Unbookmark");
            }
        }

        private void ButtonFileDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(SelectedGridFile.URL);
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

        private void ButtonFileBookmark_Click(object sender, EventArgs e)
        {
            if (LocalData.IsBookmarked(SelectedGridFile))
            {
                LocalData.Unbookmark(SelectedGridFile);
                ControlExt.SetControlTextWidth(ButtonFileBookmark, "Bookmark");
            }
            else
            {
                LocalData.Bookmark(SelectedGridFile);
                ControlExt.SetControlTextWidth(ButtonFileBookmark, "Unbookmark");
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
                if (searchItem is Label)
                    ((Label)searchItem).Enabled = isEnabled;
        }

        /// <summary>
        /// Set text in the toolstrip menu
        /// </summary>
        /// <param name="message">Message/status to be displayed</param>
        public static void SetStatus(string message)
        {
            Form.StatusStripStatus.Text = message;
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