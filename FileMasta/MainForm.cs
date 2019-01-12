using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using FileMasta.Windows;
using FileMasta.Utilities;
using FileMasta.Models;
using FileMasta.Files;
using FileMasta.Extensions;
using FileMasta.Controls;

namespace FileMasta
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// This is only instance of the main form, set after InitializeComponent()
        /// </summary>
        public static MainForm Form { get; set; } = null;

        /// <summary>
        /// Stores the current instance of the database
        /// </summary>
        public static Database LocalData { get; set; } = null;

        /// <summary>
        /// Splash Screen (one instance)
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
            
            // Show Splash Screen
            Controls.Add(FormSplashScreen);
            FormSplashScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            FormSplashScreen.Location = new Point(0, 0);
            FormSplashScreen.Size = Form.ClientSize;
            FormSplashScreen.BringToFront();
            FormSplashScreen.Show();

            // Set default control properties
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
            Updates.CheckForUpdate();
            BackGroundWorker.RunWorkAsync(() => { LocalData = new Database(); }, InitializeFinished);
        }

        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            int noKeywords = 0;
            foreach (var keyword in LocalData.GetKeywords())
                if (noKeywords <= 100)
                    FlowpanelKeywords.Controls.Add(ControlExtensions.LabelMostSearch(keyword, noKeywords)); noKeywords++;
            SetMetadata();
            Controls.Remove(FormSplashScreen);
            Program.Log.Info("Startup events completed");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.ApplicationExitCall)
                if (Properties.Settings.Default.clearDataOnClose)
                    if (Directory.Exists(LocalExtensions.PathData))
                        Directory.Delete(LocalExtensions.PathData, true);
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
        private void MenuStripBookmarksShow_Click(object sender, EventArgs e)
        {
            CheckboxSearchBookmarks.Checked = true;
            SearchFiles();
        }

        private void MenuStripBookmarksClear_Click(object sender, EventArgs e)
        {
            LocalData.ClearBookmarks();
        }

        // Tools
        private void MenuToolsFtpServerList_Click(object sender, EventArgs e)
        {
            Process.Start(GitHub.URL_SERVERS);
        }

        private void MenuToolsSubmitFtpServer_Click(object sender, EventArgs e)
        {
            var submitWindow = new SubmitWindow();
            submitWindow.ShowDialog(this);
        }

        private void MenuToolsOptions_Click(object sender, EventArgs e)
        {
            var optionsWindow = new OptionsWindow();
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
            ControlExtensions.ShowDataWindow("Changelog", GitHub.URL_CHANGELOG);
        }

        private void MenuHelpKeyboardShortcuts_Click(object sender, EventArgs e)
        {
            var shortcutsWindow = new ShortcutsWindow();
            shortcutsWindow.ShowDialog(this);
        }

        private void MenuHelpReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start($"{GitHub.URL_PROJECT}issues/new");
        }

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
            var aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog(this);
        }

        private void MenuHelpCheckForUpdate_Click(object sender, EventArgs e)
        {
            Updates.CheckForUpdate();
        }

        /// <summary>
        /// Set database meta data to the toolstrip
        /// </summary>
        public void SetMetadata()
        {
            StatusStripDatabaseInfo.Text = string.Format(StatusStripDatabaseInfo.Text,
                StringExtensions.FormatNumber(LocalData.NoOfFiles().ToString()),
                StringExtensions.BytesToPrefix(LocalData.TotalFileSize()),
                LocalData.MetaData.Updated.ToShortDateString());
        }
        
        /*************************************************************************/
        /* Search Files                                                          */
        /*************************************************************************/

        /// <summary>
        /// Search preference: Type
        /// </summary>
        public string[] SearchFileType { get; set; } = Files.Type.Everything;

        /// <summary>
        /// Search preference: Type
        /// </summary>
        public string SearchSizePrefix { get; set; } = "Bytes";

        /// <summary>
        /// Search preference: Sort
        /// </summary>
        public Database.Sort SearchSortBy { get; set; } = Database.Sort.Name;

        /// <summary>
        /// Search preference: Search Bookmarks
        /// </summary>
        public bool SearchBookmarks { get; set; } = false;

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

        private void CheckboxSearchBookmarks_CheckedChanged(object sender, EventArgs e)
        {
            SearchBookmarks = CheckboxSearchBookmarks.Checked;
        }
        
        // External Searches
        private void MenuSearchGoogle_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalSearch.URL_GOOGLE, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }

        private void MenuSearchGoogol_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalSearch.URL_GOOGOL, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }

        private void MenuSearchStartPage_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalSearch.URL_STARTPAGE, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }

        private void MenuSearchSearx_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("{0}{1} %2B({2}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", ExternalSearch.URL_SEARX, TextboxSearchName.Text, string.Join("|", SearchFileType.ToArray()).ToLower()));
        }        

        private void ListboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListboxSearchType.SelectedIndex == -1)
                SearchFileType = Files.Type.Everything;
            else if (ListboxSearchType.SelectedIndex == 0)
                SearchFileType = Files.Type.Everything;
            else if (ListboxSearchType.SelectedIndex == 1)
                SearchFileType = Files.Type.Audio;
            else if (ListboxSearchType.SelectedIndex == 2)
                SearchFileType = Files.Type.Compressed;
            else if (ListboxSearchType.SelectedIndex == 3)
                SearchFileType = Files.Type.Document;
            else if (ListboxSearchType.SelectedIndex == 4)
                SearchFileType = Files.Type.Executable;
            else if (ListboxSearchType.SelectedIndex == 5)
                SearchFileType = Files.Type.Picture;
            else if (ListboxSearchType.SelectedIndex == 6)
                SearchFileType = Files.Type.Video;
        }

        private void DropdownSearchSizePrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchSizePrefix = DropdownSearchSizePrefix.GetItemText(DropdownSearchSizePrefix.SelectedItem);
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownSearchSort.SelectedIndex == 0)
                SearchSortBy = Database.Sort.Name;
            else if (DropdownSearchSort.SelectedIndex == 1)
                SearchSortBy = Database.Sort.Size;
            else if (DropdownSearchSort.SelectedIndex == 2)
                SearchSortBy = Database.Sort.Date;
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
                    MessageBox.Show("There was an issue requesting file information.Make sure the server / files allows for anonymous authentication access, otherwise make sure sure there's no typo.\n\n" + ex.Message);
                }
            else
                 SearchFiles();
        }

        delegate void SearchFilesCallBack();
        public void SearchFiles()
        {
            SetStatus("Searching...");
            Program.Log.InfoFormat("Searching. Filters: Name: {0}, Sort: {1}, Type: {2}, Size : {3}, Last Modified : {3} to {4}", TextboxSearchName.Text, SearchSortBy.ToString(), SearchFileType.ToArray(), NumericSearchGreaterThan, DatetimeSearchLastModifiedMin, DatetimeSearchLastModifiedMax);
            EnableSearchControls(false);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            BackGroundWorker.RunWorkAsync(() => LocalData.Search(SearchBookmarks, SearchSortBy, TextboxSearchName.Text, SearchFileType, StringExtensions.ParseFileSize(string.Format("{0} {1}", (long)NumericSearchGreaterThan.Value, SearchSizePrefix)), DatetimeSearchLastModifiedMin.Value, DatetimeSearchLastModifiedMax.Value), (files) =>
            {
                if (InvokeRequired)
                    Invoke(new SearchFilesCallBack(SearchFiles), new object[] { });
                else
                {
                    DatagridFileItems.Rows.Clear();

                    foreach (var file in files)
                    {
                        DatagridFileItems.Rows.Add(file.Name + "." + file.GetExtension(), StringExtensions.BytesToPrefix(file.Size), file.DateModified, new Uri(file.URL).Host, file.URL);
                    }

                    stopWatch.Stop();
                    SetStatus(string.Format("{0} Results ({1} seconds)", StringExtensions.FormatNumber(DatagridFileItems.Rows.Count.ToString()), String.Format("{0:0.000}", stopWatch.Elapsed.TotalSeconds)));
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
            LabelFileValueSize.Text = StringExtensions.BytesToPrefix(file.Size);
            LabelFileValueReferrer.Text = new Uri(file.URL).Host;
            LabelFileValueExtension.Text = file.GetExtension();
            LabelFileValueLastModified.Text = string.Format("{0} ({1})", file.DateModified.ToString("dddd, dd MMMM yyyy"), StringExtensions.TimeSpanAge(file.DateModified));
            LabelFileValueURL.Text =  Uri.UnescapeDataString(file.URL);
            LabelFileUrlBG.Height = LabelFileValueURL.Height + 18;

            foreach (ToolStripMenuItem item in ContextFileOpenWith.Items)
                item.Visible = false;

            if (Files.Type.Document.Contains(file.GetExtension()))
            {
                NitroReaderToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathNitroReader);
            }

            if (Files.Type.Video.Contains(file.GetExtension()) || Files.Type.Audio.Contains(file.GetExtension()))
            {
                WMPToolStripMenuItem.Visible = true;
                VLCToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathVLC);
                MPCToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathMPCCodec64) || File.Exists(LocalExtensions._pathMPC64) || File.Exists(LocalExtensions._pathMPC86);
                KMPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathKMPlayer);
                PotPlayerToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathPotPlayer);
            }

            IDMToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathIDM64) || File.Exists(LocalExtensions._pathIDM86);
            IDAToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathIDA);
            FDMToolStripMenuItem.Visible = File.Exists(LocalExtensions._pathFDM);

            if (LocalData.IsBookmarked(file))
                ControlExtensions.SetControlTextWidth(ButtonFileBookmark, "Unbookmark");
            else
                ControlExtensions.SetControlTextWidth(ButtonFileBookmark, "Bookmark");

            ButtonFileRequestSize.Visible = file.Size == 0;
            ButtonFileOpenWith.Visible = ContextFileOpenWith.Items.Count > 0;
        }

        private void ButtonFileRequestSize_Click(object sender, EventArgs e)
        {
            ButtonFileRequestSize.Visible = false;
            BackGroundWorker.RunWorkAsync(() => StringExtensions.BytesToPrefix(WebExtensions.FtpFileSize(SelectedGridFile.URL)), (data) => { LabelFileValueSize.Text = data; });
        }

        private void MenuFileBookmark_Click(object sender, EventArgs e)
        {
            if (LocalData.IsBookmarked(SelectedGridFile))
            {
                LocalData.RemoveFile(SelectedGridFile);
                ControlExtensions.SetControlTextWidth(ButtonFileBookmark, "Bookmark");
            }
            else
            {
                LocalData.AddFile(SelectedGridFile);
                ControlExtensions.SetControlTextWidth(ButtonFileBookmark, "Unbookmark");
            }
            LocalData.SaveBookmarks();
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
                LocalData.RemoveFile(SelectedGridFile);
                ControlExtensions.SetControlTextWidth(ButtonFileBookmark, "Bookmark");
            }
            else
            {
                LocalData.AddFile(SelectedGridFile);
                ControlExtensions.SetControlTextWidth(ButtonFileBookmark, "Unbookmark");
            }
            LocalData.SaveBookmarks();
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
                // Show Shortcuts Window
                case Keys.Control | Keys.OemQuestion:
                    MenuHelpShortcutKeys.PerformClick();
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