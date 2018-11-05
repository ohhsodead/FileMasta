using System;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using FileMasta.Windows;
using FileMasta.Utilities;
using FileMasta.Models;
using FileMasta.GitHub;
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
        /// Splash Screen (one instance)
        /// </summary>
        public static SplashScreen FormSplashScreen { get; } = new SplashScreen();

        /// <summary>
        /// File Details Window (one instance)
        /// </summary>
        public static FileDetailsWindow FormFileDetails { get; set; } = null;

        /// <summary>
        /// WebClient resource, sets proxy configuration
        /// </summary>
        public static WebClient _webClient { get; set; } = new WebClient();

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

            // Set default preferences
            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;
            ComboBoxHost.SelectedIndex = 0;

            Program.Log.Info("Initialized");
        }

        /*************************************************************************/
        /* Form / Startup Events                                                 */
        /*************************************************************************/

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.Log.Info("Loading application tasks beginning");
            Directory.CreateDirectory(LocalExtensions.PathRoot);
            Directory.CreateDirectory(LocalExtensions.PathData);
            Updates.CheckForUpdate();
            LoadMostSearches();
            BackGroundWorker.RunWorkAsync(() => Database.UpdateLocalDatabase(), InitializeFinished);
        }

        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetDatabaseMetadata();
            Controls.Remove(FormSplashScreen);
            Program.Log.Info("Loading tasks completed");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.ApplicationExitCall)
                if (Properties.Settings.Default.clearDataOnClose)
                    if (Directory.Exists(LocalExtensions.PathData))
                        Directory.Delete(LocalExtensions.PathData, true);
            Program.Log.Info("Closing application");
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        /// <summary>
        /// Fix paint form
        /// </summary>
        protected override void OnPaint(PaintEventArgs e) { }

        /// <summary>
        /// Declare new lists to store database info in variables
        /// </summary>
        public static List<FtpFile> DbOpenFiles { get; set; } = new List<FtpFile>();
        public static List<string> DbOpenServers { get; set; } = new List<string>();
        public static Metadata DbMetaData { get; set; }

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
        private void MenuStripBookmarks_Click(object sender, EventArgs e)
        {
            var bookmarksWindow = new BookmarksWindow();
            bookmarksWindow.Show(this);
        }

        // Tools
        private void MenuToolsFtpServerList_Click(object sender, EventArgs e)
        {
            var serversWindow = new ServersWindow();
            serversWindow.Show(this);
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
        private void MenuHelpKeyboardShortcuts_Click(object sender, EventArgs e)
        {
            var shortcutsWindow = new ShortcutsWindow();
            shortcutsWindow.ShowDialog(this);
        }

        private void MenuHelpReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start($"{OpenLink.UrlGitHub}issues/new");
        }

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
            var aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog(this);
        }

        /// <summary>
        /// Set database meta data to be shown in UI
        /// </summary>
        public void SetDatabaseMetadata()
        {
            StatusStripDatabaseInfo.Text = string.Format(StatusStripDatabaseInfo.Text,
                StringExtensions.FormatNumber(DbOpenFiles.Count.ToString()),
                StringExtensions.BytesToPrefix(Database.TotalFilesSize()),
                StringExtensions.FormatNumber(DbOpenServers.Count.ToString()),
                DbMetaData.Updated.ToShortDateString());
        }

        /// <summary>
        /// Get and load Most Searches to the interface
        /// </summary>
        delegate void LoadMostSearchesCallBack();
        private void LoadMostSearches()
        {
            try
            {
                ExceptionEvents.RetryOnException(3, TimeSpan.FromSeconds(2), () => {
                    Program.Log.Info("Preparing to display most searches");

                    BackGroundWorker.RunWorkAsync<List<string>>(() => GetMostSearches(), (data) => {
                        if (InvokeRequired)
                            Invoke(new LoadMostSearchesCallBack(LoadMostSearches), new object[] { });
                        else
                        {
                            int count = 0;
                            foreach (var tag in data)
                                if (count <= 100)
                                    FlowPanelMostSearches.Controls.Add(ControlExtensions.LabelMostSearch(tag, count)); count++;

                            Program.Log.Info("Completed most searches");
                        }
                    });
                });
            }
            catch (Exception ex) { LabelMostSearches.Visible = false; FlowPanelMostSearches.Visible = false; Program.Log.Error("Unable to get most searches", ex); } // Error occurred, so hide controls and skip...
        }

        /// <summary>
        /// Retrieve Most Searches from database
        /// </summary>
        /// <returns>List containg all most searches returned</returns>
        private List<string> GetMostSearches()
        {
            Program.Log.Info("Requesting most searches from database");
            List<string> listTopSearches = new List<string>();
            var request = WebExtensions.GetRequest(Database.DbTopSearches);
            using (WebResponse webResponse = request.GetResponse())
            using (var reader = new StreamReader(webResponse.GetResponseStream()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    listTopSearches.Add(line);
            }
            Program.Log.Info("Returned most searches");
            return listTopSearches;
        }

        /*************************************************************************/
        /* Search Files                                                           */
        /*************************************************************************/

        /// <summary>
        /// User Preference: Type
        /// </summary>
        public string[] SelectedFilesType { get; set; } = Types.Everything;

        /// <summary>
        /// User Preference: Sort
        /// </summary>
        public Query.Sort SelectedFilesSort { get; set; } = Query.Sort.Name;

        /// <summary>
        /// User Preference: Host
        /// </summary>
        public string SelectedFilesHost { get; set; } = "";
        
        private void TextBoxSearchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (TextBoxSearchQuery.Text.Length > 2)
                    SearchFiles();
                else
                    SetStatus("Minimum 3 characters.");
        }

        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchQuery.Text.Length > 2)
                SearchFiles();
            else
                SetStatus("Minimum 3 characters.");
        }

        private void MenuSearchGoogle_Click(object sender, EventArgs e)
        {
            Process.Start(UrlSearchGoogle + string.Format("{0} %2B({1}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", TextBoxSearchQuery.Text, string.Join("|", SelectedFilesType.ToArray()).ToLower()));
        }

        private void MenuSearchGoogol_Click(object sender, EventArgs e)
        {
            Process.Start(UrlSearchGoogol + string.Format("{0} %2B({1}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", TextBoxSearchQuery.Text, string.Join("|", SelectedFilesType.ToArray()).ToLower()));
        }

        private void MenuSearchStartPage_Click(object sender, EventArgs e)
        {
            Process.Start(UrlSearchStartPage + string.Format("{0} %2B({1}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", TextBoxSearchQuery.Text, string.Join("|", SelectedFilesType.ToArray()).ToLower()));
        }

        private void MenuSearchSearx_Click(object sender, EventArgs e)
        {
            Process.Start(UrlSearchSearx + string.Format("{0} %2B({1}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", TextBoxSearchQuery.Text, string.Join("|", SelectedFilesType.ToArray()).ToLower()));
        }

        /// <summary>
        /// External search engine URLs
        /// </summary>
        static string UrlSearchGoogle =         "https://google.com/search?q=";
        static string UrlSearchGoogol =         "https://googol.warriordudimanche.net/?q=";
        static string UrlSearchStartPage =      "https://startpage.com/do/dsearch?query=";
        static string UrlSearchSearx =          "https://searx.me/?q=";

        // Files Type
        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxType.SelectedIndex == -1) SelectedFilesType = Types.Everything;
            else if (ComboBoxType.SelectedIndex == 0) SelectedFilesType = Types.Everything;
            else if (ComboBoxType.SelectedIndex == 1) SelectedFilesType = Types.Audio;
            else if (ComboBoxType.SelectedIndex == 2) SelectedFilesType = Types.Compressed;
            else if (ComboBoxType.SelectedIndex == 3) SelectedFilesType = Types.Document;
            else if (ComboBoxType.SelectedIndex == 4) SelectedFilesType = Types.Executable;
            else if (ComboBoxType.SelectedIndex == 5) SelectedFilesType = Types.Picture;
            else if (ComboBoxType.SelectedIndex == 6) SelectedFilesType = Types.Video;
        }

        // Sort Files
        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort.SelectedIndex == 0) SelectedFilesSort = Query.Sort.Name;
            else if (ComboBoxSort.SelectedIndex == 1) SelectedFilesSort = Query.Sort.Size;
            else if (ComboBoxSort.SelectedIndex == 2) SelectedFilesSort = Query.Sort.Date;
        }

        // Host
        private void ComboBoxHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHost.SelectedIndex == 0) SelectedFilesHost = "";
            else SelectedFilesHost = ComboBoxHost.SelectedItem.ToString();
        }

        public void SearchFiles()
        {
            if (Uri.TryCreate(TextBoxSearchQuery.Text, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeFtp ) && uriResult != null)
                try
                {
                    ShowFileDetails(Database.FtpFile(TextBoxSearchQuery.Text), DataGridFiles);
                    TextBoxSearchQuery.Text = null;
                }
                catch (Exception ex) { MessageBox.Show(this, "There was an issue requesting file information. Make sure the server/files allows for anonymous authentication access, otherwise make sure sure there's no typos.\n\n" + ex.Message); }
            else
                QueryFiles();
        }

        private void DataGridFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var webFile = Database.FtpFile(DataGridFiles.CurrentRow.Cells[4].Value.ToString());
                SetStatus(string.Format("Size: {0}, Last Modified: {1}, URL: {2}", StringExtensions.BytesToPrefix(webFile.Size), webFile.DateModified.ToString("MM/dd/yyyy HH:mm"), Uri.UnescapeDataString(webFile.URL)));
            }
            else
                SetStatus(string.Format("{0} Files", StringExtensions.FormatNumber(DataGridFiles.Rows.Count.ToString())));
        }
        
        private void DataGridFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ShowFileDetails(Database.FtpFile(DataGridFiles.CurrentRow.Cells[4].Value.ToString()), DataGridFiles);
            }
        }
        
        private void DataGridFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void DataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus;
        }

        delegate void QueryFilesCallBack();
        public void QueryFiles()
        {
            SetStatus("Searching files...");
            Program.Log.InfoFormat("Starting to search files. Preferences - Query: {0}, Sort: {1}, Type: {2}, Host: {3}", TextBoxSearchQuery.Text, SelectedFilesSort.ToString(), SelectedFilesType.ToArray(), SelectedFilesHost);
            Stopwatch stopWatch = new Stopwatch();
            EnableSearchControls(false);
            stopWatch.Start();
            BackGroundWorker.RunWorkAsync(() => Query.Search(DbOpenFiles, TextBoxSearchQuery.Text, SelectedFilesSort, SelectedFilesType, SelectedFilesHost), (ftpFiles) =>
            {
                if (InvokeRequired)
                    Invoke(new QueryFilesCallBack(QueryFiles), new object[] { });
                else
                {
                    DataGridFiles.Rows.Clear();
                    ComboBoxHost.Items.Clear(); ComboBoxHost.Items.Add("Any");
                    //foreach (var ftpFile in data)
                    //{
                    //    DataGridFiles.Rows.Add(ftpFile.Name, StringExtensions.BytesToPrefix(ftpFile.Size), StringExtensions.TimeSpanAge(ftpFile.DateModified), new Uri(ftpFile.URL).Host, ftpFile.URL);
                    //    if (!(ComboBoxHost.Items.Contains(new Uri(ftpFile.URL).Host)))
                    //        ComboBoxHost.Items.Add(new Uri(ftpFile.URL).Host);
                    //}

                    ftpFiles.ForEach(ftpFile => 
                    {
                        DataGridFiles.Rows.Add(ftpFile.Name, StringExtensions.BytesToPrefix(ftpFile.Size), StringExtensions.TimeSpanAge(ftpFile.DateModified), new Uri(ftpFile.URL).Host, ftpFile.URL);
                        if (!(ComboBoxHost.Items.Contains(new Uri(ftpFile.URL).Host))) ComboBoxHost.Items.Add(new Uri(ftpFile.URL).Host);
                    });

                    //for (int i = 0; i < ftpFiles.Count; ++i)
                    //{
                    //    var ftpFile = ftpFiles[i];
                    //    DataGridFiles.Rows.Add(ftpFile.Name, StringExtensions.BytesToPrefix(ftpFile.Size), StringExtensions.TimeSpanAge(ftpFile.DateModified), new Uri(ftpFile.URL).Host, ftpFile.URL);
                    //    if (!(ComboBoxHost.Items.Contains(new Uri(ftpFile.URL).Host))) ComboBoxHost.Items.Add(new Uri(ftpFile.URL).Host);
                    //}

                    stopWatch.Stop();
                    SetStatus(string.Format("{0} Files ({1} seconds)", StringExtensions.FormatNumber(DataGridFiles.Rows.Count.ToString()), String.Format("{0:0.000}", stopWatch.Elapsed.TotalSeconds)));
                    stopWatch.Reset();

                    // Sets selected item to host
                    if (SelectedFilesHost == "") ComboBoxHost.SelectedIndex = 0;
                    else ComboBoxHost.SelectedItem = SelectedFilesHost;

                    EnableSearchControls(true);
                    Program.Log.Info(StatusStripStatus.Text);
                }
            }); 
        }

        // Context Menu Items
        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
                Process.Start(URL);
            }
        }

        private void MenuFileViewDetails_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
                ShowFileDetails(Database.FtpFile(URL), DataGridFiles);
            }
        }

        private void MenuFileViewWebPage_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                Uri URL = new Uri(DataGridFiles.CurrentRow.Cells[4].Value.ToString());
                Process.Start(URL.AbsoluteUri.Remove(URL.AbsoluteUri.Length - URL.Segments.Last().Length));
            }
        }

        private void MenuFileCopyURL_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
                Clipboard.SetText(URL);
                MessageBox.Show("Clipboard set to : " + URL);
            }
        }

        /// <summary>
        /// Enable/Disable search controls, to prevent another search process which causes a crash
        /// </summary>
        /// <param name="isEnabled">Enable/Disable Controls</param>
        private void EnableSearchControls(bool isEnabled)
        {
            TextBoxSearchQuery.Enabled = isEnabled;
            ButtonSearchFiles.Enabled = isEnabled;
            ButtonSearchEngine.Enabled = isEnabled;
            ComboBoxSort.Enabled = isEnabled;
            ComboBoxHost.Enabled = isEnabled;
            ComboBoxType.Enabled = isEnabled;
            foreach (var searchItem in FlowPanelMostSearches.Controls)
                if (searchItem is Label)
                    ((Label)searchItem).Enabled = isEnabled;
        }

        /// <summary>
        /// Show details/info for a WebFile
        /// </summary>
        /// <param name="File">WebFile object</param>
        /// <param name="parentDataGrid">Parent data grid to scroll</param>
        /// <param name="createNewInstance">Whether to create a new instance</param>
        public void ShowFileDetails(FtpFile File, DataGridView parentDataGrid, bool createNewInstance = true)
        {
            Program.Log.Info("Loading file details : " + File.URL);

            if (createNewInstance)
                FormFileDetails = new FileDetailsWindow();

            FormFileDetails.FileExtension = Path.GetExtension(File.URL).Replace(".", "").ToUpper();
            FormFileDetails.ParentDataGrid = parentDataGrid;
            FormFileDetails.CurrentFile = File;

            FormFileDetails.LabelFileName.Text = File.Name;
            FormFileDetails.LabelValueName.Text = File.Name;
            FormFileDetails.LabelValueSize.Text = StringExtensions.BytesToPrefix(File.Size);
            FormFileDetails.LabelValueRefferer.Text = new Uri(File.URL).Host;

            // Builds parts of the URL into a better presented string, simply replaces '/' with '>' and no filename
            var url = new Uri(File.URL);
            var directories = new StringBuilder();
            directories.Append(new Uri(File.URL).Host);
            foreach (var path in url.LocalPath.Split('/', '\\'))
                if (!Path.HasExtension(path))
                    directories.Append(path + "> ");
            FormFileDetails.LabelValueDirectory.Text = directories.ToString();

            FormFileDetails.LabelValueExtension.Text = Path.GetExtension(File.URL).Replace(".", "").ToUpper();
            FormFileDetails.LabelValueAge.Text = StringExtensions.TimeSpanAge(File.DateModified);
            FormFileDetails.InfoFileURL.Text = Uri.UnescapeDataString(File.URL);

            if (!createNewInstance)
                FormFileDetails.CheckFileEvents();
            else
                FormFileDetails.ShowDialog(this);

            FormFileDetails.Text = File.Name + " - File Details";
            Program.Log.Info("Completed file details");
        }

        /// <summary>
        /// Set Status Text of ToolStrip
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
                    TextBoxSearchQuery.Focus();
                    return true;
                // Show Shortcuts Window
                case Keys.Control | Keys.OemQuestion:
                    MenuHelpKeyboardShortcuts.PerformClick();
                    return true;
                // Close File Details if open
                case Keys.Escape:
                    if (FormFileDetails != null)
                        FormFileDetails.Dispose();
                    return true;
                // Close application
                case Keys.Control | Keys.W:
                    Application.Exit();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonSearchEngine_Click(object sender, EventArgs e)
        {
            ContextMenuSearchEngine.Show(ButtonSearchEngine, PointToClient(ButtonSearchEngine.Location));
        }
    }
}