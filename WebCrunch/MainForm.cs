using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using CButtonLib;
using UserControls;
using Utilities;
using Dialogs;
using WebCrunch.Extensions;
using WebCrunch.Utilities;

namespace WebCrunch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.userLanguage);

            allFileTypes.AddRange(videoFileTypes); allFileTypes.AddRange(audioFileTypes); allFileTypes.AddRange(ebooksFileTypes); allFileTypes.AddRange(subtitleFileTypes); allFileTypes.AddRange(torrentFileTypes); allFileTypes.AddRange(mobileFileTypes); allFileTypes.AddRange(archivesFileTypes); allFileTypes.AddRange(otherFileTypes);

            selectedFilesFileType = allFileTypes;

            InitializeComponent();

            lblAboutChangelogVersion.Text = String.Format(lblAboutChangelogVersion.Text, Application.ProductVersion);

            imgSpinner.BringToFront(); // Hidden in Designer

            form = this;

            frmSplash = new SplashScreen();

            Controls.Add(frmSplash);
            frmSplash.Dock = DockStyle.Fill;
            frmSplash.Location = new Point(0, 0);
            frmSplash.ClientSize = ClientSize;
            frmSplash.BringToFront();
            frmSplash.Show();
        }

        public static ResourceManager rm = new ResourceManager("WebCrunch.Languages.misc-" + Properties.Settings.Default.userLanguage, Assembly.GetExecutingAssembly());

        private BackgroundWorker worker; // startup background thread

        // Media Player Directories
        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public static string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public static string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public static string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";

        public static MainForm form = null;
        public SplashScreen frmSplash;
        protected override void OnPaint(PaintEventArgs e) { }

        // Database Files
        public static string linkOpenFiles = "https://dl.dropbox.com/s/ucyeqfn96x7n9lh/open-files.json?dl=0";
        public static string linkOpenDirectories = "https://raw.githubusercontent.com/ekkash/WebCrunch/master/api/open-directories.txt";
        public static string linkTopSearches = "https://dl.dropbox.com/s/9y0smo8g95g0ty4/top-searches.txt?dl=0";

        // Data/Downloads Directories
        public static string pathRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WebCrunch\";
        public static string pathData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WebCrunch\Data\";
        public static string pathDataSaved = pathRoot + "saved-files.json";
        public static string userDownloadsDirectory = KnownFolders.GetPath(KnownFolder.Downloads) + @"\";

        // Updates
        public static string linkLatestVersion = "https://dl.dropbox.com/s/wizu59t0tuk7p71/latest-version.txt?dl=0";
        public static string pathInstallerFileName = "WebCrunch.Installer.Windows.exe";
        public static string pathDownloadInstaller = userDownloadsDirectory + pathInstallerFileName;
        public static string getLatestInstaller(Version newVersion) { return "https://github.com/ekkash/WebCrunch/releases/download/" + newVersion.ToString() + "/" + pathInstallerFileName; }

        // Misc
        public static string linkChangelog = "https://raw.githubusercontent.com/ekkash/WebCrunch/master/CHANGELOG.md";
        public static string linkTermsOfUse = "https://raw.githubusercontent.com/ekkash/WebCrunch/master/TERMSOFUSE.md";
        public static string linkPrivacyPolicy = "https://raw.githubusercontent.com/ekkash/WebCrunch/master/PRIVACYPOLICY.md";
        public static string linkGitHubIssues = "https://github.com/ekkash/WebCrunch/issues/";

        WebClient client = new WebClient(); // public reusable web client

        // Share us on
        public string textMessage = "Hey%20guys%2C%20I%20found%20a%20brilliant%20way%20to%20find%20Direct%20download%20links%20for%20anything.";

        private void imgShareTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/intent/tweet?hashtags=WebCrunch&original_referer=https%3A%2F%2Fgithub.com/ekkash/WebCrunch%2F&ref_src=twsrc%5Etfw&text=" + textMessage + "&tw_p=tweetbutton&url=https%3A%2F%2Fgithub.com/ekkash/WebCrunch");
        }

        private void imgShareFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/sharer/sharer.php?app_id=248335808680372&kid_directed_site=0&sdk=joey&u=http%3A%2F%2Fgithub.com/ekkash/WebCrunch%2F&display=popup&ref=plugin&src=share_button");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.ApplicationExitCall) { Properties.Settings.Default.Save(); if (Properties.Settings.Default.clearDataOnClose == true) { if (Directory.Exists(pathData)) { Directory.Delete(pathData, true); } } }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadSettings();

            currentTab = tabHome;
            currentTabTitle = titleHome;

            Directory.CreateDirectory(pathRoot);
            Directory.CreateDirectory(pathData);

            if (LocalExtensions.checkForInternetConnection() == true)
            {
                Updates.checkForUpdate();

                loadTopSearches(); // Powered by the HackerTarget API to get Top Searches from FileChef.com

                worker = new BackgroundWorker();
                worker.DoWork += worker_DoWork;
                worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                worker.RunWorkerAsync();
            }
            else
            {
                showStatusTab(rm.GetString("errorNoInternetConnection"));
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Checks if database file exists, if so whether they're the same size, and downloads the latest one if any of them returns false

            //
            if (FileExtensions.doUpdateFile(linkOpenDirectories, "open-directories.txt"))
            {
                client.DownloadFile(new Uri(linkOpenDirectories), pathData + "open-directories.txt");
            }

            dataOpenDirectories.AddRange(File.ReadAllLines(pathData + "open-directories.txt"));
            //

            //
            if (FileExtensions.doUpdateFile(linkOpenFiles, "open-files.json"))
            {
                //client.DownloadFile(new Uri(linkOpenFiles), pathData + "open-files.json");
            }

            databaseInfo = File.ReadLines(pathData + "open-files.json").First();
            dataOpenFiles.AddRange(File.ReadAllLines(pathData + "open-files.json").Skip(1));
            //
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            getDatabaseInfo();
            Controls.Remove(frmSplash);
        }

        public void showStatusTab(string errorText) // Shows Message and Restart Button on Home tab if no connection established (WIP/TO-DO)
        {
            imgSpinner.Visible = false;

            ErrorInfo a = new ErrorInfo
            {
                BackColor = tabHome.BackColor,
                Dock = DockStyle.Fill
            };

            a.titleStatus.Text = errorText;
            a.btnRestartApp.Text = rm.GetString("restart");
            a.Show();
            tabHome.Controls.Clear();
            tabHome.Padding = new Padding(0, 0, 0, 0);
            tabHome.Controls.Add(a);
            Controls.Remove(frmSplash);
        }

        // Focus effect for Title Button
        public void titleCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BackColor = Color.FromArgb(58, 69, 78);
            ctrl.BorderColor = Color.FromArgb(58, 69, 78);
            ctrl.ColorFillSolid = Color.FromArgb(58, 69, 78);
        }

        public void titleCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;

            if (currentTabTitle == ctrl)
            {
                ctrl.BackColor = selectedTitleRGB;
                ctrl.BorderColor = selectedTitleRGB;
                ctrl.ColorFillSolid = selectedTitleRGB;
            }
            else
            {
                ctrl.BackColor = Color.Transparent;
                ctrl.BorderColor = Color.Transparent;
                ctrl.ColorFillSolid = Color.Transparent;
            }
        }

        // Focus effect for Button
        public void btnCButton_MouseEnter(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Color.FromArgb(58, 69, 78);
            ctrl.ColorFillSolid = Color.FromArgb(58, 69, 78);
        }

        public void btnCButton_MouseLeave(object sender, EventArgs e)
        {
            CButton ctrl = sender as CButton;
            ctrl.BorderColor = Color.FromArgb(51, 60, 67);
            ctrl.ColorFillSolid = Color.FromArgb(51, 60, 67);
        }

        // Focus effect for Text Box
        public void txtSearch_Enter(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            ctrl.BackColor = Color.FromArgb(58, 69, 78);

            if (ctrl == txtSearchFiles)
            {
                bgSearchFiles.BorderColor = Color.FromArgb(58, 69, 78);
                bgSearchFiles.ColorFillSolid = Color.FromArgb(58, 69, 78);
            }
            else if (ctrl == txtSearchFilesHome)
            {
                bgSearchFilesHome.BorderColor = Color.FromArgb(58, 69, 78);
                bgSearchFilesHome.ColorFillSolid = Color.FromArgb(58, 69, 78);
            }
            else if (ctrl == txtSubmitLink)
            {
                bgSubmitLink.BorderColor = Color.FromArgb(58, 69, 78);
                bgSubmitLink.ColorFillSolid = Color.FromArgb(58, 69, 78);
            }
        }

        public void txtSearch_Leave(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            ctrl.BackColor = Color.FromArgb(51, 60, 67);

            if (ctrl == txtSearchFiles)
            {
                bgSearchFiles.BorderColor = Color.FromArgb(51, 60, 67);
                bgSearchFiles.ColorFillSolid = Color.FromArgb(51, 60, 67);
            }
            else if (ctrl == txtSearchFilesHome)
            {
                bgSearchFilesHome.BorderColor = Color.FromArgb(51, 60, 67);
                bgSearchFilesHome.ColorFillSolid = Color.FromArgb(51, 60, 67);
            }
            else if (ctrl == txtSubmitLink)
            {
                bgSubmitLink.BorderColor = Color.FromArgb(51, 60, 67);
                bgSubmitLink.ColorFillSolid = Color.FromArgb(51, 60, 67);
            }
        }

        // Focus effect for Text Box
        Bitmap tmpImage = null;

        public void image_MouseEnter(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox;
            tmpImage = (Bitmap)ctrl.Image;
            ctrl.Image = ImageExtensions.SetAlpha((Bitmap)ctrl.Image, 100);
        }

        public void image_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox;
            ctrl.Image = ImageExtensions.SetAlpha(tmpImage, 255);
        }

        // Data, Movies, Files... and everything else
        public static List<string> dataOpenDirectories = new List<string>();
        public static List<string> dataOpenFiles = new List<string>();
        public static List<string> dataMovies = new List<string>();
        public static List<string> dataFilesLocal = new List<string>();
        public static List<string> dataFilesSaved = new List<string>();
        public static string databaseInfo;

        // Core Tabs
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
            currentTabTitle = (CButton)sender; showHosts(); tab.SelectedTab = tabDiscover;
        }

        private void titleSubmit_ClickButtonArea(object sender, MouseEventArgs e)
        {
            currentTabTitle = (CButton)sender; tab.SelectedTab = tabSubmit;
        }

        private void titleSettings_ClickButtonArea(object sender, MouseEventArgs e)
        {
            loadSettings(); currentTabTitle = (CButton)sender; tab.SelectedTab = tabSettings;
        }

        private void titleInformation_ClickButtonArea(object sender, MouseEventArgs e)
        {
            currentTabTitle = (CButton)sender; tab.SelectedTab = tabInformation;
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab.SelectedTab == tabHome)
            {
                currentTab = tabHome;

                selectTabTitle(titleHome);
            }
            else if (tab.SelectedTab == tabSearch)
            {
                currentTab = tabSearch;

                selectTabTitle(titleSearch);
            }
            else if (tab.SelectedTab == tabDiscover)
            {
                currentTab = tabDiscover;

                selectTabTitle(titleDiscover);
            }
            else if (tab.SelectedTab == tabSubmit)
            {
                currentTab = tabDiscover;

                selectTabTitle(titleSubmit);
            }
            else if (tab.SelectedTab == tabSettings)
            {
                currentTab = tabSettings;

                selectTabTitle(titleSettings);
            }
            else if (tab.SelectedTab == tabInformation)
            {
                currentTab = tabInformation;

                selectTabTitle(titleInformation);
            }
        }

        Color selectedTitleRGB = Color.FromArgb(51, 60, 67);
        Color nonSelectedTitleRGB = Color.FromArgb(43, 52, 59);

        public void selectTabTitle(CButton cbtn)
        {

            titleHome.ColorFillSolid = nonSelectedTitleRGB;
            titleHome.BorderColor = nonSelectedTitleRGB;
            titleHome.BackColor = nonSelectedTitleRGB;
            titleSearch.ColorFillSolid = nonSelectedTitleRGB;
            titleSearch.BorderColor = nonSelectedTitleRGB;
            titleSearch.BackColor = nonSelectedTitleRGB;
            titleDiscover.ColorFillSolid = nonSelectedTitleRGB;
            titleDiscover.BorderColor = nonSelectedTitleRGB;
            titleDiscover.BackColor = nonSelectedTitleRGB;
            titleSubmit.ColorFillSolid = nonSelectedTitleRGB;
            titleSubmit.BorderColor = nonSelectedTitleRGB;
            titleSubmit.BackColor = nonSelectedTitleRGB;
            titleSettings.ColorFillSolid = nonSelectedTitleRGB;
            titleSettings.BorderColor = nonSelectedTitleRGB;
            titleSettings.BackColor = nonSelectedTitleRGB;
            titleInformation.ColorFillSolid = nonSelectedTitleRGB;
            titleInformation.BorderColor = nonSelectedTitleRGB;
            titleInformation.BackColor = nonSelectedTitleRGB;

            cbtn.ColorFillSolid = selectedTitleRGB;
            cbtn.BorderColor = selectedTitleRGB;
            cbtn.BackColor = selectedTitleRGB;
        }

        // Home tab
        public void getDatabaseInfo()
        {
            long totalSize = 0;

            try
            {
                foreach (string jsonData in dataOpenFiles)
                {
                    if (TextExtensions.isValidJSON(jsonData))
                    {
                        var dataJsonFile = JsonConvert.DeserializeObject<Models.WebFile>(jsonData);
                        if (dataJsonFile.Size >= 0) { totalSize += dataJsonFile.Size; }
                    }
                }

                lblHomeStatsFiles.Text = String.Format(lblHomeStatsFiles.Text, TextExtensions.getFormattedNumber(dataOpenFiles.Count.ToString()), TextExtensions.bytesToString(totalSize), TextExtensions.getFormattedNumber(dataOpenDirectories.Count.ToString()));
            }
            catch { lblHomeStatsFiles.Text = String.Format(lblHomeStatsFiles.Text, TextExtensions.getFormattedNumber(dataOpenFiles.Count.ToString()), TextExtensions.bytesToString(totalSize), TextExtensions.getFormattedNumber(dataOpenDirectories.Count.ToString())); }

            try
            {
                // Database Info
                if (TextExtensions.isValidJSON(databaseInfo))
                {
                    var dataJsonInfo = JsonConvert.DeserializeObject<Models.DatabaseInfo>(databaseInfo);
                    if (TextExtensions.isDateTime(dataJsonInfo.LastUpdated)) { lblHomeStatsDatabaseUpdated.Text = String.Format(lblHomeStatsDatabaseUpdated.Text, Convert.ToDateTime(dataJsonInfo.LastUpdated).ToShortDateString()); }
                }
            }
            catch { lblHomeStatsDatabaseUpdated.Text = "Updated: n/a"; }
        }

        public void loadTopSearches()
        {
            try
            {
                int count = 0;
                var client = new WebClient();
                using (var stream = client.OpenRead(linkTopSearches))
                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (count <= 40)
                        {
                            addTopSearchTag(line, count);
                            count++;
                        }
                    }
                }

                // Add Credits Label to end of Top Searches
                Label a = new Label
                {
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
            }
            catch { lblHeaderTopSearches.Visible = false; lineHomeTopSearchesSplitter.Visible = false; panelTopSearches.Visible = false; } // Error occurred, so hide controls/skip...
        }

        private void btnFileChef_Click(object Sender, EventArgs e)
        {
            Process.Start("http://filechef.com/");
        }

        public void addTopSearchTag(string text, int count)
        {
            CButton a = new CButton
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(btnHomeFileType.Font.Name, 9.25F, FontStyle.Regular),
                Size = new Size(70, 24),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                TextMargin = new Padding(0, 2, 0, 2),
                BorderColor = Color.FromArgb(51, 60, 67),
                ColorFillSolid = Color.FromArgb(51, 60, 67),
                FillType = CButtonLib.CButton.eFillType.Solid,
                TextShadowShow = false,
                ShowFocus = CButtonLib.CButton.eFocus.None,
                Margin = new Padding(0, 3, 6, 3),
                BorderShow = true,
                DimFactorClick = 0,
                DimFactorHover = 0,
                Cursor = Cursors.Hand,
                Name = "tagItem" + count,
            };

            a.Corners.All = 2;

            Font myFont = new Font(a.Font.FontFamily, a.Font.Size);
            SizeF mySize = a.CreateGraphics().MeasureString(a.Text, myFont);
            a.Width = (((int)(Math.Round(mySize.Width, 0))) + 10);
            a.ClickButtonArea += btnTopSearchesTag_ClickButtonArea;
            a.MouseEnter += btnCButton_MouseEnter;
            a.MouseLeave += btnCButton_MouseLeave;
            panelTopSearches.Controls.Add(a);
        }

        private void btnTopSearchesTag_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            CButton tagItem = Sender as CButton;
            txtSearchFilesHome.Text = tagItem.Text;

            doSearchFiles();
        }

        private void btnHomeFileType_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxHomeFileType.DroppedDown = true;
        }

        private void cmboBoxHomeFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHomeFileType.Text = "Filetype : " + cmboBoxHomeFileType.SelectedItem.ToString();

            if (cmboBoxHomeFileType.SelectedIndex == -1) { selectedFilesFileType = allFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 0) { selectedFilesFileType = allFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 1) { selectedFilesFileType = videoFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 2) { selectedFilesFileType = audioFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 3) { selectedFilesFileType = ebooksFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 4) { selectedFilesFileType = subtitleFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 5) { selectedFilesFileType = torrentFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 6) { selectedFilesFileType = mobileFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 7) { selectedFilesFileType = archivesFileTypes; }
            else if (cmboBoxHomeFileType.SelectedIndex == 8) { selectedFilesFileType = otherFileTypes; }
        }

        private void btnExploreEngine_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxHomeEngine.DroppedDown = true;
        }

        public static string selectedFilesEngine = exploreUrlGoogle;

        private void cmboBoxExploreEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHomeEngine.Text = cmboBoxHomeEngine.SelectedItem.ToString();

            if (cmboBoxHomeEngine.SelectedIndex == 0) { } // Doesn't matter, won't need this anyway
            else if (cmboBoxHomeEngine.SelectedIndex == 1) { selectedFilesEngine = exploreUrlGoogle; }
            else if (cmboBoxHomeEngine.SelectedIndex == 2) { selectedFilesEngine = exploreUrlGoogol; }
            else if (cmboBoxHomeEngine.SelectedIndex == 3) { selectedFilesEngine = exploreUrlStartpage; }
            else if (cmboBoxHomeEngine.SelectedIndex == 4) { selectedFilesEngine = exploreUrlSearx; }
        }

        public static string exploreUrlGoogle = "https://google.com/search?q=";
        public static string exploreUrlGoogol = "https://googol.warriordudimanche.net/?q=";
        public static string exploreUrlStartpage = "https://startpage.com/do/dsearch?query=";
        public static string exploreUrlSearx = "https://searx.me/?q=";

        // Files
        public static List<string> selectedFiles = dataOpenFiles;
        public static List<string> allFileTypes = new List<string>();
        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };
        public static List<string> ebooksFileTypes = new List<string>() { "MOBI", "CBZ", "CBR", "CBC", "CHM", "EPUB", "FB2", "LIT", "LRF", "ODT", "PDF", "PRC", "PDB", "PML", "RB", "RTF", "TCR", "DOC", "DOCX" };
        public static List<string> subtitleFileTypes = new List<string>() { "SRT", "SUB", "VTT" };
        public static List<string> torrentFileTypes = new List<string>() { "TORRENT" };
        public static List<string> mobileFileTypes = new List<string>() { "APK", "IPA", "APPX", "XAP" };
        public static List<string> archivesFileTypes = new List<string>() { "VOB", "ZIP", "RAR", "7Z", "ISO", "PKG", "TAR.GZ" };
        public static List<string> otherFileTypes = new List<string>() { "EXE", "XML", "TXT", "SQL", "CSV" };

        // Filter Preferences
        public List<string> selectedFilesFileType = allFileTypes;
        public string selectedFilesHost = "";

        private void loadLocalFiles()
        {
            dataFilesLocal.Clear();

            foreach (var pathFile in Directory.GetFiles(userDownloadsDirectory))
            {
                var dataJson = new Models.WebFile
                {
                    URL = pathFile,
                    Host = rm.GetString("local"),
                    Name = Path.GetFileNameWithoutExtension(pathFile),
                    Type = Path.GetExtension(pathFile).Replace(".", "").ToUpper(),
                    Size = new FileInfo(pathFile).Length,
                    DateUploaded = File.GetCreationTime(pathFile)
            };

                dataFilesLocal.Add(JsonConvert.SerializeObject(dataJson));
            }
        }

        private void loadSavedFiles()
        {
            dataFilesSaved.Clear();

            if (File.Exists(pathDataSaved))
            {
                using (StreamReader reader = new StreamReader(pathDataSaved))
                {
                    while (!reader.EndOfStream)
                    {
                        dataFilesSaved.Add(reader.ReadLine());
                    }
                }
            }            
        }

        private void titleFilesAll_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = allFileTypes; selectFilesTab(titleFilesAll); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }

        private void titleFilesVideo_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = videoFileTypes; selectFilesTab(titleFilesVideo); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }

        private void titleFilesAudio_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = audioFileTypes; selectFilesTab(titleFilesAudio); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }

        private void titleFilesEbooks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = ebooksFileTypes; selectFilesTab(titleFilesEbooks); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }

        private void titleFilesSubtitles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = subtitleFileTypes; selectFilesTab(titleFilesSubtitles); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }
        
        private void titleFilesMobile_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = mobileFileTypes; selectFilesTab(titleFilesMobile); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }

        private void titleFilesTorrents_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = torrentFileTypes; selectFilesTab(titleFilesTorrents); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }

        private void titleFilesArchives_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = archivesFileTypes; selectFilesTab(titleFilesArchives); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }

        private void titleFilesOther_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = otherFileTypes; selectFilesTab(titleFilesOther); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
        }
        
        private void titleFilesCustom_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            string getUserResponse = Microsoft.VisualBasic.Interaction.InputBox("File Type/Extensions (enter only one extension):", "Custom*", "e.g. MP4");
            string userResponse = getUserResponse.Replace(".", "");
            if (userResponse != "")
            {
                imgSpinner.Visible = true; selectedFilesFileType = new List<string>() { userResponse.ToUpper() }; selectFilesTab(titleFilesCustom); selectedFiles = dataOpenFiles; showFiles(selectedFiles);
            }
        }

        private void titleFilesLocal_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = allFileTypes; selectFilesTab(titleFilesLocal); loadLocalFiles(); selectedFiles = dataFilesLocal; showFiles(selectedFiles);
        }
        
        private void titleFilesSaved_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFilesFileType = allFileTypes; selectFilesTab(titleFilesSaved); loadSavedFiles(); selectedFiles = dataFilesSaved; showFiles(selectedFiles);
        }

        public void selectFilesTab(CButtonLib.CButton cbtn)
        {
            Color selectedRGB = Color.FromArgb(51, 60, 67);
            Color nonSelectedTitleRGB = Color.Transparent;
            Color selectedForeRGB = Color.White;
            Color nonSelectedForeRGB = Color.Silver;

            titleFilesAll.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesAll.BorderColor = nonSelectedTitleRGB;
            titleFilesAll.ForeColor = nonSelectedForeRGB;
            titleFilesVideo.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesVideo.BorderColor = nonSelectedTitleRGB;
            titleFilesVideo.ForeColor = nonSelectedForeRGB;
            titleFilesAudio.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesAudio.BorderColor = nonSelectedTitleRGB;
            titleFilesAudio.ForeColor = nonSelectedForeRGB;
            titleFilesEbooks.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesEbooks.BorderColor = nonSelectedTitleRGB;
            titleFilesEbooks.ForeColor = nonSelectedForeRGB;
            titleFilesSubtitles.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesSubtitles.BorderColor = nonSelectedTitleRGB;
            titleFilesSubtitles.ForeColor = nonSelectedForeRGB;
            titleFilesTorrents.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesTorrents.BorderColor = nonSelectedTitleRGB;
            titleFilesTorrents.ForeColor = nonSelectedForeRGB;
            titleFilesMobile.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesMobile.BorderColor = nonSelectedTitleRGB;
            titleFilesMobile.ForeColor = nonSelectedForeRGB;
            titleFilesArchives.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesArchives.BorderColor = nonSelectedTitleRGB;
            titleFilesArchives.ForeColor = nonSelectedForeRGB;
            titleFilesCustom.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesCustom.BorderColor = nonSelectedTitleRGB;
            titleFilesCustom.ForeColor = nonSelectedForeRGB;
            titleFilesOther.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesOther.BorderColor = nonSelectedTitleRGB;
            titleFilesOther.ForeColor = nonSelectedForeRGB;
            titleFilesLocal.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesLocal.BorderColor = nonSelectedTitleRGB;
            titleFilesLocal.ForeColor = nonSelectedForeRGB;
            titleFilesSaved.ColorFillSolid = nonSelectedTitleRGB;
            titleFilesSaved.BorderColor = nonSelectedTitleRGB;
            titleFilesSaved.ForeColor = nonSelectedForeRGB;

            cbtn.ColorFillSolid = selectedRGB;
            cbtn.BorderColor = selectedRGB;
            cbtn.ForeColor = selectedForeRGB;
        }

        private void dataGridFiles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridFiles.Rows.Count == 0) emptyDataFiles.Visible = true; else emptyDataFiles.Visible = false;
        }

        private void dataGridFiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridFiles.Rows.Count == 0) emptyDataFiles.Visible = true; else emptyDataFiles.Visible = false;
        }

        private void dataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGridFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridFiles.CurrentRow.Cells[4].Value.ToString() == rm.GetString("local"))
                {
                    showFileDetails(dataGridFiles.CurrentRow.Cells[5].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[1].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[0].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[4].Value.ToString(),
                    true,
                    dataGridFiles.CurrentRow.Cells[2].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[3].Value.ToString());
                }
                else
                {
                    showFileDetails(dataGridFiles.CurrentRow.Cells[5].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[1].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[0].Value.ToString(), dataGridFiles.CurrentRow.Cells[4].Value.ToString(),
                    false,
                    dataGridFiles.CurrentRow.Cells[2].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[3].Value.ToString());
                }
            }
                
        }

        public Stopwatch stopWatch = new Stopwatch();

        delegate void loadFilesCallBack(List<string> dataFiles);
        public void showFiles(List<string> dataFiles)
        {
            BackGroundWorker.RunWorkAsync<List<string>>(() => searchFiles(dataFiles), (data) =>
            {
                if (tabSearch.InvokeRequired)
                {
                    loadFilesCallBack b = new loadFilesCallBack(showFiles);
                    Invoke(b, new object[] { dataFiles });
                }
                else
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                    cmboBoxFilesSort.SelectedIndex = 0; dataGridFiles.Rows.Clear();
                    cmboBoxFilesHost.Items.Clear(); cmboBoxFilesHost.Items.Add(resources.GetString("cmboBoxFilesHost.Items"));

                    stopWatch.Start();

                    foreach (string jsonData in data)
                    {
                        if (TextExtensions.isValidJSON(jsonData))
                        {
                            var dataJson = JsonConvert.DeserializeObject<Models.WebFile>(jsonData);
                            dataGridFiles.Rows.Add(dataJson.Type, dataJson.Name, TextExtensions.bytesToString(dataJson.Size), TextExtensions.getTimeAgo(dataJson.DateUploaded), dataJson.Host, dataJson.URL);

                            if (!(cmboBoxFilesHost.Items.Contains(dataJson.Host))) { cmboBoxFilesHost.Items.Add(dataJson.Host); }
                        }
                    }

                    stopWatch.Stop(); TimeSpan ts = stopWatch.Elapsed;
                    lblFilesResultsInfo.Text = TextExtensions.getFormattedNumber(dataGridFiles.Rows.Count.ToString()) + " / " + TextExtensions.getFormattedNumber(dataFiles.Count.ToString()) + " Files (" + String.Format("{0:0.000}", ts.TotalSeconds) + " Seconds)"; stopWatch.Reset();

                    tab.SelectedTab = currentTab;

                    cmboBoxFilesHost.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesHost);
                    imgSpinner.Visible = false;
                }
            });
        }

        object loadFilesLock = new object();
        public List<string> searchFiles(List<string> dataFiles)
        {
            lock (loadFilesLock)
            {
                List<string> urls = new List<string>();

                foreach (string file in dataFiles)
                {
                    var dataJson = JsonConvert.DeserializeObject<Models.WebFile>(file);

                    if (TextExtensions.ContainsAll(dataJson.Name.ToLower(), TextExtensions.GetWords(txtSearchFiles.Text.ToLower())) && selectedFilesFileType.Contains(dataJson.Type) && dataJson.Host.Contains(selectedFilesHost))
                    {
                        urls.Add(JsonConvert.SerializeObject(dataJson));
                    }

                }
                return urls;
            }
        }

        public void showFileDetails(string Url, string Name, string Type, string Host, bool isLocal, string Size = "-", string Age = "-")
        {
            imgSpinner.Visible = true;

            FileDetails fileDetails = new FileDetails();
            fileDetails.infoFileName.Text = Name;
            fileDetails.infoName.Text = Name;
            fileDetails.infoSize.Text = Size;
            fileDetails.infoReferrer.Text = Host;

            // Split parts of the url into a nice looking structure
            var url = new Uri(Url);
            var directories = new StringBuilder(Host);
            foreach (string path in url.LocalPath.Split('/'))
            {
                if (!Path.HasExtension(path)) { directories.Append(path + "> "); };
            }
            fileDetails.infoDirectory.Text = directories.ToString();
            fileDetails.infoType.Text = Type;
            fileDetails.infoAge.Text = Age;
            fileDetails.infoFileURL.Text = Url;
            fileDetails.Dock = DockStyle.Fill;
            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(fileDetails);
            imgSpinner.Visible = false;
            tab.SelectedTab = tabBlank;
        }

        private void bgSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtSearchFiles.Focus();
        }

        private void txtSearchFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doSearchFiles();
            }
        }

        private void bgSearchFilesHome_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtSearchFilesHome.Focus();
        }

        private void txtSearchFilesHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doSearchFilesFromHome();
            }
        }

        public void doSearchFiles()
        {
            imgSpinner.Visible = true; tab.SelectedTab = tabSearch; showFiles(selectedFiles);
        }

        public void doSearchFilesFromHome()
        {
            imgSpinner.Visible = true; txtSearchFiles.Text = txtSearchFilesHome.Text;

            if (cmboBoxHomeEngine.SelectedIndex == -1 | cmboBoxHomeEngine.SelectedIndex == 0)
            {
                if (cmboBoxHomeFileType.SelectedIndex == -1) { selectedFilesFileType = allFileTypes; selectFilesTab(titleFilesAll); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 0) { selectedFilesFileType = allFileTypes; selectFilesTab(titleFilesAll); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 1) { selectedFilesFileType = videoFileTypes; selectFilesTab(titleFilesVideo); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 2) { selectedFilesFileType = audioFileTypes; selectFilesTab(titleFilesAudio); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 3) { selectedFilesFileType = ebooksFileTypes; selectFilesTab(titleFilesEbooks); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 4) { selectedFilesFileType = subtitleFileTypes; selectFilesTab(titleFilesSubtitles); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 5) { selectedFilesFileType = torrentFileTypes; selectFilesTab(titleFilesTorrents); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 6) { selectedFilesFileType = mobileFileTypes; selectFilesTab(titleFilesMobile); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 7) { selectedFilesFileType = archivesFileTypes; selectFilesTab(titleFilesArchives); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
                else if (cmboBoxHomeFileType.SelectedIndex == 8) { selectedFilesFileType = otherFileTypes; selectFilesTab(titleFilesOther); selectedFiles = dataOpenFiles; tab.SelectedTab = tabSearch; showFiles(selectedFiles); }
            }
            else
            {
                Process.Start(selectedFilesEngine + String.Format("{0}+({1}) -inurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of -inurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)", txtSearchFilesHome.Text, String.Join("|", selectedFilesFileType.ToArray()))); imgSpinner.Visible = false;
            }
        }

        // Sort Files 
        private void btnFilesSort_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesSort.DroppedDown = true;
        }

        private void cmboBoxFilesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgSpinner.Visible = true;
            var startText = btnFilesSort.Text.Split(':');
            btnFilesSort.Text = startText[0] + ": " + cmboBoxFilesSort.SelectedItem.ToString();

            if (cmboBoxFilesSort.SelectedIndex == 0) { cmboBoxFilesSort.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesSort); showFiles(selectedFiles); }
            else if (cmboBoxFilesSort.SelectedIndex == 1) { dataGridFiles.Sort(dataGridFiles.Columns[1], ListSortDirection.Ascending); }
            else if (cmboBoxFilesSort.SelectedIndex == 2) { dataGridFiles.Sort(dataGridFiles.Columns[1], ListSortDirection.Descending); }
            imgSpinner.Visible = false;
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
            imgSpinner.Visible = true;

            var startText = btnFilesHost.Text.Split(':');
            btnFilesHost.Text = startText[0] + ": " + cmboBoxFilesHost.SelectedItem.ToString();

            Font myFont = new Font(btnFilesHost.Font.FontFamily, this.btnFilesHost.Font.Size);
            SizeF mySize = btnFilesHost.CreateGraphics().MeasureString(btnFilesHost.Text, myFont);
            panelFilesHost.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxFilesHost.SelectedIndex == 0) { selectedFilesHost = ""; }
            else { selectedFilesHost = cmboBoxFilesHost.SelectedItem.ToString(); }

            showFiles(selectedFiles);

            cmboBoxFilesHost.DropDownWidth = ControlExtensions.DropDownWidth(cmboBoxFilesHost);
        }

        // Discover tab
        private void dataGridDiscover_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(dataGridDiscover.CurrentRow.Cells[3].Value.ToString());
        }

        delegate void loadHostsCallBack();
        void showHosts()
        {
            imgSpinner.Visible = true; 

            BackGroundWorker.RunWorkAsync<List<string>>(() => getFileHosts(), (data) =>
            {
                if (tabDiscover.InvokeRequired)
                {
                    loadHostsCallBack b = new loadHostsCallBack(showHosts);
                    Invoke(b, new object[] { });
                }
                else
                {
                    dataGridDiscover.Rows.Clear();

                    int count = 1;
                    foreach (string url in data)
                    {
                        dataGridDiscover.Rows.Add(count.ToString(), url, "Web", url);
                        count += 1;
                    }

                    tab.SelectedTab = currentTab;
                    imgSpinner.Visible = false;
                }
            });
        }

        object loadHostsLock = new object();
        List<string> getFileHosts()
        {
            lock (loadHostsLock)
            {
                List<string> urls = new List<string>();

                foreach (string file in dataOpenDirectories)
                {
                    if (!urls.Contains(new Uri(file.Replace("www.", "")).GetLeftPart(UriPartial.Scheme) + new Uri(file.Replace("www.", "")).Authority)) { urls.Add(new Uri(file.Replace("www.", "")).GetLeftPart(UriPartial.Scheme) + new Uri(file.Replace("www.", "")).Authority); }
                }

                return urls;
            }
        }
        //

        // Submit tab
        private void btnSubmitLink_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (txtSubmitLink.Text != "")
            {
                if (!Path.HasExtension(txtSubmitLink.Text))
                {
                    if (Uri.IsWellFormedUriString(txtSubmitLink.Text, UriKind.Absolute))
                    {
                        string formattedText = txtSubmitLink.Text;
                        if (!txtSubmitLink.Text.EndsWith("/")) { formattedText = txtSubmitLink.Text + "/"; }
                        ReportTemplates.submitLink(formattedText); txtSubmitLink.Text = "";
                    }
                    else { MessageBox.Show(this, rm.GetString("linkIncorrectFormat")); }
                }
                else { MessageBox.Show(this, rm.GetString("linkIncorrectFormat")); }
            }
        }
        //

        // About tab
        private void lblAboutReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start(linkGitHubIssues + "new");
        }

        private void btnAboutTermsOfUse_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            showInfo(lbl.Text, linkTermsOfUse);
        }

        private void btnAboutPrivacyPolicy_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            showInfo(lbl.Text, linkPrivacyPolicy);
        }

        private void lblAboutChangelogVersion_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            showInfo(lbl.Text, linkChangelog);
        }

        public void showInfo(string Title, string URL)
        {
            DataDialog frmInfo = new DataDialog
            {
                Text = Title
            };

            using (var stream = client.OpenRead(URL))
            using (var reader = new StreamReader(stream))
            {
                frmInfo.dataInfo.Text = reader.ReadToEnd();
            }

            frmInfo.MaximumSize = new Size(frmInfo.MaximumSize.Width, this.Height - 100);
            frmInfo.ShowDialog(form);
        }
        //

        // Settings tab
        public void loadSettings()
        {
            // Set UI Properties
            btnSettingsGeneralLanguage.Text = Properties.Settings.Default.userLanguage;
            chkSettingsClearData.Checked = Properties.Settings.Default.clearDataOnClose;
        }

        private void btnSettingsGeneralLanguage_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxSettingsLanguage.DroppedDown = true;
        }

        private void cmboboxGeneralSettingsLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSettingsGeneralLanguage.Text = cmboBoxSettingsLanguage.SelectedItem.ToString();

            Properties.Settings.Default.userLanguage = cmboBoxSettingsLanguage.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            if (MessageBox.Show(this, rm.GetString("restartRequiredLanguage"), rm.GetString("titleRestartRequired"), MessageBoxButtons.YesNo) == DialogResult.Yes) { Application.Restart(); }
        }

        private void btnSettingsSave_ClickButtonArea(object sender, MouseEventArgs e)
        {
            if (cmboBoxSettingsLanguage.GetItemText(cmboBoxSettingsLanguage.SelectedItem) == "") { Properties.Settings.Default.userLanguage = btnSettingsGeneralLanguage.Text; }
            else { Properties.Settings.Default.userLanguage = cmboBoxSettingsLanguage.GetItemText(cmboBoxSettingsLanguage.SelectedItem); }
            Properties.Settings.Default.clearDataOnClose = chkSettingsClearData.Checked;
            Thread.Sleep(500);
            Properties.Settings.Default.Save();
            Thread.Sleep(500);
        }

        private void btnSettingsRestoreDefault_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Properties.Settings.Default.clearDataOnClose = false;
            Thread.Sleep(500);
            loadSettings();
            Thread.Sleep(500);
        }
    }
}