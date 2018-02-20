using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Text;
using Newtonsoft.Json;
using CButtonLib;
using WebCrunch.Models;
using WebCrunch.Controls;
using WebCrunch.Files;
using WebCrunch.Extensions;
using WebCrunch.Utilities;
using WebCrunch.Asynchronous;
using WebCrunch.GitHub;
using WebCrunch.Dialogs;

namespace WebCrunch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Program.log.Info("Initializing");
            /* This adds all the supported file types to one list (There must be a cleaner way, but oh well) */
            allFileTypes.AddRange(videoFileTypes); allFileTypes.AddRange(audioFileTypes); allFileTypes.AddRange(bookFileTypes); allFileTypes.AddRange(subtitleFileTypes); allFileTypes.AddRange(torrentFileTypes); allFileTypes.AddRange(softwareFileTypes); allFileTypes.AddRange(otherFileTypes);
            selectedFilesFileType = allFileTypes; /* Set files filter to All */
            InitializeComponent(); /* Initialize */
            lblAboutChangelogVersion.Text = String.Format(lblAboutChangelogVersion.Text, Application.ProductVersion); /* Show this version in a Label on the About tab */
            form = this; /* Set this instance */
            /* Shows Splash Screen */
            frmSplash = new SplashScreen();
            Controls.Add(frmSplash);
            frmSplash.Dock = DockStyle.Fill;
            frmSplash.Location = new Point(0, 0);
            frmSplash.ClientSize = ClientSize;
            frmSplash.BringToFront();
            frmSplash.Show();
            cmboBoxHomeSearch.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxHomeSearch); /* Set search engine combobox to fit its contents */
            cmboBoxFilesSort.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesSort); /* Set files sort combobox to fit its contents */
            Program.log.Info("Initialized");
        }

        public static MainForm form = null; /* For access in other classes */
        public SplashScreen frmSplash; /* Declare Splash Screen (one instance) */
        public FileDetails fileDetails; /* Declare File Details (one instance) */
        protected override void OnPaint(PaintEventArgs e) { } /* Fix paint form */

        /* Supported media players */
        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public static string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public static string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public static string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";

        /* Get URLs for databases */
        public static string urlOpenFiles = "https://dl.dropbox.com/s/charfmjveo2v1h3/open-files.json?dl=0";
        public static string urlTopSearches = "https://dl.dropbox.com/s/512qe4ogan92vea/top-searches.txt?dl=0";
        public static string urlOpenDirectories = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/api/open-directories.txt";

        /* Used directories */
        public static string pathRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WebCrunch\";
        public static string pathData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WebCrunch\Data\";
        public static string pathDataBookmarked = pathRoot + "bookmarked-files.json";
        public static string userDownloadsDirectory = KnownFolders.GetPath(KnownFolder.Downloads) + @"\";

        /* Update URLs */
        public static string urlLatestVersion = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/WebCrunch/current-version.txt";
        public static string GetUrlLatestUpdater(Version newVersion) { return urlGitHub + "releases/download/" + newVersion.ToString() + "/Update.exe"; }

        /* Miscellaneous URLs */
        public static string urlChangelog = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/CHANGELOG.md";
        public static string urlTermsOfUse = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/TERMSOFUSE.md";
        public static string urlPrivacyPolicy = "https://raw.githubusercontent.com/HerbL27/WebCrunch/master/PRIVACYPOLICY.md";
        public static string urlGitHub = "https://github.com/HerbL27/WebCrunch/";

        WebClient client = new WebClient(); // public reusable web client

        /* Share this app */
        public string shareMessage = "Hey%20guys%2C%20I%20found%20a%20brilliant%20way%20to%20find%20Direct%20download%20links%20for%20anything.";

        private void imgShareTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/intent/tweet?hashtags=WebCrunch&original_referer=https%3A%2F%2Fgithub.com/HerbL27/WebCrunch%2F&ref_src=twsrc%5Etfw&text=" + shareMessage + "&tw_p=tweetbutton&url=https%3A%2F%2Fgithub.com/HerbL27/WebCrunch");
        }

        private void imgShareFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/sharer/sharer.php?app_id=248335808680372&kid_directed_site=0&sdk=joey&u=http%3A%2F%2Fgithub.com/HerbL27/WebCrunch%2F&display=popup&ref=plugin&src=share_button");
        }

        /* Form events */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.ApplicationExitCall) {
                Properties.Settings.Default.Save();
                /* Delete Data directory */
                if (Properties.Settings.Default.clearDataOnClose)
                    if (Directory.Exists(pathData))
                        Directory.Delete(pathData, true);
            }

            Program.log.Info("Closing");
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.log.Info("Loading application");

            LoadSettings();
            currentTab = tabHome;
            currentTabTitle = titleHome;

            Directory.CreateDirectory(pathRoot);
            Directory.CreateDirectory(pathData);

            if (LocalExtensions.CheckForInternetConnection()) {
                BackGroundWorker.RunWorkAsync(() => Updates.CheckForUpdate());
                LoadTopSearches();
                BackGroundWorker.RunWorkAsync(() => DoDatabaseChecks(), CompletedChecks);
            }
            else
            {
                Controls.Remove(frmSplash);
                ShowStartupError("No Internet connection found. You need to be connected to the Internet to use WebCrunch. Please check your connection and try again.");
            }

            Program.log.Info("Loaded application");
        }

        private void CompletedChecks(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadRecentlyAddedFiles(); /* Gets ten of the recently added files */
            GetDatabaseInfo(); /* Get database info and show in form */
            Controls.Remove(frmSplash); /* Everything's loaded, we're done with the splash screen */
            Program.log.Info("Initiated");
        }

        /* Runs in the background on startup */
        private void DoDatabaseChecks()
        {
            Program.log.Info("Checking for database updates");

            /* Checks if database file exists at users data directory, if so whether they're the same size, and downloads the latest one if either returns false */
            if (!FileExtensions.IsLocalAndServerFileSizeEqual(urlOpenDirectories, "open-directories.txt")) {
                client.DownloadFile(new Uri(urlOpenDirectories), pathData + "open-directories.txt");
                Program.log.Info("open-directories.txt updated");
            }
            dataOpenDirectories.AddRange(File.ReadAllLines(pathData + "open-directories.txt"));

            if (!FileExtensions.IsLocalAndServerFileSizeEqual(urlOpenFiles, "open-files.json")) {
                client.DownloadFile(new Uri(urlOpenFiles), pathData + "open-files.json");
                Program.log.Info("open-files.json updated");
            }

            /* Adds all items in files list, except for the first one (It contains the database info) */
            foreach (var item in File.ReadAllLines(pathData + "open-files.json").Skip(1))
                if (TextExtensions.IsValidJSON(item))
                    filesOpenDatabase.Add(JsonConvert.DeserializeObject<WebFile>(item));

            databaseInfo = File.ReadLines(pathData + "open-files.json").First(); /* Gets first line in database which contains info */
        }

        /// <summary>
        /// Shows Message and Restart Button on Home tab if no connection established (WIP/TO-DO) */
        /// </summary>
        /// <param name="errorText"></param>
        public void ShowStartupError(string errorText)
        {
            ErrorInfo a = new ErrorInfo {
                BackColor = tabHome.BackColor,
                Dock = DockStyle.Fill
            };

            a.titleStatus.Text = errorText;
            a.Show();
            panelTitles.Enabled = false;
            tabHome.Controls.Clear();
            tabHome.Padding = new Padding(0, 0, 0, 0);
            tabHome.Controls.Add(a);
        }

        /* Focus effect for Button/Combobox */
        Bitmap tmpButtonImage = null;

        public void BtnCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            tmpButtonImage = (Bitmap)ctrl.Image;
            if (ctrl.Image != null) { ctrl.Image = ImageExtensions.ChangeColor((Bitmap)ctrl.Image, Color.White); }
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Color.White;
            ctrl.ColorFillSolid = Colors.uiColorOrange;
        }

        public void BtnCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.Image = tmpButtonImage;
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Colors.uiColorOrange;
            ctrl.ColorFillSolid = Color.Transparent;
        }

        public void ComboboxCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorOrange;
            ctrl.ForeColor = Color.White;
            ctrl.ColorFillSolid = Colors.uiColorOrange;
        }

        public void ComboboxCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Colors.uiColorGray;
            ctrl.ForeColor = Colors.uiColorGray;
            ctrl.ColorFillSolid = Color.Transparent;
        }

        /* Focus effect for Social images */
        Bitmap tmpSocialImage = null;

        public void Image_MouseEnter(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox;
            tmpSocialImage = (Bitmap)ctrl.Image;
            ctrl.Image = ImageExtensions.ChangeColor((Bitmap)ctrl.Image, Colors.uiColorOrange);
        }

        public void Image_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox; ctrl.Image = tmpSocialImage;
        }

        /* Declare new lists */
        public static List<string> dataOpenDirectories = new List<string>();
        public static List<WebFile> filesOpenDatabase = new List<WebFile>();
        public static string databaseInfo;

        /* Core Tabs */
        public TabPage currentTab;
        public CButton currentTabTitle;

        private void titleHome_ClickButtonArea(object sender, MouseEventArgs e)
        {
            currentTabTitle = (CButton)sender; tab.SelectedTab = tabHome;
        }

        private void titleSearch_ClickButtonArea(object sender, MouseEventArgs e)
        {
            currentTabTitle = (CButton)sender; tab.SelectedTab = tabSearch;
        }

        private void titleDiscover_ClickButtonArea(object sender, MouseEventArgs e)
        {
            currentTabTitle = (CButton)sender; ShowHosts(); tab.SelectedTab = tabDiscover;
        }

        private void titleSubmit_ClickButtonArea(object sender, MouseEventArgs e)
        {
            currentTabTitle = (CButton)sender; tab.SelectedTab = tabSubmit;
        }

        private void titleSettings_ClickButtonArea(object sender, MouseEventArgs e)
        {
            LoadSettings(); currentTabTitle = (CButton)sender; tab.SelectedTab = tabSettings;
        }

        private void titleInformation_ClickButtonArea(object sender, MouseEventArgs e)
        {
            currentTabTitle = (CButton)sender; tab.SelectedTab = tabInformation;
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab.SelectedTab == tabHome)
            { currentTab = tabHome; SelectTabTitle(titleHome); }
            else if (tab.SelectedTab == tabSearch)
            { currentTab = tabSearch; SelectTabTitle(titleSearch); }
            else if (tab.SelectedTab == tabDiscover)
            { currentTab = tabDiscover; SelectTabTitle(titleDiscover); }
            else if (tab.SelectedTab == tabSubmit)
            { currentTab = tabDiscover; SelectTabTitle(titleSubmit); }
            else if (tab.SelectedTab == tabSettings)
            { currentTab = tabSettings; SelectTabTitle(titleSettings); }
            else if (tab.SelectedTab == tabInformation)
            { currentTab = tabInformation; SelectTabTitle(titleInformation); }
        }

        /* Sets selected tab style to title /*/
        public void SelectTabTitle(CButton cbtn)
        {
            titleHome.ColorFillSolid = Colors.nonSelectedTitleRGB;
            titleHome.BorderColor = Colors.nonSelectedTitleRGB;
            titleHome.BackColor = Colors.nonSelectedTitleRGB;
            titleSearch.ColorFillSolid = Colors.nonSelectedTitleRGB;
            titleSearch.BorderColor = Colors.nonSelectedTitleRGB;
            titleSearch.BackColor = Colors.nonSelectedTitleRGB;
            titleDiscover.ColorFillSolid = Colors.nonSelectedTitleRGB;
            titleDiscover.BorderColor = Colors.nonSelectedTitleRGB;
            titleDiscover.BackColor = Colors.nonSelectedTitleRGB;
            titleSubmit.ColorFillSolid = Colors.nonSelectedTitleRGB;
            titleSubmit.BorderColor = Colors.nonSelectedTitleRGB;
            titleSubmit.BackColor = Colors.nonSelectedTitleRGB;
            titleSettings.ColorFillSolid = Colors.nonSelectedTitleRGB;
            titleSettings.BorderColor = Colors.nonSelectedTitleRGB;
            titleSettings.BackColor = Colors.nonSelectedTitleRGB;
            titleInformation.ColorFillSolid = Colors.nonSelectedTitleRGB;
            titleInformation.BorderColor = Colors.nonSelectedTitleRGB;
            titleInformation.BackColor = Colors.nonSelectedTitleRGB;

            cbtn.ColorFillSolid = Colors.selectedTitleRGB;
            cbtn.BorderColor = Colors.selectedTitleRGB;
            cbtn.BackColor = Colors.selectedTitleRGB;
        }

        /* Home tab */
        public void GetDatabaseInfo()
        {
            Program.log.Info("Getting latest database information");

            long totalSize = 0;

            try {
                Program.log.Info("Attempting to get absolute total size of all files");

                foreach (var jsonData in filesOpenDatabase)
                    if (jsonData.Size >= 0)
                        totalSize += jsonData.Size;

                var lineCount = File.ReadLines(pathData + "open-directories.txt").Count();
                lblHomeStatsFiles.Text = String.Format(lblHomeStatsFiles.Text, TextExtensions.GetFormattedNumber(filesOpenDatabase.Count.ToString()), TextExtensions.BytesToString(totalSize), TextExtensions.GetFormattedNumber(lineCount.ToString()));

                Program.log.Info("Total size of all files successful");
            }
            catch (Exception ex) {
                lblHomeStatsFiles.Text = String.Format(lblHomeStatsFiles.Text, TextExtensions.GetFormattedNumber(filesOpenDatabase.Count.ToString()), TextExtensions.BytesToString(totalSize), TextExtensions.GetFormattedNumber(dataOpenDirectories.Count.ToString()));
                Program.log.Error("Unable to get absolute total size of all files", ex);
            }

            try
            {
                /* Database Info */
                if (TextExtensions.IsValidJSON(databaseInfo)) {
                    Program.log.Info("Attempting to get latest database update date");
                    var dataJsonInfo = JsonConvert.DeserializeObject<DatabaseInfo>(databaseInfo);
                    lblHomeStatsDatabaseUpdated.Text = String.Format(lblHomeStatsDatabaseUpdated.Text, dataJsonInfo.LastUpdated.ToShortDateString());
                    Program.log.Info("Latest database update date successful");
                }
            }
            catch (Exception ex) { lblHomeStatsDatabaseUpdated.Text = "Updated: n/a"; Program.log.Error("Error getting latest datebase update date", ex); }
        }

        public void LoadRecentlyAddedFiles()
        {
            try
            {
                int itemCount = 0;
                var addedHosts = new List<string>();
                Program.log.Info("Attempting to get recently added files");
                var copiedItems = new List<WebFile>(filesOpenDatabase);
                copiedItems.Shuffle();
                foreach (var jsonData in copiedItems.GetRange(2, copiedItems.Count / 4))
                    if (DateTime.Today < jsonData.DateUploaded.Date.AddDays(14)) /* Check if file was uploaded in the last two weeks */
                        if (jsonData.Size > 0) /* Check if file size is not zero */
                            if (!addedHosts.Contains(jsonData.Host))
                                if (itemCount <= 6)
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
                using (var stream = client.OpenRead(urlTopSearches))
                using (var reader = new StreamReader(stream)) {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        listTopSearches.Add(line);
                }
                listTopSearches.Reverse();
                int count = 0;
                foreach (var tag in listTopSearches)
                    if (count <= 65) {
                        AddTopSearchTag(tag, count);
                        count++;
                    }

                /* Add Credits Label to end of Top Searches */
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

        /* Add top search item to panel */
        public void AddTopSearchTag(string text, int count)
        {
            var a = new CButton {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(btnHomeFileType.Font.Name, 9.25F, FontStyle.Regular),
                Size = new Size(70, 24),
                BackColor = Color.Transparent,
                ForeColor = Colors.uiColorOrange,
                TextMargin = new Padding(0, 2, 0, 2),
                BorderColor = Colors.uiColorOrange,
                ColorFillSolid = Color.Transparent,
                FillType = CButton.eFillType.Solid,
                TextShadowShow = false,
                ShowFocus = CButton.eFocus.None,
                Margin = new Padding(0, 3, 6, 3),
                BorderShow = true,
                DimFactorClick = 0,
                DimFactorHover = 0,
                Cursor = Cursors.Hand,
                Name = "tagItem" + count,
                Corners = new CornersProperty(2),
            };

            var myFont = new Font(a.Font.FontFamily, a.Font.Size);
            var mySize = a.CreateGraphics().MeasureString(a.Text, myFont);
            a.Width = (((int)(Math.Round(mySize.Width, 0))) + 10);
            a.ClickButtonArea += btnTopSearchesTag_ClickButtonArea;
            a.MouseEnter += BtnCButton_MouseEnter;
            a.MouseLeave += BtnCButton_MouseLeave;
            panelTopSearches.Controls.Add(a);
        }

        private void btnTopSearchesTag_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            var tagItem = Sender as CButton;
            txtSearchFilesHome.Text = tagItem.Text;
            DoSearchFilesFromHome();
        }

        private void btnHomeFileType_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxHomeFileType.DroppedDown = true;
        }

        private void cmboBoxHomeFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxHomeFileType.SelectedIndex == -1) selectedFilesFileType = allFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 0) selectedFilesFileType = allFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 1) selectedFilesFileType = videoFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 2) selectedFilesFileType = audioFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 3) selectedFilesFileType = bookFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 4) selectedFilesFileType = subtitleFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 5) selectedFilesFileType = torrentFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 6) selectedFilesFileType = softwareFileTypes;
            else if (cmboBoxHomeFileType.SelectedIndex == 7) selectedFilesFileType = otherFileTypes;

            var startText = btnHomeFileType.Text.Split(':');
            btnHomeFileType.Text = startText[0] + ": " + cmboBoxHomeFileType.GetItemText(cmboBoxHomeFileType.SelectedItem);
            Font myFont = new Font(btnHomeFileType.Font.FontFamily, btnHomeFileType.Font.Size);
            SizeF mySize = btnHomeFileType.CreateGraphics().MeasureString(btnHomeFileType.Text, myFont);
            panelHomeFileType.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
        }

        /* Supported file extensions by type */
        public static List<string> allFileTypes = new List<string>();
        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> bookFileTypes = new List<string>() { "MOBI", "CBZ", "CBR", "CBC", "CHM", "EPUB", "FB2", "LIT", "LRF", "ODT", "PDF", "PRC", "PDB", "PML", "RB", "RTF", "TCR", "DOC", "DOCX" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA", "AC3", "OGG", "FLAC", "M4A" };
        public static List<string> softwareFileTypes = new List<string>() { "EXE", "VOB", "ZIP", "TAR", "RAR", "7Z", "ISO", "PKG", "TAR.GZ", "APK", "IPA", "APPX", "XAP" };
        public static List<string> torrentFileTypes = new List<string>() { "TORRENT" };
        public static List<string> subtitleFileTypes = new List<string>() { "SRT", "SUB", "VTT" };
        public static List<string> otherFileTypes = new List<string>() { "JSP", "PL", "PHP", "HTML", "ASPX", "XML", "TXT", "SQL", "CSV" };

        /* Filter Preferences */
        public static List<WebFile> selectedFiles = filesOpenDatabase;
        public List<string> selectedFilesFileType = allFileTypes;
        public string selectedFilesHost = "";

        public List<WebFile> LocalFiles()
        {
            Program.log.Info("Getting users local files");
            var filesLocal = new List<WebFile>();
            foreach (var pathFile in Directory.GetFiles(userDownloadsDirectory))
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

        /* Load bookmarked files from file */
        public List<WebFile> BookmarkFiles() // Use BackGroundWorker to return these instead
        {
            Program.log.Info("Getting users bookmarks files");
            var filesBookmarks = new List<WebFile>();
            if (File.Exists(pathDataBookmarked))
                using (StreamReader reader = new StreamReader(pathDataBookmarked))
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

        /* Select file type */
        private void titleFilesAll_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = allFileTypes; SelectFilesTab(titleFilesAll); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesVideo_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = videoFileTypes; SelectFilesTab(titleFilesVideo); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesAudio_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = audioFileTypes; SelectFilesTab(titleFilesAudio); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesBooks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = bookFileTypes; SelectFilesTab(titleFilesBooks); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesSubtitles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = subtitleFileTypes; SelectFilesTab(titleFilesSubtitles); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesTorrents_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = torrentFileTypes; SelectFilesTab(titleFilesTorrents); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesSoftware_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = softwareFileTypes; SelectFilesTab(titleFilesSoftware); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesOther_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = otherFileTypes; SelectFilesTab(titleFilesOther); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesCustom_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            string getUserResponse = Microsoft.VisualBasic.Interaction.InputBox("File Type/Extensions (enter only one extension):", "Custom*", "e.g. MP4");
            string userResponse = getUserResponse.Replace(".", "");
            if (userResponse != "")
                selectedFilesFileType = new List<string>() { userResponse.ToUpper() }; SelectFilesTab(titleFilesCustom); selectedFiles = filesOpenDatabase; ShowFiles(selectedFiles);
        }

        private void titleFilesLocal_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = allFileTypes; SelectFilesTab(titleFilesLocal); selectedFiles = LocalFiles(); ShowFiles(selectedFiles);
        }

        private void titleFilesBookmarks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFilesFileType = allFileTypes; SelectFilesTab(titleFilesBookmarks); selectedFiles = BookmarkFiles(); ShowFiles(selectedFiles);
        }

        public void SelectFilesTab(CButton cbtn)
        {
            titleFilesAll.ColorFillSolid = Color.Transparent;
            titleFilesAll.BorderColor = Color.Transparent;
            titleFilesVideo.ColorFillSolid = Color.Transparent;
            titleFilesVideo.BorderColor = Color.Transparent;
            titleFilesAudio.ColorFillSolid = Color.Transparent;
            titleFilesAudio.BorderColor = Color.Transparent;
            titleFilesBooks.ColorFillSolid = Color.Transparent;
            titleFilesBooks.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesSoftware.ColorFillSolid = Color.Transparent;
            titleFilesSoftware.BorderColor = Color.Transparent;
            titleFilesCustom.ColorFillSolid = Color.Transparent;
            titleFilesCustom.BorderColor = Color.Transparent;
            titleFilesOther.ColorFillSolid = Color.Transparent;
            titleFilesOther.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;
            titleFilesBookmarks.ColorFillSolid = Color.Transparent;
            titleFilesBookmarks.BorderColor = Color.Transparent;

            cbtn.ColorFillSolid = Colors.uiColorOrange;
            cbtn.BorderColor = Colors.uiColorOrange;
        }

        private void dataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGridFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var URL = dataGridFiles.CurrentRow.Cells[5].Value.ToString();

            if (e.RowIndex != -1)
                if (dataGridFiles.CurrentRow.Cells[4].Value.ToString() == "Local")
                    ShowFileDetails(new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), new FileInfo(URL).Length, File.GetCreationTime(URL), "Local", URL));
                else
                    ShowFileDetails(Database.FileInfoFromURL(URL));
        }

        public Stopwatch stopWatch = new Stopwatch();

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

                    tab.SelectedTab = currentTab;

                    cmboBoxFilesHost.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesHost);
                    imgSearch.Image = Properties.Resources.magnify_orange;

                    if (dataGridFiles.Rows.Count == 0) emptyDataFiles.Visible = true; else emptyDataFiles.Visible = false;
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
                    if (TextExtensions.ContainsAll(file.Name.ToLower(), TextExtensions.GetWords(txtSearchFiles.Text.ToLower())) && selectedFilesFileType.Contains(file.Type) && file.Host.Contains(selectedFilesHost))
                        urls.Add(new WebFile(file.Type, file.Name, file.Size, file.DateUploaded, file.Host, file.URL));

                return urls;
            }
        }

        /* Show file details with the specified parameters */
        public void ShowFileDetails(WebFile file, bool createNewInstance = true)
        {
            Program.log.Info("Attempting to show file details dialog  : " + file.URL);

            if (createNewInstance)
                fileDetails = new FileDetails();

            fileDetails.currentFile = file;
            fileDetails.infoFileName.Text = file.Name;
            fileDetails.infoName.Text = file.Name;
            fileDetails.infoReferrer.Text = file.Host;
            fileDetails.infoType.Text = file.Type;
            fileDetails.infoFileURL.Text = file.URL;

            /* Build all parts of the URL into a better looking string */
            var url = new Uri(file.URL);
            var directories = new StringBuilder(file.Host);
            foreach (string path in url.LocalPath.Split('/'))
                if (!Path.HasExtension(path))
                    directories.Append(path + "> ");

            fileDetails.infoDirectory.Text = directories.ToString();
            fileDetails.infoSize.Text = TextExtensions.BytesToString(file.Size);
            fileDetails.infoAge.Text = TextExtensions.GetTimeAgo(file.DateUploaded);

            fileDetails.Dock = DockStyle.Fill;
            if (!createNewInstance) fileDetails.CheckFileEvents();
            if (createNewInstance) { tabBlank.Controls.Clear(); tabBlank.Controls.Add(fileDetails); }
            tab.SelectedTab = tabBlank;

            Program.log.Info("Successfully loaded file details dialog");
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

        public static string selectedFilesSearch = exploreUrlGoogle;

        private void cmboBoxSearchHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxHomeSearch.SelectedIndex == 0)
                selectedFilesSearch = exploreUrlGoogle;
            else if (cmboBoxHomeSearch.SelectedIndex == 1)
                selectedFilesSearch = exploreUrlGoogol;
            else if (cmboBoxHomeSearch.SelectedIndex == 2)
                selectedFilesSearch = exploreUrlStartpage;
            else if (cmboBoxHomeSearch.SelectedIndex == 3)
                selectedFilesSearch = exploreUrlSearx;

            Process.Start(selectedFilesSearch + String.Format("{0} %2B({1}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", txtSearchFilesHome.Text, String.Join("|", selectedFilesFileType.ToArray()).ToLower()));
        }

        public static string exploreUrlGoogle = "https://google.com/search?q=";
        public static string exploreUrlGoogol = "https://googol.warriordudimanche.net/?q=";
        public static string exploreUrlStartpage = "https://startpage.com/do/dsearch?query=";
        public static string exploreUrlSearx = "https://searx.me/?q=";

        public void SearchFiles()
        {
            imgSearch.Image = Properties.Resources.loader;
            tab.SelectedTab = tabSearch;

            if (Path.HasExtension(txtSearchFiles.Text)) {
                ShowFileDetails(Database.FileInfoFromURL(txtSearchFiles.Text));
                imgSearch.Image = Properties.Resources.magnify_orange;
            }
            else
                ShowFiles(selectedFiles);
        }

        public void DoSearchFilesFromHome()
        {
            txtSearchFiles.Text = txtSearchFilesHome.Text;

            if (cmboBoxHomeFileType.SelectedIndex == -1) { selectedFilesFileType = allFileTypes; SelectFilesTab(titleFilesAll); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 0) { selectedFilesFileType = allFileTypes; SelectFilesTab(titleFilesAll); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 1) { selectedFilesFileType = videoFileTypes; SelectFilesTab(titleFilesVideo); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 2) { selectedFilesFileType = audioFileTypes; SelectFilesTab(titleFilesAudio); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 3) { selectedFilesFileType = bookFileTypes; SelectFilesTab(titleFilesBooks); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 4) { selectedFilesFileType = subtitleFileTypes; SelectFilesTab(titleFilesSubtitles); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 5) { selectedFilesFileType = torrentFileTypes; SelectFilesTab(titleFilesTorrents); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 7) { selectedFilesFileType = softwareFileTypes; SelectFilesTab(titleFilesSoftware); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
            else if (cmboBoxHomeFileType.SelectedIndex == 8) { selectedFilesFileType = otherFileTypes; SelectFilesTab(titleFilesOther); selectedFiles = filesOpenDatabase; tab.SelectedTab = tabSearch; ShowFiles(selectedFiles); }
        }

        /* Sort Files */
        private void btnFilesSort_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesSort.DroppedDown = true;
        }

        private void cmboBoxFilesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgSearch.Image = Properties.Resources.loader;

            if (cmboBoxFilesSort.SelectedIndex == 0)
                ShowFiles(selectedFiles, SortBy.Name);
            else if (cmboBoxFilesSort.SelectedIndex == 1)
                ShowFiles(selectedFiles, SortBy.Size);
            else if (cmboBoxFilesSort.SelectedIndex == 2)
                ShowFiles(selectedFiles, SortBy.Date);

            var startText = btnFilesSort.Text.Split(':');
            btnFilesSort.Text = startText[0] + ": " + cmboBoxFilesSort.GetItemText(cmboBoxFilesSort.SelectedItem);
            Font myFont = new Font(btnFilesSort.Font.FontFamily, btnFilesSort.Font.Size);
            SizeF mySize = btnFilesSort.CreateGraphics().MeasureString(btnFilesSort.Text, myFont);
            panelFilesSort.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);

            imgSearch.Image = Properties.Resources.magnify_orange;
        }

        /* Filter Files by Host */
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
            if (cmboBoxFilesHost.SelectedIndex == 0) selectedFilesHost = "";
            else selectedFilesHost = cmboBoxFilesHost.SelectedItem.ToString();
            ShowFiles(selectedFiles);
            cmboBoxFilesHost.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesHost);
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

                    tab.SelectedTab = currentTab;
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
                        OpenLink.SubmitLink(formattedText); txtSubmitLink.Text = "";
                    }
                    else MessageBox.Show(this, "This isn't a public web directory.");                
                else MessageBox.Show(this, "This isn't a public web directory.");            
        }

        /* About tab */
        private void lblAboutReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start(urlGitHub + "issues/new");
        }

        private void btnAboutTermsOfUse_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label; ControlExtensions.ShowTextFromURL(lbl.Text, urlTermsOfUse);
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
            /* Set UI Properties */
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