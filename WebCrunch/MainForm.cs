using Newtonsoft.Json;
using CButtonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using WebCrunch.Asynchronous;
using WebCrunch.Controls;
using WebCrunch.Extensions;
using WebCrunch.Files;
using WebCrunch.GitHub;
using WebCrunch.Models;

namespace WebCrunch
{
    public partial class MainForm : Form
    {
        public static MainForm form { get; set; } = null; // This is only instance of the main form, set after InitializeComponent()
        public static SplashScreen frmSplashScreen { get; set; } = new SplashScreen(); // Declare Splash Screen (one instance)
        public static FileDetails frmFileDetails { get; set; } = null; // Declare File Details (one instance)

        public MainForm()
        {
            Program.log.Info("Initializing");

            // This adds all the supported file types to one list (There must be a cleaner way, but oh well)
            allFileTypes.AddRange(videoFileTypes); allFileTypes.AddRange(audioFileTypes); allFileTypes.AddRange(bookFileTypes); allFileTypes.AddRange(subtitleFileTypes); allFileTypes.AddRange(torrentFileTypes); allFileTypes.AddRange(softwareFileTypes); allFileTypes.AddRange(otherFileTypes);

            SelectedFilesFileType = allFileTypes; // Set files filter to All

            InitializeComponent(); // Initialize

            form = this; // Set this instance

            lblAboutChangelogVersion.Text = String.Format(lblAboutChangelogVersion.Text, Application.ProductVersion); // Show this version in a Label on the About tab
            
            // Show Splash Screen
            Controls.Add(frmSplashScreen);
            frmSplashScreen.Dock = DockStyle.Fill;
            frmSplashScreen.Location = new Point(0, 0);
            frmSplashScreen.ClientSize = ClientSize;
            frmSplashScreen.BringToFront();
            frmSplashScreen.Show();

            cmboBoxHomeSearch.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxHomeSearch); // Set search engine combobox to fit its contents
            cmboBoxFilesSort.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesSort); // Set files sort combobox to fit its contents

            Program.log.Info("Initialized");
        }

        /// <summary>
        /// Information URLs
        /// </summary>
        public static string urlChangelog = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/CHANGELOG.md";
        public static string urlTermsOfUse = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/TERMSOFUSE.md";
        public static string urlPrivacyPolicy = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/PRIVACYPOLICY.md";

        /// <summary>
        /// Share this app message
        /// </summary>
        public string shareMessage = "Hey%20guys%2C%20I%20found%20a%20brilliant%20way%20to%20find%20Direct%20download%20links%20for%20anything.";

        private void imgShareTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/intent/tweet?hashtags=WebCrunch&original_referer=https%3A%2F%2Fgithub.com/HerbL27/WebCrunch%2F&ref_src=twsrc%5Etfw&text=" + shareMessage + "&tw_p=tweetbutton&url=https%3A%2F%2Fgithub.com/HerbL27/WebCrunch");
        }

        private void imgShareFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/sharer/sharer.php?app_id=248335808680372&kid_directed_site=0&sdk=joey&u=http%3A%2F%2Fgithub.com/HerbL27/WebCrunch%2F&display=popup&ref=plugin&src=share_button");
        }

        // Form events 
        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.log.Info("Loading application");

            LoadSettings();
            CurrentTab = tabHome;
            CurrentTabTitle = titleHome;

            Directory.CreateDirectory(LocalExtensions.pathRoot);
            Directory.CreateDirectory(LocalExtensions.pathData);

            if (LocalExtensions.CheckForInternetConnection())
            {
                BackGroundWorker.RunWorkAsync(() => Updates.CheckForUpdate());
                LoadTopSearches();
                BackGroundWorker.RunWorkAsync(() => DoDatabaseChecks(), CompletedChecks);
            }
            else
            {
                Controls.Remove(frmSplashScreen);
                MessageBox.Show(this, "No Internet connection found. You need to be connected to the Internet to use WebCrunch. Please check your connection and try again.", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Program.log.Info("Loaded application");
        }

        private void CompletedChecks(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadRecentlyAddedFiles(); // Gets ten of the recently added files
            GetDatabaseInfo(); // Get database info and show in form
            Controls.Remove(frmSplashScreen); // Everything's loaded, we're done with the splash screen
            Program.log.Info("Initiated");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.ApplicationExitCall) {
                Properties.Settings.Default.Save();
                // Delete app Data directory if user settings is true
                if (Properties.Settings.Default.clearDataOnClose)
                    if (Directory.Exists(LocalExtensions.pathData))
                        Directory.Delete(LocalExtensions.pathData, true);
            }

            Program.log.Info("Closing");
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e) { } // Fix paint form 

        /* Runs in the background on load event, Checks if database file exists at users data directory, if so whether they're
         * the same size, and downloads the latest one if either returns false */
        private void DoDatabaseChecks()
        {
            Program.log.Info("Checking for database updates");

            if (!FileExtensions.IsLocalAndServerFileSizeEqual(Database.urlOpenDirectories, "open-directories.txt")) {
                using (var client = new WebClient()) { client.DownloadFile(new Uri(Database.urlOpenDirectories), $"{LocalExtensions.pathData}open-directories.txt"); }
                Program.log.Info("open-directories.txt updated");
            }
            dataOpenDirectories.AddRange(File.ReadAllLines($"{LocalExtensions.pathData}open-directories.txt"));

            if (!FileExtensions.IsLocalAndServerFileSizeEqual(Database.urlOpenFiles, "open-files.json")) {
                using (var client = new WebClient()) { client.DownloadFile(new Uri(Database.urlOpenFiles), $"{LocalExtensions.pathData}open-files.json"); }
                Program.log.Info("open-files.json updated");
            }

            // Adds all items in files list, except for the first one (It contains the database info)
            foreach (var item in File.ReadAllLines($"{LocalExtensions.pathData}open-files.json").Skip(1))
                if (TextExtensions.IsValidJSON(item))
                    filesOpenDatabase.Add(JsonConvert.DeserializeObject<WebFile>(item));

            DatabaseInfo = File.ReadLines($"{LocalExtensions.pathData}open-files.json").First(); // Gets first line in database which contains info
        }

        /// <summary>
        /// Declare new lists to store database entries/info
        /// </summary>
        public static List<string> dataOpenDirectories = new List<string>();
        public static List<WebFile> filesOpenDatabase = new List<WebFile>();
        public static string DatabaseInfo { get; set; }

        /// <summary>
        /// Get/Set current tab/title
        /// </summary>
        public TabPage CurrentTab { get; set; }
        public CButton CurrentTabTitle { get; set; }

        private void titleHome_ClickButtonArea(object sender, MouseEventArgs e)
        {
            CurrentTabTitle = (CButton)sender; tab.SelectedTab = tabHome;
        }

        private void titleSearch_ClickButtonArea(object sender, MouseEventArgs e)
        {
            CurrentTabTitle = (CButton)sender; tab.SelectedTab = tabSearch;
        }

        private void titleDiscover_ClickButtonArea(object sender, MouseEventArgs e)
        {
            CurrentTabTitle = (CButton)sender; ShowHosts(); tab.SelectedTab = tabDiscover;
        }

        private void titleSubmit_ClickButtonArea(object sender, MouseEventArgs e)
        {
            CurrentTabTitle = (CButton)sender; tab.SelectedTab = tabSubmit;
        }

        private void titleSettings_ClickButtonArea(object sender, MouseEventArgs e)
        {
            LoadSettings(); CurrentTabTitle = (CButton)sender; tab.SelectedTab = tabSettings;
        }

        private void titleInformation_ClickButtonArea(object sender, MouseEventArgs e)
        {
            CurrentTabTitle = (CButton)sender; tab.SelectedTab = tabInformation;
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets current tab and selects appropriate tab title
            if (tab.SelectedTab == tabHome)
            { CurrentTab = tabHome; ControlExtensions.SelectTabTitle(titleHome); }
            else if (tab.SelectedTab == tabSearch)
            { CurrentTab = tabSearch; ControlExtensions.SelectTabTitle(titleSearch); }
            else if (tab.SelectedTab == tabDiscover)
            { CurrentTab = tabDiscover; ControlExtensions.SelectTabTitle(titleDiscover); }
            else if (tab.SelectedTab == tabSubmit)
            { CurrentTab = tabDiscover; ControlExtensions.SelectTabTitle(titleSubmit); }
            else if (tab.SelectedTab == tabSettings)
            { CurrentTab = tabSettings; ControlExtensions.SelectTabTitle(titleSettings); }
            else if (tab.SelectedTab == tabInformation)
            { CurrentTab = tabInformation; ControlExtensions.SelectTabTitle(titleInformation); }
        }


        /* Home tab */

        /// <summary>
        /// Get database info located on the first line of the file
        /// </summary>
        public void GetDatabaseInfo()
        {
            Program.log.Info("Getting latest database information");

            long totalSize = 0;

            try
            {
                Program.log.Info("Attempting to get absolute total size of all files");

                foreach (var jsonData in filesOpenDatabase)
                    if (jsonData.Size >= 0)
                        totalSize += jsonData.Size;

                lblHomeStatsFiles.Text = String.Format(lblHomeStatsFiles.Text, TextExtensions.GetFormattedNumber(filesOpenDatabase.Count.ToString()), TextExtensions.BytesToString(totalSize), TextExtensions.GetFormattedNumber(dataOpenDirectories.Count.ToString()));

                Program.log.Info("Total size of all files successful");
            }
            catch (Exception ex)
            {
                lblHomeStatsFiles.Text = String.Format(lblHomeStatsFiles.Text, TextExtensions.GetFormattedNumber(filesOpenDatabase.Count.ToString()), TextExtensions.BytesToString(totalSize), TextExtensions.GetFormattedNumber(dataOpenDirectories.Count.ToString()));
                Program.log.Error("Unable to get absolute total size of all files", ex);
            }

            try
            {
                // Database Info 
                if (TextExtensions.IsValidJSON(DatabaseInfo))
                {
                    Program.log.Info("Attempting to get latest database update date");
                    var dataJsonInfo = JsonConvert.DeserializeObject<DatabaseInfo>(DatabaseInfo);
                    lblHomeStatsDatabaseUpdated.Text = String.Format(lblHomeStatsDatabaseUpdated.Text, dataJsonInfo.LastUpdated.ToShortDateString());
                    Program.log.Info("Latest database update date successful");
                }
            }
            catch (Exception ex) { lblHomeStatsDatabaseUpdated.Text = "Updated: n/a"; Program.log.Error("Error getting latest datebase update date", ex); }
        }

        /// <summary>
        /// Gets recently added files in the database by checking if file was uploaded in the last two weeks
        /// </summary>
        public void LoadRecentlyAddedFiles()
        {
            try
            {
                int itemCount = 0;
                var addedHosts = new List<string>();
                Program.log.Info("Attempting to get recently added files");
                var copiedItems = new List<WebFile>(filesOpenDatabase);
                copiedItems.Shuffle();
                foreach (var jsonData in copiedItems)
                    if (DateTime.Today < jsonData.DateUploaded.Date.AddDays(14) && jsonData.Size > 0 && !addedHosts.Contains(jsonData.Host) && itemCount <= 6)
                    {
                        itemCount++;
                        addedHosts.Add(jsonData.Host);
                        dataGridRecentlyAddedFiles.Rows.Add(jsonData.Type, jsonData.Name, TextExtensions.BytesToString(jsonData.Size), TextExtensions.GetTimeAgo(jsonData.DateUploaded), jsonData.Host, jsonData.URL);
                    }

                Program.log.Info("Recently added files successful");
            }
            catch (Exception ex) { lblHeaderRecentlyAddedFiles.Visible = false; splitterHeaderRecentlyAddedFiles.Visible = false; dataGridRecentlyAddedFiles.Visible = false; Program.log.Error("Error getting recently added files", ex); } /* Error occurred, so hide controls/skip... */
        }

        private void dataGridRecentlyAddedFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                ShowFileDetails(Database.FileInfoFromURL(dataGridRecentlyAddedFiles.CurrentRow.Cells[5].Value.ToString()));
        }

        /// <summary>
        /// Powered by the HackerTarget API to get Top Searches from FileChef.com
        /// </summary>
        public void LoadTopSearches()
        {
            try
            {
                Program.log.Info("Attempting to get top searches");
                List<string> listTopSearches = new List<string>();
                var client = new WebClient();
                using (var stream = client.OpenRead(Database.urlTopSearches))
                using (var reader = new StreamReader(stream)) {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        listTopSearches.Add(line);
                }
                listTopSearches.Reverse();
                int count = 0;
                foreach (var tag in listTopSearches)
                    if (count <= 65) {
                        panelTopSearches.Controls.Add(ControlExtensions.AddTopSearchTag(tag, count));
                        count++;
                    }

                // Add Credits Label to end of Top Searches panel
                var a = new Label {
                    Text = "Powered by FileChef",
                    Font = new Font(btnHomeFileType.Font.Name, 9, FontStyle.Regular),
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Margin = new Padding(0, 8, 0, 3),
                    Cursor = Cursors.Hand,
                    Name = "btnFileChef",
                    AutoSize = true,
                };

                a.Click += btnFileChef_Click;
                panelTopSearches.Controls.Add(a);
                Program.log.Info("Top searches returned successful");
            }
            catch (Exception ex) { lblHeaderTopSearches.Visible = false; splitterHeaderTopSearches.Visible = false; panelTopSearches.Visible = false; Program.log.Error("Error getting top searches", ex); } /* Error occurred, so hide controls/skip... */
        }

        private void btnFileChef_Click(object Sender, EventArgs e)
        {
            Process.Start("http://filechef.com/");
        }

        // Filetype to search from Home tab
        private void btnHomeFileType_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxHomeFileType.DroppedDown = true;
        }

        private void cmboBoxHomeFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxHomeFileType.SelectedIndex == -1) SelectedFilesFileType = allFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 0) SelectedFilesFileType = allFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 1) SelectedFilesFileType = videoFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 2) SelectedFilesFileType = audioFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 3) SelectedFilesFileType = bookFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 4) SelectedFilesFileType = subtitleFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 5) SelectedFilesFileType = torrentFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 6) SelectedFilesFileType = softwareFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 7) SelectedFilesFileType = otherFileTypes;

            var startText = btnHomeFileType.Text.Split(':');
            btnHomeFileType.Text = startText[0] + ": " + cmboBoxHomeFileType.GetItemText(cmboBoxHomeFileType.SelectedItem);
            Font myFont = new Font(btnHomeFileType.Font.FontFamily, btnHomeFileType.Font.Size);
            SizeF mySize = btnHomeFileType.CreateGraphics().MeasureString(btnHomeFileType.Text, myFont);
            panelHomeFileType.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
        }
        
        /// <summary>
        /// External search engine URLs
        /// </summary>
        public static string exploreUrlGoogle = "https://google.com/search?q=";
        public static string exploreUrlGoogol = "https://googol.warriordudimanche.net/?q=";
        public static string exploreUrlStartpage = "https://startpage.com/do/dsearch?query=";
        public static string exploreUrlSearx = "https://searx.me/?q=";

        /// <summary>
        /// Selected external search
        /// </summary>
        public static string SelectedFilesSearch { get; set; }

        private void cmboBoxSearchHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxHomeSearch.SelectedIndex == 0 | cmboBoxHomeSearch.SelectedIndex == -1)
                SelectedFilesSearch = exploreUrlGoogle;
            else if (cmboBoxHomeSearch.SelectedIndex == 1)
                SelectedFilesSearch = exploreUrlGoogol;
            else if (cmboBoxHomeSearch.SelectedIndex == 2)
                SelectedFilesSearch = exploreUrlStartpage;
            else if (cmboBoxHomeSearch.SelectedIndex == 3)
                SelectedFilesSearch = exploreUrlSearx;

            Process.Start(SelectedFilesSearch + String.Format("{0} %2B({1}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", txtSearchFilesHome.Text, String.Join("|", SelectedFilesFileType.ToArray()).ToLower()));
        }

        private void bgSearchFilesHome_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtSearchFilesHome.Focus();
        }

        private void txtSearchFilesHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoSearchFilesFromHome();
        }

        private void btnSearchHome_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            DoSearchFilesFromHome();
        }

        private void btnSearchHome_SideImageClicked(object Sender, MouseEventArgs e)
        {
            cmboBoxHomeSearch.DroppedDown = true;
        }

        public void DoSearchFilesFromHome()
        {
            txtSearchFiles.Text = txtSearchFilesHome.Text;

            if (cmboBoxHomeFileType.SelectedIndex == -1) { SelectedFilesFileType = allFileTypes; ControlExtensions.SelectFilesTab(titleFilesAll); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 0) { SelectedFilesFileType = allFileTypes; ControlExtensions.SelectFilesTab(titleFilesAll); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 1) { SelectedFilesFileType = videoFileTypes; ControlExtensions.SelectFilesTab(titleFilesVideo); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 2) { SelectedFilesFileType = audioFileTypes; ControlExtensions.SelectFilesTab(titleFilesAudio); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 3) { SelectedFilesFileType = bookFileTypes; ControlExtensions.SelectFilesTab(titleFilesBooks); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 4) { SelectedFilesFileType = subtitleFileTypes; ControlExtensions.SelectFilesTab(titleFilesSubtitles); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 5) { SelectedFilesFileType = torrentFileTypes; ControlExtensions.SelectFilesTab(titleFilesTorrents); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 7) { SelectedFilesFileType = softwareFileTypes; ControlExtensions.SelectFilesTab(titleFilesSoftware); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 8) { SelectedFilesFileType = otherFileTypes; ControlExtensions.SelectFilesTab(titleFilesOther); SelectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(SelectedFiles); }
        }


        /* Search files tab */

        // Supported file extensions, must match the same as the ones in the crawler
        public static List<string> allFileTypes = new List<string>();
        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> bookFileTypes = new List<string>() { "MOBI", "CBZ", "CBR", "CBC", "CHM", "EPUB", "FB2", "LIT", "LRF", "ODT", "PDF", "PRC", "PDB", "PML", "RB", "RTF", "TCR", "DOC", "DOCX" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA", "AC3", "OGG", "FLAC", "M4A" };
        public static List<string> softwareFileTypes = new List<string>() { "EXE", "VOB", "ZIP", "TAR", "RAR", "7Z", "ISO", "PKG", "TAR.GZ", "APK", "IPA", "APPX", "XAP" };
        public static List<string> torrentFileTypes = new List<string>() { "TORRENT" };
        public static List<string> subtitleFileTypes = new List<string>() { "SRT", "SUB", "VTT" };
        public static List<string> otherFileTypes = new List<string>() { "JSP", "PL", "PHP", "HTML", "ASPX", "XML", "TXT", "SQL", "CSV" };

        // Filter Preferences
        public static List<WebFile> SelectedFiles { get; set; } = filesOpenDatabase;
        public List<string> SelectedFilesFileType { get; set; } = allFileTypes;
        public string SelectedFilesHost { get; set; } = "";

        /// <summary>
        /// Gets local files (supported in this app) from user's /Downloads directory
        /// </summary>
        /// <returns>Local files from /Downloads as a WebFile</returns>
        public List<WebFile> LocalFiles()
        {
            Program.log.Info("Getting users local files");
            var filesLocal = new List<WebFile>();
            foreach (var pathFile in Directory.GetFiles(LocalExtensions.userDownloadsDirectory))
                filesLocal.Add(new WebFile(
                    Path.GetExtension(pathFile).Replace(".", "").ToUpper(),
                    Path.GetFileNameWithoutExtension(pathFile),
                    new FileInfo(pathFile).Length,
                    File.GetCreationTime(pathFile),
                    "Local",
                    pathFile));

            Program.log.Info("Users local files successful");
            return filesLocal;
        }

        /// <summary>
        /// Load bookmarked files from file
        /// </summary>
        /// <returns>Bookmark item as a WebFile</returns>
        public List<WebFile> BookmarkFiles()
        {
            Program.log.Info("Getting users bookmarks files");
            var filesBookmarks = new List<WebFile>();
            if (File.Exists(LocalExtensions.pathDataBookmarked))
                using (StreamReader reader = new StreamReader(LocalExtensions.pathDataBookmarked))
                    while (!reader.EndOfStream)
                        try {
                            var jsonData = JsonConvert.DeserializeObject<Bookmark>(reader.ReadLine());
                            filesBookmarks.Add(Database.FileInfoFromURL(jsonData.URL));
                        }
                        catch (Exception ex) {
                            Program.log.Error("Users saved files error", ex);
                        }

            Program.log.Info("Users bookmarks successful");
            return filesBookmarks;
        }

        // Select file type category
        private void titleFilesAll_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = allFileTypes; ControlExtensions.SelectFilesTab(titleFilesAll); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesVideo_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = videoFileTypes; ControlExtensions.SelectFilesTab(titleFilesVideo); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesAudio_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = audioFileTypes; ControlExtensions.SelectFilesTab(titleFilesAudio); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesBooks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = bookFileTypes; ControlExtensions.SelectFilesTab(titleFilesBooks); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesSubtitles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = subtitleFileTypes; ControlExtensions.SelectFilesTab(titleFilesSubtitles); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesTorrents_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = torrentFileTypes; ControlExtensions.SelectFilesTab(titleFilesTorrents); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesSoftware_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = softwareFileTypes; ControlExtensions.SelectFilesTab(titleFilesSoftware); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesOther_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = otherFileTypes; ControlExtensions.SelectFilesTab(titleFilesOther); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesCustom_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            string getUserResponse = Microsoft.VisualBasic.Interaction.InputBox("File Type/Extensions (enter only one extension):", "Custom*", "e.g. MP4");
            string userResponse = getUserResponse.Replace(".", "");
            if (userResponse != "")
                SelectedFilesFileType = new List<string>() { userResponse.ToUpper() }; ControlExtensions.SelectFilesTab(titleFilesCustom); SelectedFiles = filesOpenDatabase; ShowFiles(SelectedFiles);
        }

        private void titleFilesLocal_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = allFileTypes; ControlExtensions.SelectFilesTab(titleFilesLocal); SelectedFiles = LocalFiles(); ShowFiles(SelectedFiles);
        }

        private void titleFilesBookmarks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            SelectedFilesFileType = allFileTypes; ControlExtensions.SelectFilesTab(titleFilesBookmarks); SelectedFiles = BookmarkFiles(); ShowFiles(SelectedFiles);
        }

        // Files dataGridView click event for item, will get the last (hidden) item (the URL) in the selected row and get WebFile from the URL
        private void dataGridFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var URL = dataGridFiles.CurrentRow.Cells[5].Value.ToString();

            if (e.RowIndex != -1)
                if (dataGridFiles.CurrentRow.Cells[4].Value.ToString() == "Local")
                    ShowFileDetails(new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), new FileInfo(URL).Length, File.GetCreationTime(URL), "Local", URL));
                else
                    ShowFileDetails(Database.FileInfoFromURL(URL));
        }

        private void dataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        Stopwatch stopWatch = new Stopwatch();

        delegate void loadFilesCallBack(List<WebFile> dataFiles, SortBy order = SortBy.Name);
        public void ShowFiles(List<WebFile> dataFiles, SortBy order = SortBy.Name)
        {
            if (order == SortBy.Name) SortFiles.ByName(dataFiles);
            else if (order == SortBy.Size) SortFiles.BySize(dataFiles);
            else if (order == SortBy.Date) SortFiles.ByDate(dataFiles);

            Program.log.Info("Searching files started");
            imgSearch.Image = Properties.Resources.loader;
            BackGroundWorker.RunWorkAsync<List<WebFile>>(() => SearchFiles(dataFiles), (data) =>
            {
                if (tabSearch.InvokeRequired)
                {
                    loadFilesCallBack b = new loadFilesCallBack(ShowFiles);
                    Invoke(b, new object[] { dataFiles });
                }
                else
                {
                    dataGridFiles.Rows.Clear();

                    cmboBoxFilesHost.Items.Clear(); cmboBoxFilesHost.Items.Add("Any");

                    stopWatch.Start();

                    foreach (var jsonData in data)
                    {
                        dataGridFiles.Rows.Add(jsonData.Type, jsonData.Name, TextExtensions.BytesToString(jsonData.Size), TextExtensions.GetTimeAgo(jsonData.DateUploaded), jsonData.Host, jsonData.URL);
                        if (!(cmboBoxFilesHost.Items.Contains(jsonData.Host)))
                            cmboBoxFilesHost.Items.Add(jsonData.Host);
                    }

                    stopWatch.Stop(); TimeSpan ts = stopWatch.Elapsed;
                    lblFilesResultsInfo.Text = TextExtensions.GetFormattedNumber(dataGridFiles.Rows.Count.ToString()) + " / " + TextExtensions.GetFormattedNumber(dataFiles.Count.ToString()) + " Files (" + String.Format("{0:0.000}", ts.TotalSeconds) + " Seconds)"; stopWatch.Reset();

                    tab.SelectedTab = CurrentTab;

                    cmboBoxFilesHost.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesHost);

                    imgSearch.Image = Properties.Resources.magnify_orange;

                    if (dataGridFiles.Rows.Count == 0) emptyDataFiles.Visible = true;
                    else emptyDataFiles.Visible = false;

                    Program.log.Info("Successfully returned search results");
                }
            }); 
        }

        object loadFilesLock = new object();
        public List<WebFile> SearchFiles(List<WebFile> dataFiles)
        {
            lock (loadFilesLock) {
                List<WebFile> urls = new List<WebFile>();
                foreach (var file in dataFiles)
                    if (TextExtensions.ContainsAll(file.Name.ToLower(), TextExtensions.GetWords(txtSearchFiles.Text.ToLower())) && SelectedFilesFileType.Contains(file.Type) && file.Host.Contains(SelectedFilesHost))
                        urls.Add(new WebFile(file.Type, file.Name, file.Size, file.DateUploaded, file.Host, file.URL));

                return urls;
            }
        }

        // Show file details with the specified parameters
        public void ShowFileDetails(WebFile file, bool createNewInstance = true)
        {
            Program.log.Info("Attempting to show file details dialog  : " + file.URL);

            if (createNewInstance)
                frmFileDetails = new FileDetails();

            frmFileDetails.currentFile = file;
            frmFileDetails.infoFileName.Text = file.Name;
            frmFileDetails.infoName.Text = file.Name;
            frmFileDetails.infoReferrer.Text = file.Host;
            frmFileDetails.infoType.Text = file.Type;
            frmFileDetails.infoFileURL.Text = file.URL;

            // Build all parts of the URL into a better looking string
            var url = new Uri(file.URL);
            var directories = new StringBuilder(file.Host);
            foreach (string path in url.LocalPath.Split('/'))
                if (!Path.HasExtension(path))
                    directories.Append(path + "> ");

            frmFileDetails.infoDirectory.Text = directories.ToString();
            frmFileDetails.infoSize.Text = TextExtensions.BytesToString(file.Size);
            frmFileDetails.infoAge.Text = TextExtensions.GetTimeAgo(file.DateUploaded);

            frmFileDetails.Dock = DockStyle.Fill;
            if (!createNewInstance) frmFileDetails.CheckFileEvents();
            if (createNewInstance) { tabBlank.Controls.Clear(); tabBlank.Controls.Add(frmFileDetails); }
            tab.SelectedTab = tabBlank;

            Program.log.Info("Successfully loaded file details dialog");
        }

        // Sort Files
        private void btnFilesSort_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesSort.DroppedDown = true;
        }

        private void cmboBoxFilesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgSearch.Image = Properties.Resources.loader;

            if (cmboBoxFilesSort.SelectedIndex == 0)
                ShowFiles(SelectedFiles, SortBy.Name);
            else if (cmboBoxFilesSort.SelectedIndex == 1)
                ShowFiles(SelectedFiles, SortBy.Size);
            else if (cmboBoxFilesSort.SelectedIndex == 2)
                ShowFiles(SelectedFiles, SortBy.Date);

            var startText = btnFilesSort.Text.Split(':');
            btnFilesSort.Text = startText[0] + ": " + cmboBoxFilesSort.GetItemText(cmboBoxFilesSort.SelectedItem);
            Font myFont = new Font(btnFilesSort.Font.FontFamily, btnFilesSort.Font.Size);
            SizeF mySize = btnFilesSort.CreateGraphics().MeasureString(btnFilesSort.Text, myFont);
            panelFilesSort.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);

            imgSearch.Image = Properties.Resources.magnify_orange;
        }

        // Filter Files by Host
        private void btnFilesHost_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesHost.DroppedDown = true;
        }

        private void btnFilesBackToSearch_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            tab.SelectedTab = tabSearch;
        }

        private void cmboBoxFilesHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgSearch.Image = Properties.Resources.loader;
            var startText = btnFilesHost.Text.Split(':');
            btnFilesHost.Text = startText[0] + ": " + cmboBoxFilesHost.GetItemText(cmboBoxFilesHost.SelectedItem);
            var myFont = new Font(btnFilesHost.Font.FontFamily, this.btnFilesHost.Font.Size);
            var mySize = btnFilesHost.CreateGraphics().MeasureString(btnFilesHost.Text, myFont);
            panelFilesHost.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxFilesHost.SelectedIndex == 0) SelectedFilesHost = "";
            else SelectedFilesHost = cmboBoxFilesHost.SelectedItem.ToString();
            ShowFiles(SelectedFiles);
            cmboBoxFilesHost.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesHost);
        }

        private void bgSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtSearchFiles.Focus();
        }

        private void txtSearchFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchFiles();
        }

        private void imgSearch_Click(object sender, EventArgs e)
        {
            SearchFiles();
        }

        public void SearchFiles()
        {
            imgSearch.Image = Properties.Resources.loader;
            tab.SelectedTab = tabSearch;

            if (Path.HasExtension(txtSearchFiles.Text))
            {
                ShowFileDetails(Database.FileInfoFromURL(txtSearchFiles.Text));
                imgSearch.Image = Properties.Resources.magnify_orange;
            }
            else
                ShowFiles(SelectedFiles);
        }


        /* Discover tab */

        private void dataGridDiscover_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(dataGridDiscover.CurrentRow.Cells[3].Value.ToString());
        }

        delegate void loadHostsCallBack();
        private void ShowHosts()
        {
            Program.log.Info("Attempting to load and file hosts/servers");

            BackGroundWorker.RunWorkAsync<List<string>>(() => GetFileHosts(), (data) => {
                if (tabDiscover.InvokeRequired) {
                    loadHostsCallBack b = new loadHostsCallBack(ShowHosts);
                    Invoke(b, new object[] { });
                }
                else {
                    dataGridDiscover.Rows.Clear();

                    int count = 1;
                    foreach (string url in data) {
                        dataGridDiscover.Rows.Add(count.ToString(), url, "Web", url);
                        count += 1;
                    }

                    tab.SelectedTab = CurrentTab;
                }
            });

            Program.log.Info("Successfully loaded hosts/servers");
        }

        object loadHostsLock = new object();
        private List<string> GetFileHosts()
        {
            lock (loadHostsLock) {
                List<string> urls = new List<string>();
                foreach (string file in dataOpenDirectories)
                    if (!urls.Contains(new Uri(file.Replace("www.", "")).GetLeftPart(UriPartial.Scheme) + new Uri(file.Replace("www.", "")).Authority))
                        urls.Add(new Uri(file.Replace("www.", "")).GetLeftPart(UriPartial.Scheme) + new Uri(file.Replace("www.", "")).Authority);

                return urls;
            }
        }


        /* Submit tab */

        private void btnSubmitUrl_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (txtSubmitLink.Text != "") 
                if (!Path.HasExtension(txtSubmitLink.Text)) 
                    if (Uri.IsWellFormedUriString(txtSubmitLink.Text, UriKind.Absolute)) {
                        string formattedText = txtSubmitLink.Text;
                        if (!txtSubmitLink.Text.EndsWith("/"))
                            formattedText = txtSubmitLink.Text + "/";
                        OpenLink.SubmitLink(new Uri(formattedText)); txtSubmitLink.Text = "";
                    }
                    else MessageBox.Show(this, "This isn't a public web directory.");
                else MessageBox.Show(this, "This isn't a public web directory.");
        }


        /* About tab */

        private void lblAboutReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start($"{OpenLink.urlGitHub}issues/new");
        }

        private void btnAboutTermsOfUse_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label; ControlExtensions.ShowTextFromURL(urlTermsOfUse, lbl.Text);
        }

        private void btnAboutPrivacyPolicy_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label; ControlExtensions.ShowTextFromURL(urlPrivacyPolicy, lbl.Text);
        }

        private void lblAboutChangelogVersion_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label; ControlExtensions.ShowTextFromURL(urlChangelog, lbl.Text);
        }


        /* Settings tab */

        public void LoadSettings()
        {
            // Set UI Properties
            chkSettingsClearData.Checked = Properties.Settings.Default.clearDataOnClose;
        }

        private void btnSettingsSave_ClickButtonArea(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.clearDataOnClose = chkSettingsClearData.Checked;
            Thread.Sleep(500);
            Properties.Settings.Default.Save();
            Thread.Sleep(500);

            Program.log.Info("Successfully saved all user settings");
        }

        private void btnSettingsRestoreDefault_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Properties.Settings.Default.clearDataOnClose = false;
            Thread.Sleep(500);
            LoadSettings();
            Thread.Sleep(500);

            Program.log.Info("Successfully restored all user settings");
        }
    }
}