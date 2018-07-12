using FileMasta.Controls;
using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.GitHub;
using FileMasta.Models;
using FileMasta.Utilities;
using FileMasta.Windows;
using FileMasta.Worker;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System;

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
            Program.log.Info("Initializing");

            // Initialize
            InitializeComponent();

            // Set this instance
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

            Program.log.Info("Initialized");
        }

        /*************************************************************************/
        /* Share on Social Media                                                 */
        /*************************************************************************/

        public string shareMessage = "Hey guys, I found a brilliant way to find direct download links for anything.";

        private void ImageShareTwitter_Click(object sender, EventArgs e)
        {
            Process.Start($"https://twitter.com/intent/tweet?hashtags=FileMasta&original_referer=https%3A%2F%2Fgithub.com/HerbL27/FileMasta%2F&ref_src=twsrc%5Etfw&text={shareMessage}&tw_p=tweetbutton&url=https%3A%2F%2Fgithub.com/HerbL27/FileMasta");
        }

        private void ImageShareFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/sharer/sharer.php?app_id=248335808680372&kid_directed_site=0&sdk=joey&u=http%3A%2F%2Fgithub.com/HerbL27/FileMasta%2F&display=popup&ref=plugin&src=share_button");
        }

        /*************************************************************************/
        /* Form / Startup Events                                                 */
        /*************************************************************************/

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.log.Info("Starting load events");

            Directory.CreateDirectory(LocalExtensions.pathRoot);
            Directory.CreateDirectory(LocalExtensions.pathData);

            Updates.CheckForUpdate();
            LoadTopSearches();
            BackGroundWorker.RunWorkAsync(() => Database.UpdateLocalDatabase(), InitializeFinished);

            Program.log.Info("Completed all load events");
        }

        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetDatabaseInfo();
            Controls.Remove(FormSplashScreen);
            Program.log.Info("All startup tasks completed");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.ApplicationExitCall)
                if (Properties.Settings.Default.clearDataOnClose)
                    if (Directory.Exists(LocalExtensions.pathData))
                        Directory.Delete(LocalExtensions.pathData, true);

            Program.log.Info("Closing application");
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
            bookmarksWindow.ShowDialog(this);
        }

        // Tools
        private void MenuToolsFtpServerList_Click(object sender, EventArgs e)
        {
            var serversWindow = new ServersWindow();
            serversWindow.ShowDialog(this);
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
        
        private void MenuHelpTermsOfUse_Click(object sender, EventArgs e)
        {
            ControlExtensions.ShowDataWindow(((ToolStripMenuItem)sender).Text, Resources.UrlTermsOfUse);
        }

        private void MenuHelpPrivacyPolicy_Click(object sender, EventArgs e)
        {
            ControlExtensions.ShowDataWindow(((ToolStripMenuItem)sender).Text, Resources.UrlPrivacyPolicy);
        }

        private void MenuHelpChangeLog_Click(object sender, EventArgs e)
        {
            ControlExtensions.ShowDataWindow(((ToolStripMenuItem)sender).Text, Resources.UrlChangeLog);
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
        public void SetDatabaseInfo()
        {
            StatusStripDatabaseInfo.Text = string.Format(StatusStripDatabaseInfo.Text,
                StringExtensions.FormatNumber(DbMetaData.Files.ToString()),
                StringExtensions.BytesToPrefix(Database.TotalFilesSize()),
                StringExtensions.FormatNumber(DbOpenServers.Count.ToString()),
                DbMetaData.Updated.ToShortDateString());
        }

        /// <summary>
        /// Get Top Searches from FileChef.com
        /// </summary>
        delegate void LoadTopSearchesCallBack();
        private void LoadTopSearches()
        {
            try
            {
                Program.log.Info("Getting most searches");

                BackGroundWorker.RunWorkAsync<List<string>>(() => GetTopSearches(), (data) =>
                {
                    if (InvokeRequired)
                    {
                        Invoke(new LoadTopSearchesCallBack(LoadTopSearches), new object[] { });
                    }
                    else
                    {
                        int count = 0;
                        foreach (var tag in data)
                            if (count <= 100)
                            {
                                FlowPanelMostSearches.Controls.Add(ControlExtensions.GetMostSearchTag(tag, count));
                                count++;
                            }

                        Program.log.Info("Most searches returned successfully");
                    }
                });
            }
            catch (Exception ex) { LabelMostSearches.Visible = false; FlowPanelMostSearches.Visible = false; Program.log.Error("Error getting top searches", ex); } /* Error occurred, so hide controls/skip... */
        }

        /// <summary>
        /// Get Top Searches from web database
        /// </summary>
        /// <returns></returns>
        private List<string> GetTopSearches()
        {
            List<string> listTopSearches = new List<string>();

            ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            var request = WebExtensions.GetRequest(Database.dbTopSearches);
            using (WebResponse webResponse = request.GetResponse())
            using (var reader = new StreamReader(webResponse.GetResponseStream()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    listTopSearches.Add(line);
            }

            return listTopSearches;
        }

        /*************************************************************************/
        /* Search Files                                                           */
        /*************************************************************************/

        /// <summary>
        /// User Preference: Type
        /// </summary>
        public string[] SelectedFilesType { get; set; } = Types.Any;

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
                else SetStatus("Minimum 3 characters.");
        }

        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchQuery.Text.Length > 2)
                SearchFiles();
            else SetStatus("Minimum 3 characters.");
        }

        // Files Type
        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxType.SelectedIndex == -1) SelectedFilesType = Types.Any;
            else if (ComboBoxType.SelectedIndex == 0) SelectedFilesType = Types.Any;
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
            SetStatus("Searching files..");

            if (Uri.TryCreate(TextBoxSearchQuery.Text, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps) && uriResult != null)
                if (WebExtensions.URLExists(uriResult.ToString()))
                {
                    try
                    {
                        ShowFileDetails(Database.FtpFile(TextBoxSearchQuery.Text), DataGridFiles);
                        TextBoxSearchQuery.Text = null;
                    }
                    catch (Exception ex) { MessageBox.Show(this, "There was an issue requesting this file. Make sure it exists on the server you're trying to access.\n\n" + ex.Message); }
                }
                else
                    MessageBox.Show(this, "There was an issue requesting this file. Make sure it exists on the server you're trying to access.");
            else
                QueryFiles();
        }

        private void DataGridFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var webFile = Database.FtpFile(DataGridFiles.CurrentRow.Cells[4].Value.ToString());
                SetStatus(string.Format("Size: {0}, Date Modified: {1}, URL: {2}", webFile.Size, webFile.DateModified.ToString("MM/dd/yyyy HH:mm"), Uri.UnescapeDataString(webFile.URL)));
            }
            else
                SetStatus(string.Format("{0} Files", StringExtensions.FormatNumber(DataGridFiles.Rows.Count.ToString())));
        }
        
        private void DataGridFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Show file details window
            var webFile = Database.FtpFile(DataGridFiles.CurrentRow.Cells[4].Value.ToString());
            ShowFileDetails(webFile, DataGridFiles);
        }

        private void DataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        delegate void QueryFilesCallBack();
        public void QueryFiles()
        {
            Program.log.InfoFormat("Starting query for {0}. Preferences - Sort: {1}, Type: {2}, Host: {3}", TextBoxSearchQuery.Text, SelectedFilesSort.ToString(), SelectedFilesType.ToArray(), SelectedFilesHost);
            Stopwatch stopWatch = new Stopwatch();
            EnableSearchControls(false);
            BackGroundWorker.RunWorkAsync(() => Query.Search(DbOpenFiles, TextBoxSearchQuery.Text, SelectedFilesSort, SelectedFilesType, SelectedFilesHost), (data) =>
            {
                if (InvokeRequired)
                {
                    Invoke(new QueryFilesCallBack(QueryFiles), new object[] { });
                }
                else
                {
                    DataGridFiles.Rows.Clear();
                    ComboBoxHost.Items.Clear(); ComboBoxHost.Items.Add("Any");
                    stopWatch.Start();
                    foreach (var ftpFile in data)
                    {
                        DataGridFiles.Rows.Add(ftpFile.Name, StringExtensions.BytesToPrefix(ftpFile.Size), StringExtensions.TimeSpanAge(ftpFile.DateModified), new Uri(ftpFile.URL).Host, ftpFile.URL);
                        if (!(ComboBoxHost.Items.Contains(new Uri(ftpFile.URL).Host)))
                            ComboBoxHost.Items.Add(new Uri(ftpFile.URL).Host);
                    }

                    stopWatch.Stop();
                    SetStatus(string.Format("Successfully returned files - {0} Files ({1} seconds)", StringExtensions.FormatNumber(DataGridFiles.Rows.Count.ToString()), String.Format("{0:0.000}", stopWatch.Elapsed.TotalSeconds)));
                    stopWatch.Reset();
                    
                    if (DataGridFiles.Rows.Count == 0) LabelNoResultsFound.Visible = true;
                    else LabelNoResultsFound.Visible = false;

                    Program.log.Info(StatusStripStatus.Text);

                    EnableSearchControls(true);

                    // Sets selected item to host
                    if (SelectedFilesHost == "") ComboBoxHost.SelectedIndex = 0;
                    else ComboBoxHost.SelectedItem = SelectedFilesHost;
                }
            }); 
        }

        // Context Menu Items
        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
            Process.Start(URL);
        }

        private void MenuFileViewDetails_Click(object sender, EventArgs e)
        {
            string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
            ShowFileDetails(Database.FtpFile(URL), DataGridFiles);
        }

        private void MenuFileViewWebPage_Click(object sender, EventArgs e)
        {
            Uri URL = new Uri(DataGridFiles.CurrentRow.Cells[4].Value.ToString());
            Process.Start(URL.AbsoluteUri.Remove(URL.AbsoluteUri.Length - URL.Segments.Last().Length));
        }

        private void MenuFileCopyURL_Click(object sender, EventArgs e)
        {
            string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
            Clipboard.SetText(URL);
            MessageBox.Show("Clipboard set to : " + URL);
        }

        /// <summary>
        /// Enable/Disable search controls, to prevent another search process which causes a crash
        /// </summary>
        /// <param name="isEnabled">Enable/Disable Controls</param>
        private void EnableSearchControls(bool isEnabled)
        {
            TextBoxSearchQuery.Enabled = isEnabled;
            ButtonSearchFiles.Enabled = isEnabled;

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
        /// <param name="createNewInstance">Whether to create a new instance</param>
        public void ShowFileDetails(FtpFile File, DataGridView parentDataGrid, bool isLocal = false, bool createNewInstance = true)
        {
            Program.log.Info("Showing file details dialog : " + File.URL);

            if (createNewInstance)
                FormFileDetails = new FileDetailsWindow();

            FormFileDetails.IsLocalFile = isLocal;
            FormFileDetails.ParentDataGrid = parentDataGrid;
            FormFileDetails.CurrentFile = File;

            FormFileDetails.LabelFileName.Text = File.Name;
            FormFileDetails.LabelValueName.Text = File.Name;
            FormFileDetails.LabelValueRefferer.Text = new Uri(File.URL).Host;
            FormFileDetails.InfoFileURL.Text = Uri.UnescapeDataString(File.URL);

            // Builds parts of the URL into a better presented string, simply replaces '/' with '>' and no filename
            var url = new Uri(File.URL);
            var directories = new StringBuilder();
            if (!File.URL.StartsWith(@"C:\")) { directories.Append(new Uri(File.URL).Host); } else { FormFileDetails.LabelValueRefferer.Text = "Local"; } // Appends the Host at the start if not Local, else it will be named 'Local'
                foreach (string path in url.LocalPath.Split('/', '\\'))
                if (!Path.HasExtension(path))
                    directories.Append(path + "> ");
            FormFileDetails.LabelValueDirectory.Text = directories.ToString();

            FormFileDetails.LabelValueSize.Text = StringExtensions.BytesToPrefix(File.Size);
            FormFileDetails.LabelValueAge.Text = StringExtensions.TimeSpanAge(File.DateModified);

            if (!createNewInstance) FormFileDetails.CheckFileEvents();
            else FormFileDetails.ShowDialog(this);

            Program.log.Info("Successfully loaded file details dialog");
        }

        /// <summary>
        /// Set Status Text of ToolStrip
        /// </summary>
        /// <param name="message">Message to be displayed, duh</param>
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
    }
}