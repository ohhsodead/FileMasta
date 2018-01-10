using OMDbAPI;
using DatabaseFileAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;
using System.Text;
using WebPlex.CControls;
using UnhandledExceptions;

namespace WebPlex
{
    public partial class frmWebPlex : Form
    {
        public frmWebPlex()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.userLanguage);

            allFileTypes.AddRange(videoFileTypes);
            allFileTypes.AddRange(audioFileTypes);
            allFileTypes.AddRange(ebooksFileTypes);
            allFileTypes.AddRange(subtitleFileTypes);
            allFileTypes.AddRange(torrentFileTypes);
            allFileTypes.AddRange(mobileFileTypes);
            allFileTypes.AddRange(archivesFileTypes);
            allFileTypes.AddRange(otherFileTypes);

            selectedFilesFileType = allFileTypes;

            InitializeComponent();

            imgSpinner.BringToFront(); // Hidden in Designer

            form = this;
            frmSplash = new ctrlSplashScreen();

            Controls.Add(frmSplash);
            frmSplash.Dock = DockStyle.Fill;
            frmSplash.Location = new Point(0, 0);
            frmSplash.ClientSize = ClientSize;
            frmSplash.BringToFront();
            frmSplash.Show();
        }

        public static ResourceManager rm = new ResourceManager("WebPlex.Languages.misc-" + Properties.Settings.Default.userLanguage, Assembly.GetExecutingAssembly());

        private BackgroundWorker worker; // startup background thread

        // Media Player Directories
        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public static string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public static string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public static string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";

        public static frmWebPlex form = null;
        public ctrlSplashScreen frmSplash;
        protected override void OnPaint(PaintEventArgs e) { }

        // Database Files
        public static string linkMovies = "https://dl.dropbox.com/s/qknonvla6qeuiuj/movies-posters.json?dl=0";
        public static string linkOpenFiles = "https://dl.dropbox.com/s/6ca7v71dwntiu0a/open-files.json?dl=0";
        public static string linkOpenDirectories = "https://raw.githubusercontent.com/invu/WebPlex/master/api/open-directories.txt";

        // Data/Downloads Directories
        public static string pathRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WebPlex\";
        public static string pathData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WebPlex\Data\";
        public static string userDownloadsDirectory = KnownFolders.GetPath(KnownFolder.Downloads) + @"\";

        // Updates
        public static string linkLatestVersion = "https://raw.githubusercontent.com/invu/WebPlex/master/assets/latest-version.txt";
        public static string pathInstallerFileName = "WebPlex.Installer.Windows.exe";
        public static string pathDownloadInstaller = userDownloadsDirectory + pathInstallerFileName;
        public static string getLatestInstaller(Version newVersion) { return "https://github.com/invu/WebPlex/releases/download/" + newVersion.ToString() + "/" + pathInstallerFileName; }

        WebClient client = new WebClient(); // public reusable web client

        private void frmWebPlex_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.ApplicationExitCall) { Properties.Settings.Default.Save(); if (Properties.Settings.Default.clearDataOnClose == true) { if (Directory.Exists(pathData)) { Directory.Delete(pathData, true); } } }
        }

        private void frmWebPlex_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
            panelMovies.Refresh();
        }

        private void frmWebPlex_Load(object sender, EventArgs e)
        {
            loadSettings();

            currentTab = tabMovies;

            Directory.CreateDirectory(pathRoot);
            Directory.CreateDirectory(pathData);

            tabAbout.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.background_original, 0.5F);
            tabSettings.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.background_original, 0.5F);
            tabFilesSearch.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.background_original, 0.5F);
            tabSubmit.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.background_original, 0.5F);

            lblAboutVersion.Text = "v" + Application.ProductVersion;

            if (Utilities.checkForInternetConnection() == true)
            {
                Utilities.checkForUpdate();

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
            //
            if (Utilities.doUpdateFile(linkOpenDirectories, "open-directories.txt"))
            {
                client.DownloadFile(new Uri(linkOpenDirectories), pathData + "open-directories.txt");
            }

            dataOpenDirectories.AddRange(File.ReadAllLines(pathData + "open-directories.txt"));
            //

            //
            if (Utilities.doUpdateFile(linkOpenFiles, "open-files.json"))
            {
                client.DownloadFile(new Uri(linkOpenFiles), pathData + "open-files.json");
            }

            dataOpenFiles.AddRange(File.ReadAllLines(pathData + "open-files.json"));
            //

            //
            if (Utilities.doUpdateFile(linkMovies, "movies-posters.json"))
            {
                client.DownloadFile(new Uri(linkMovies), pathData + "movies-posters.json");
            }

            dataMovies.AddRange(File.ReadAllLines(pathData + "movies-posters.json").Reverse());
            //

            // Get Local Files
            loadLocalFiles();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadMovies(52);
            Controls.Remove(frmSplash);
        }

        public void showStatusTab(string errorText)
        {
            // throws error with  control on Movies tab (WIP)
            imgSpinner.Visible = false;
            ctrlStatus a = new ctrlStatus
            {
                BackColor = tabMovies.BackColor,
                BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.background_original, 0.5F),
                Dock = DockStyle.Fill
            };

            a.titleStatus.Text = errorText;
            a.btnRestartApp.Text = rm.GetString("restart");
            a.Show();
            tabMovies.Controls.Clear();
            tabMovies.Padding = new Padding(0, 0, 0, 0);
            tabMovies.Controls.Add(a);
            Controls.Remove(frmSplash);
        }


        // Data, Movies, Files... & Everything else

        public static List<string> dataOpenDirectories = new List<string>();
        public static List<string> dataOpenFiles = new List<string>();
        public static List<string> dataMovies = new List<string>();
        public static List<string> dataFilesLocal = new List<string>();
        public static List<string> dataFilesSaved = new List<string>();

        // Core Tabs
        public TabPage currentTab;

        private void imgMovies_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabMovies;
        }

        private void imgFiles_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabFiles;
        }

        private void imgDiscover_Click(object sender, EventArgs e)
        {
            showHosts(); tab.SelectedTab = tabDiscover;
        }

        private void imgSubmit_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabSubmit;
        }

        private void imgSettings_Click(object sender, EventArgs e)
        {
            loadSettings(); tab.SelectedTab = tabSettings;
        }

        private void imgAbout_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabAbout;
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab.SelectedTab == tabMovies)
            {
                currentTab = tabMovies;

                selectedTabLine(titleLineMovies);
            }
            else if (tab.SelectedTab == tabFiles)
            {
                currentTab = tabFiles;

                selectedTabLine(titleLineFiles);
            }
            else if (tab.SelectedTab == tabDiscover)
            {
                currentTab = tabDiscover;

                selectedTabLine(titleLineDiscover);
            }
            else if (tab.SelectedTab == tabSubmit)
            {
                currentTab = tabDiscover;

                selectedTabLine(titleLineSubmit);
            }
            else if (tab.SelectedTab == tabSettings)
            {
                currentTab = tabSettings;

                selectedTabLine(titleLineSettings);
            }
            else if (tab.SelectedTab == tabAbout)
            {
                selectedTabLine(titleLineAbout);
            }
        }

        public void selectedTabLine(CButtonLib.CButton cbtn)
        {
            titleLineMovies.Visible = false;
            titleLineFiles.Visible = false;
            titleLineDiscover.Visible = false;
            titleLineSubmit.Visible = false;
            titleLineSettings.Visible = false;
            titleLineAbout.Visible = false;

            cbtn.Visible = true;
        }

        private void panelMovies_Scroll(object sender, ScrollEventArgs e)
        {
            panelMovies.Update();

            VScrollProperties vs = panelMovies.VerticalScroll;
            if (e.NewValue == vs.Maximum - vs.LargeChange + 1)
            {
                loadMovies(52);
            }
        }
        //

        // Movies
        int countedMovies = 0;
        string selectedGenre = "", selectedYear = "";

        object loadMoviesLock = new object();
        public List<ctrlPoster> LoadMovies(int loadCount)
        {
            lock (loadMoviesLock)
            {
                List<ctrlPoster> MoviesPosters = new List<ctrlPoster>();
                int loadedCount = 0;

                foreach (string movie in dataMovies.Skip(countedMovies))
                {
                    if (loadedCount < loadCount)
                    {
                        if (string.IsNullOrEmpty(movie) == false)
                        {
                            var data = OMDbEntity.FromJson(movie);

                            if (data.ImdbID.ToLower() == txtMoviesSearchBox.Text.ToLower() | data.Title.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) | data.Actors.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) && data.Year.Contains(selectedYear) && data.Genre.ToLower().Contains(selectedGenre.ToLower()))
                            {
                                ctrlPoster ctrlPoster = new ctrlPoster();
                                ctrlPoster.infoTitle.Text = data.Title.Replace("&", "&&");
                                ctrlPoster.infoYear.Text = data.Year;

                                ctrlPoster.infoPoster.BackgroundImage = Utilities.LoadPicture(data.Poster);

                                ctrlPoster.infoGenres = data.Genre;
                                ctrlPoster.infoSynopsis = data.Plot;
                                ctrlPoster.infoRuntime = data.Runtime;
                                ctrlPoster.infoRated = data.Rated;
                                ctrlPoster.infoDirector = data.Director;
                                ctrlPoster.infoCast = data.Actors;

                                ctrlPoster.infoImdbRating = data.ImdbRating;
                                ctrlPoster.infoImdbId = data.ImdbID;

                                ctrlPoster.infoImagePoster = data.Poster;
                                ctrlPoster.Name = data.ImdbID;
                                ctrlPoster.infoMovieFiles = data.Sources;

                                ctrlPoster.infoYifyTorrent480p = data.YifyTorrent480p;
                                ctrlPoster.infoYifyTorrent720p = data.YifyTorrent720p;
                                ctrlPoster.infoYifyTorrent1080p = data.YifyTorrent1080p;

                                ctrlPoster.infoPopcornTorrent720p = data.PopcornTorrent720p;
                                ctrlPoster.infoPopcornTorrent1080p = data.PopcornTorrent1080p;

                                ctrlPoster.infoTrailer = data.trailerUrl;
                                ctrlPoster.infoImageFanart = data.imageFanart;

                                ctrlPoster.Show();
                                MoviesPosters.Add(ctrlPoster);
                                loadedCount += 1;
                            }
                            countedMovies += 1;
                        }
                    }
                }
                return MoviesPosters;
            }
        }

        delegate void loadMoviesCallBack(int count);
        public void loadMovies(int count)
        {
            imgSpinner.Visible = true;
            BackGroundWorker.RunWorkAsync<List<ctrlPoster>>(() => LoadMovies(count), (data) =>
            {
                if (panelMovies.InvokeRequired)
                {
                    loadMoviesCallBack b = new loadMoviesCallBack(loadMovies);
                    Invoke(b, new object[] { count });
                }
                else
                {
                    foreach (ctrlPoster item in data)
                    {
                        panelMovies.Controls.Add(item);
                    }

                    tab.SelectedTab = tabMovies;
                    imgSpinner.Visible = false;
                }
            });
        }

        // Search Movies by Text
        private void txtMoviesSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panelMovies.Controls.Clear();
                countedMovies = 0;
                loadMovies(52);
            }
        }

        private void bgMoviesSearchBox_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtMoviesSearchBox.Focus();
        }

        private void btnSearchMovies_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            panelMovies.Controls.Clear();
            countedMovies = 0;
            loadMovies(52);
        }

        // Filter Movies by Genre
        private void btnMoviesGenre_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxMoviesGenre.DroppedDown = true;
        }

        private void cmboBoxMoviesGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            var startText = btnMoviesGenre.Text.Split(':');
            btnMoviesGenre.Text = startText[0] + ": " + cmboBoxMoviesGenre.SelectedItem.ToString();

            Font myFont = new Font(btnMoviesGenre.Font.FontFamily, this.btnMoviesGenre.Font.Size);
            SizeF mySize = btnMoviesGenre.CreateGraphics().MeasureString(btnMoviesGenre.Text, myFont);
            panelMoviesGenre.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxMoviesGenre.SelectedIndex == 0) { selectedGenre = ""; }
            else { selectedGenre = cmboBoxMoviesGenre.SelectedItem.ToString(); }

            panelMovies.Controls.Clear();
            countedMovies = 0;
            loadMovies(52);
        }

        // Filter Movies by Year        
        private void btnMoviesYear_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxMoviesYear.DroppedDown = true;
        }

        private void cmboBoxMoviesYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var startText = btnMoviesYear.Text.Split(':');
            btnMoviesYear.Text = startText[0] + ": " + cmboBoxMoviesYear.SelectedItem.ToString();

            Font myFont = new Font(btnMoviesYear.Font.FontFamily, this.btnMoviesYear.Font.Size);
            SizeF mySize = btnMoviesYear.CreateGraphics().MeasureString(btnMoviesYear.Text, myFont);
            panelMoviesYear.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxMoviesYear.SelectedIndex == 0) { selectedYear = ""; }
            else { selectedYear = cmboBoxMoviesYear.SelectedItem.ToString(); }

            panelMovies.Controls.Clear();
            countedMovies = 0;
            loadMovies(52);
        }
        //

        // Random Movie Button (I'm Feeling Lucky)
        private void btnMoviesRandom_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true;

            Thread.Sleep(100);

            var data = OMDbEntity.FromJson(Utilities.Random(dataMovies));

            ctrlMovieDetails MovieDetails = new ctrlMovieDetails();

            MovieDetails.infoTitle.Text = data.Title;
            MovieDetails.infoYear.Text = data.Year;
            MovieDetails.infoGenre.Text = data.Genre;
            MovieDetails.infoSynopsis.Text = data.Plot;
            MovieDetails.infoRuntime.Text = data.Runtime;
            MovieDetails.infoRated.Text = data.Rated;
            MovieDetails.infoDirector.Text = data.Director;
            MovieDetails.infoCast.Text = data.Actors;
            MovieDetails.infoRatingIMDb.Text = data.ImdbRating;
            MovieDetails.infoImdbId = data.ImdbID;
            MovieDetails.infoImagePoster = data.Poster;
            MovieDetails.infoFanartUrl = data.imageFanart;
            MovieDetails.infoTrailerUrl = data.trailerUrl;

            try
            {
                MovieDetails.imgPoster.Image = Utilities.ChangeOpacity(Utilities.LoadPicture(data.Poster), 1);
                MovieDetails.BackgroundImage = Utilities.ChangeOpacity(Utilities.LoadPicture(data.imageFanart), 0.2F);
            }
            catch { }

            foreach (string movieLink in data.Sources)
            {
                MovieDetails.AddStream(movieLink, false, false, MovieDetails.panelFiles);
            }

            if (data.YifyTorrent480p != null && data.YifyTorrent480p != "")
            {
                MovieDetails.AddStream(data.YifyTorrent480p, false, true, MovieDetails.panelTorrents, "480p");
            }

            if (data.YifyTorrent720p != null && data.YifyTorrent720p != "")
            {
                MovieDetails.AddStream(data.YifyTorrent720p, false, true, MovieDetails.panelTorrents, "720p");
            }

            if (data.YifyTorrent1080p != null && data.YifyTorrent1080p != "")
            {
                MovieDetails.AddStream(data.YifyTorrent1080p, false, true, MovieDetails.panelTorrents, "1080p");
            }


            MovieDetails.Dock = DockStyle.Fill;
            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(MovieDetails);
            imgSpinner.Visible = false;
            tab.SelectedTab = tabBlank;
        }


        // Files
        public static List<string> selectedFiles = dataOpenFiles;
        public static List<string> allFileTypes = new List<string>();
        public static List<string> videoFileTypes = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG" };
        public static List<string> audioFileTypes = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA" };
        public static List<string> ebooksFileTypes = new List<string>() { "EPUB", "AZW", "LIT", "PDF", "ODF", "MOBI", "CBR", "CBZ" };
        public static List<string> subtitleFileTypes = new List<string>() { "SRT", "SUB", "VTT" };
        public static List<string> mobileFileTypes = new List<string>() { "APK", "IPA", "APPX", "XAP" };
        public static List<string> torrentFileTypes = new List<string>() { "TORRENT" };
        public static List<string> archivesFileTypes = new List<string>() { "VOB", "ZIP", "RAR", "7Z", "ISO", "PKG", "TAR.GZ" };
        public static List<string> otherFileTypes = new List<string>() { "EXE", "XML", "TXT", "SQL", "CSV" };

        // Filter Preferences
        public List<string> selectedFilesFileType;
        public string selectedFilesHost = "";

        private void loadLocalFiles()
        {
            dataFilesLocal.Clear();

            foreach (string pathFile in Directory.GetFiles(userDownloadsDirectory))
            {
                var data = new DatabaseFilesEntity
                {
                    URL = pathFile,
                    Host = rm.GetString("local"),
                    Title = Path.GetFileNameWithoutExtension(pathFile),
                    Type = Path.GetExtension(pathFile).Replace(".", "").ToUpper(),
                    Size = Utilities.ToFileSize(new FileInfo(pathFile).Length),
                    DateAdded = File.GetCreationTime(pathFile).ToString()
            };

                dataFilesLocal.Add(data.ToJson());
            }
        }

        private void loadSavedFiles()
        {
            dataFilesSaved.Clear();

            if (File.Exists(Utilities.pathDataSaved))
            {
                using (StreamReader reader = new StreamReader(Utilities.pathDataSaved))
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
            Color selectedRGB = Color.FromArgb(42, 42, 42);
            Color nonSelectedRGB = Color.Transparent;

            titleFilesAll.ColorFillSolid = nonSelectedRGB;
            titleFilesAll.BorderColor = nonSelectedRGB;
            titleFilesVideo.ColorFillSolid = nonSelectedRGB;
            titleFilesVideo.BorderColor = nonSelectedRGB;
            titleFilesAudio.ColorFillSolid = nonSelectedRGB;
            titleFilesAudio.BorderColor = nonSelectedRGB;
            titleFilesEbooks.ColorFillSolid = nonSelectedRGB;
            titleFilesEbooks.BorderColor = nonSelectedRGB;
            titleFilesSubtitles.ColorFillSolid = nonSelectedRGB;
            titleFilesSubtitles.BorderColor = nonSelectedRGB;
            titleFilesTorrents.ColorFillSolid = nonSelectedRGB;
            titleFilesTorrents.BorderColor = nonSelectedRGB;
            titleFilesMobile.ColorFillSolid = nonSelectedRGB;
            titleFilesMobile.BorderColor = nonSelectedRGB;
            titleFilesArchives.ColorFillSolid = nonSelectedRGB;
            titleFilesArchives.BorderColor = nonSelectedRGB;
            titleFilesOther.ColorFillSolid = nonSelectedRGB;
            titleFilesOther.BorderColor = nonSelectedRGB;
            titleFilesLocal.ColorFillSolid = nonSelectedRGB;
            titleFilesLocal.BorderColor = nonSelectedRGB;
            titleFilesSaved.ColorFillSolid = nonSelectedRGB;
            titleFilesSaved.BorderColor = nonSelectedRGB;

            cbtn.ColorFillSolid = selectedRGB;
            cbtn.BorderColor = selectedRGB;  
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
            try
            {
                if (dataGridFiles.CurrentRow.Cells[4].Value.ToString() == rm.GetString("local"))
                {
                    showFileDetails(dataGridFiles.CurrentRow.Cells[5].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[1].Value.ToString() + "." + dataGridFiles.CurrentRow.Cells[0].Value.ToString().ToLower(),
                    dataGridFiles.CurrentRow.Cells[0].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[4].Value.ToString(),
                    true,
                    dataGridFiles.CurrentRow.Cells[2].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[3].Value.ToString());
                }
                else
                {
                    showFileDetails(dataGridFiles.CurrentRow.Cells[5].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[1].Value.ToString() + "." + dataGridFiles.CurrentRow.Cells[0].Value.ToString().ToLower(),
                    dataGridFiles.CurrentRow.Cells[0].Value.ToString(), dataGridFiles.CurrentRow.Cells[4].Value.ToString(),
                    false,
                    dataGridFiles.CurrentRow.Cells[2].Value.ToString(),
                    dataGridFiles.CurrentRow.Cells[3].Value.ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show("An error occurred showing file details.\n\n" + ex.Message); }

        }

        delegate void loadFilesCallBack(List<string> dataFiles);
        public void showFiles(List<string> dataFiles)
        {
            BackGroundWorker.RunWorkAsync<List<string>>(() => searchFiles(dataFiles), (data) =>
            {
                if (tabFiles.InvokeRequired)
                {
                    loadFilesCallBack b = new loadFilesCallBack(showFiles);
                    Invoke(b, new object[] { dataFiles });
                }
                else
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(frmWebPlex));
                    cmboBoxFilesSort.SelectedIndex = 0; dataGridFiles.Rows.Clear();
                    cmboBoxFilesHost.Items.Clear(); cmboBoxFilesHost.Items.Add(resources.GetString("cmboBoxFilesHost.Items"));

                    foreach (string jsonData in data)
                    {
                        var dataJson = DatabaseFilesEntity.FromJson(jsonData);
                        string dateAdded = dataJson.DateAdded;
                        if (dataJson.DateAdded != "-") { dateAdded = Utilities.getTimeAgo(Convert.ToDateTime(dataJson.DateAdded)); }
                        dataGridFiles.Rows.Add(dataJson.Type, dataJson.Title, dataJson.Size, dateAdded, dataJson.Host, dataJson.URL);

                        if (!(cmboBoxFilesHost.Items.Contains(dataJson.Host))) { cmboBoxFilesHost.Items.Add(dataJson.Host); }
                    }

                    tabControlFiles.SelectedTab = tabFilesResults;

                    cmboBoxFilesHost.DropDownWidth = Utilities.DropDownWidth(cmboBoxFilesHost);
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
                    var dataJson = DatabaseFilesEntity.FromJson(file);

                    if (Utilities.ContainsAll(dataJson.Title.ToLower(), Utilities.GetWords(txtFilesSearchResults.Text.ToLower())) && selectedFilesFileType.Contains(dataJson.Type) && dataJson.Host.Contains(selectedFilesHost))
                    {
                        urls.Add(dataJson.ToJson());
                    }

                }
                return urls;
            }
        }

        private void btnSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtFilesSearchResults.Text = txtFilesSearch.Text; tabControlFiles.SelectedTab = tabFilesResults; imgSpinner.Visible = true; showFiles(selectedFiles);
        }

        private void btnSearchFilesAgain_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; showFiles(selectedFiles);
        }

        public void showFileDetails(string Url, string Name, string Type, string Host, bool isLocal, string Size = "-", string Age = "-")
        {
            imgSpinner.Visible = true;

            ctrlFileDetails fileDetails = new ctrlFileDetails();
            fileDetails.infoFileName.Text = Name;
            fileDetails.infoName.Text = Name;
            fileDetails.infoSize.Text = Size;
            fileDetails.infoReferrer.Text = Host;
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
            fileDetails.BackgroundImage = Utilities.ChangeOpacity(Properties.Resources.background_original, 0.5F);
            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(fileDetails);
            imgSpinner.Visible = false;
            tab.SelectedTab = tabBlank;
        }

        private void bgFilesSearchBox_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtFilesSearchResults.Focus();
        }

        private void txtFilesSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchFilesAgain.PerformClick();
            }
        }

        private void txtFilesSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchFiles.PerformClick();
            }
        }

        // Sort Files 
        private void btnFilesSort_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesSort.DroppedDown = true;
        }

        private void cmboBoxFilesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var startText = btnFilesSort.Text.Split(':');
            btnFilesSort.Text = startText[0] + ": " + cmboBoxFilesSort.SelectedItem.ToString();

            if (cmboBoxFilesSort.SelectedIndex == 0) { cmboBoxFilesSort.DropDownWidth = Utilities.DropDownWidth(cmboBoxFilesSort); showFiles(selectedFiles); }
            else if (cmboBoxFilesSort.SelectedIndex == 1) { dataGridFiles.Sort(dataGridFiles.Columns[1], ListSortDirection.Ascending); }
            else if (cmboBoxFilesSort.SelectedIndex == 2) { dataGridFiles.Sort(dataGridFiles.Columns[1], ListSortDirection.Descending); }
        }
        
        // Filter Files by Host
        private void btnFilesHost_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesHost.DroppedDown = true;
        }

        private void btnFilesBackToSearch_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            tabControlFiles.SelectedTab = tabFilesSearch;
        }

        private void cmboBoxFilesHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            var startText = btnFilesHost.Text.Split(':');
            btnFilesHost.Text = startText[0] + ": " + cmboBoxFilesHost.SelectedItem.ToString();

            Font myFont = new Font(btnFilesHost.Font.FontFamily, this.btnFilesHost.Font.Size);
            SizeF mySize = btnFilesHost.CreateGraphics().MeasureString(btnFilesHost.Text, myFont);
            panelFilesHost.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxFilesHost.SelectedIndex == 0) { selectedFilesHost = ""; }
            else { selectedFilesHost = cmboBoxFilesHost.SelectedItem.ToString(); }

            showFiles(selectedFiles);

            cmboBoxFilesHost.DropDownWidth = Utilities.DropDownWidth(cmboBoxFilesHost);
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

                    tab.SelectedTab = tabDiscover;
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
                        Utilities.submitLink(formattedText); txtSubmitLink.Text = "";
                    }
                    else { MessageBox.Show("Link isn't in the correct format."); }
                }
                else { MessageBox.Show("This isn't a public web directory."); }
            }
        }
        //

        // About tab
        private void lblAboutReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/invu/WebPlex/issues/new");
        }
        //

        // Settings tab
        public void loadSettings()
        {
            // UI
            btnSettingsGeneralLanguage.Text = Properties.Settings.Default.userLanguage;
            chkSettingsClearData.Checked = Properties.Settings.Default.clearDataOnClose;
        }

        private void btnSettingsGeneralLanguage_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboboxSettingsLanguage.DroppedDown = true;
        }

        private void cmboboxGeneralSettingsLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSettingsGeneralLanguage.Text = cmboboxSettingsLanguage.SelectedItem.ToString();

            Properties.Settings.Default.userLanguage = cmboboxSettingsLanguage.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            if (MessageBox.Show(rm.GetString("restartRequiredLanguage"), rm.GetString("titleRestartRequired"), MessageBoxButtons.YesNo) == DialogResult.Yes) { Application.Restart(); }
        }

        private void btnSettingsSave_ClickButtonArea(object sender, MouseEventArgs e)
        {
            Thread.Sleep(500);
            if (cmboboxSettingsLanguage.GetItemText(cmboboxSettingsLanguage.SelectedItem) == "") { Properties.Settings.Default.userLanguage = btnSettingsGeneralLanguage.Text; }
            else { Properties.Settings.Default.userLanguage = cmboboxSettingsLanguage.GetItemText(cmboboxSettingsLanguage.SelectedItem); }
            Properties.Settings.Default.clearDataOnClose = chkSettingsClearData.Checked;
            Thread.Sleep(500);
            Properties.Settings.Default.Save();
            Thread.Sleep(500);
        }
        
        private void btnSettingsRestoreDefault_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Thread.Sleep(500);
            Properties.Settings.Default.clearDataOnClose = false;
            Thread.Sleep(500);
            loadSettings();
            Thread.Sleep(500);
        }
    }
}