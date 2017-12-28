using OMDbAPI;
using DatabaseFilesAPI;
using regexFileName;
using Utilities;
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
using UnhandledExceptions;

namespace OpenTheatre
{
    public partial class frmOpenTheatre : Form
    {
        public frmOpenTheatre()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.userLanguage);

            InitializeComponent();

            form = this;
            frmSplash = new ctrlSplashScreen();

            Controls.Add(frmSplash);
            frmSplash.Dock = DockStyle.Fill;
            frmSplash.Location = new Point(0, 0);
            frmSplash.ClientSize = ClientSize;
            frmSplash.BringToFront();
            frmSplash.Show();
        }

        public static ResourceManager rm = new ResourceManager("OpenTheatre.Languages.misc-" + Properties.Settings.Default.userLanguage, Assembly.GetExecutingAssembly());

        private BackgroundWorker worker; // startup background thread

        // Media player directories
        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public static string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public static string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public static string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";

        public static frmOpenTheatre form = null;
        public ctrlSplashScreen frmSplash;
        protected override void OnPaint(PaintEventArgs e) { }

        // Exported database files
        public static string linkMovies = "https://dl.dropbox.com/s/qknonvla6qeuiuj/movies-posters.json?dl=0";
        public static string linkFilesVideo = "https://dl.dropbox.com/s/gkm57y5rxu3fxcs/video-files.json?dl=0";
        public static string linkFilesAudio = "https://dl.dropbox.com/s/gqhjrt4re0n1ls1/audio-files.json?dl=0";
        public static string linkFilesEbooks = "https://dl.dropbox.com/s/j0eec40nonx4vk5/ebooks-files.json?dl=0";
        public static string linkFilesSubtitles = "https://dl.dropbox.com/s/ciofl06to2y8zko/subtitles-files.json?dl=0";
        public static string linkFilesTorrents = "https://dl.dropbox.com/s/uvx3ypg7hd9b1ne/torrents-files.json?dl=0";
        public static string linkFilesArchives = "https://dl.dropbox.com/s/d6xc1v24rnx4y0e/archives-files.json?dl=0";

        // Updates
        public static string linkLatestVersion = "https://raw.githubusercontent.com/invu/opentheatre-app/master/assets/latest-version.txt";
        public static string pathInstallerFileName = "OpenTheatreInstaller.exe";
        public static string pathDownloadInstaller = KnownFolders.GetPath(KnownFolder.Downloads) + @"\" + pathInstallerFileName;
        public static string getLatestInstaller(Version newVersion) { return "https://github.com/invu/opentheatre-app/releases/download/" + newVersion.ToString() + "/" + pathInstallerFileName; }

        // Data/Downloads directories
        public static string pathRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenTheatre\";
        public static string pathData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenTheatre\Data\";
        public static string pathDownloadsDefault = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenTheatre\Downloads\";

        WebClient client = new WebClient(); // public reusable web client

        private void frmOpenTheatre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.ApplicationExitCall) { Properties.Settings.Default.Save(); if (Properties.Settings.Default.clearDataOnClose == true) { if (Directory.Exists(pathData)) { Directory.Delete(pathData, true); } } }
        }

        private void frmOpenTheatre_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
            panelMovies.Refresh();
        }

        private void frmOpenTheatre_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.downloadsDirectory == "") { Properties.Settings.Default.downloadsDirectory = pathDownloadsDefault; Directory.CreateDirectory(pathDownloadsDefault); }
            loadSettings();

            currentTab = tabMovies;

            Directory.CreateDirectory(pathRoot);
            Directory.CreateDirectory(pathData);

            tabAbout.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F);
            tabSettings.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F);

            lblAboutVersion.Text = "v" + Application.ProductVersion;

            if (UtilityTools.checkForInternetConnection() == true)
            {
                UtilityTools.checkForUpdate();

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
            try
            {
                //
                if (UtilityTools.doUpdateFile(linkMovies, "movies-posters.json"))
                {
                    client.DownloadFile(new Uri(linkMovies), pathData + "movies-posters.json");
                }

                dataMovies = File.ReadAllLines(pathData + "movies-posters.json");
                //

                //
                if (UtilityTools.doUpdateFile(linkFilesVideo, "video-files.json"))
                {
                    client.DownloadFile(new Uri(linkFilesVideo), pathData + "video-files.json");
                }

                dataFilesVideo = File.ReadAllLines(pathData + "video-files.json");
                //

                //
                if (UtilityTools.doUpdateFile(linkFilesAudio, "audio-files.json"))
                {
                    client.DownloadFile(new Uri(linkFilesAudio), pathData + "audio-files.json");
                }

                dataFilesAudio = File.ReadAllLines(pathData + "audio-files.json");
                //

                //
                if (UtilityTools.doUpdateFile(linkFilesEbooks, "ebooks-files.json"))
                {
                    client.DownloadFile(new Uri(linkFilesEbooks), pathData + "ebooks-files.json");
                }

                dataFilesEbooks = File.ReadAllLines(pathData + "ebooks-files.json");
                //

                //
                if (UtilityTools.doUpdateFile(linkFilesSubtitles, "subtitles-files.json"))
                {
                    client.DownloadFile(new Uri(linkFilesSubtitles), pathData + "subtitles-files.json");
                }

                dataFilesSubtitles = File.ReadAllLines(pathData + "subtitles-files.json");
                //

                //
                if (UtilityTools.doUpdateFile(linkFilesTorrents, "torrents-files.json"))
                {
                    client.DownloadFile(new Uri(linkFilesTorrents), pathData + "torrents-files.json");
                }

                dataFilesTorrents = File.ReadAllLines(pathData + "torrents-files.json");
                //

                //
                if (UtilityTools.doUpdateFile(linkFilesArchives, "archives-files.json"))
                {
                    client.DownloadFile(new Uri(linkFilesArchives), pathData + "archives-files.json");
                }

                dataFilesArchives = File.ReadAllLines(pathData + "archives-files.json");
                //

                // Get Local Files
                loadLocalFiles();
            }
            catch (Exception ex) { MessageBox.Show(rm.GetString("errorConnectToServer") + "\n\n" + ex.Message); Directory.Delete(pathData, true); }
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
            ctrlStatus a = new ctrlStatus();
            a.BackColor = tabMovies.BackColor;
            a.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F);
            a.titleStatus.Text = errorText;
            a.Dock = DockStyle.Fill;
            a.Show();
            tabMovies.Controls.Clear();
            tabMovies.Padding = new Padding(0, 0, 0, 0);
            tabMovies.Controls.Add(a);
            Controls.Remove(frmSplash);
        }

        // Data, Movies, Files... & Everything else

        public static string[] dataFilesArchives, dataFilesTorrents, dataFilesSubtitles, dataFilesEbooks, dataFilesAudio, dataFilesVideo, dataMovies;
        public static List<string> dataFilesLocal = new List<string>();

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

        private void imgDownloads_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabDownloads;
        }

        private void imgBookmarks_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabBookmarks;
        }

        private void imgSettings_Click(object sender, EventArgs e)
        {
            loadSettings();

            tab.SelectedTab = tabSettings;
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
                titleLineMovies.Visible = true;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = false;
                titleLineSettings.Visible = false;
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabFiles)
            {
                currentTab = tabFiles;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = true;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = false;
                titleLineSettings.Visible = false;
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabBookmarks)
            {
                if (currentTab != tabBookmarks) { showBookmarks(); }

                currentTab = tabBookmarks;

                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = true;
                titleLineSettings.Visible = false;
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabDownloads)
            {
                currentTab = tabDownloads;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = true;
                titleLineBookmarks.Visible = false;
                titleLineSettings.Visible = false;
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabSettings)
            {
                currentTab = tabSettings;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = false;
                titleLineSettings.Visible = true;
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabAbout)
            {
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = false;
                titleLineSettings.Visible = false;
                titleLineAbout.Visible = true;
            }
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

                foreach (string movie in dataMovies.Reverse().Skip(countedMovies))
                {
                    if (loadedCount < loadCount)
                    {
                        if (string.IsNullOrEmpty(movie) == false)
                        {
                            var data = OMDbEntity.FromJson(movie);

                            if (data.ImdbID.ToLower() == txtMoviesSearchBox.Text.ToLower() | data.Title.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) | data.Actors.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) && data.Year.Contains(selectedYear) && data.Genre.ToLower().Contains(selectedGenre.ToLower()))
                            {
                                ctrlPoster ctrlPoster = new ctrlPoster();
                                ctrlPoster.infoTitle.Text = data.Title;
                                ctrlPoster.infoYear.Text = data.Year;

                                ctrlPoster.infoPoster.BackgroundImage = UtilityTools.LoadPicture(data.Poster);

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

            var data = OMDbEntity.FromJson(UtilityTools.Random(dataMovies));

            ctrlDetails MovieDetails = new ctrlDetails();

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
                MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.Poster), 1);
                MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.imageFanart), 0.2F);
            }
            catch { }

            foreach (string movieLink in data.Sources)
            {
                MovieDetails.addStream(movieLink, false, false, MovieDetails.panelFiles);
            }

            if (data.YifyTorrent480p != null && data.YifyTorrent480p != "")
            {
                MovieDetails.addStream(data.YifyTorrent480p, false, true, MovieDetails.panelTorrents, "480p");
            }

            if (data.YifyTorrent720p != null && data.YifyTorrent720p != "")
            {
                MovieDetails.addStream(data.YifyTorrent720p, false, true, MovieDetails.panelTorrents, "720p");
            }

            if (data.YifyTorrent1080p != null && data.YifyTorrent1080p != "")
            {
                MovieDetails.addStream(data.YifyTorrent1080p, false, true, MovieDetails.panelTorrents, "1080p");
            }


            MovieDetails.Dock = DockStyle.Fill;
            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(MovieDetails);
            imgSpinner.Visible = false;
            tab.SelectedTab = tabBlank;
        }


        // Files
        public string selectedFilesFileType = "", selectedFilesHost = "", selectedFilesQuality = "", selectedFiles = "Video"; // Filter Preferences

        private void loadLocalFiles()
        {
            dataFilesLocal.Clear();

            foreach (string fileName in Directory.GetFiles(Properties.Settings.Default.downloadsDirectory))
            {
                var data = new DatabaseFilesEntity();
                data.Title = Path.GetFileNameWithoutExtension(fileName);
                data.Host = rm.GetString("local");
                data.Type = Path.GetExtension(fileName).Replace(".", "").ToUpper();
                data.URL = fileName;
                dataFilesLocal.Add(data.ToJson());
            }
        }

        private void titleFilesVideo_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Video";

            titleFilesVideo.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesVideo.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesAudio.ColorFillSolid = Color.Transparent;
            titleFilesAudio.BorderColor = Color.Transparent;
            titleFilesEbooks.ColorFillSolid = Color.Transparent;
            titleFilesEbooks.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles();
        }


        private void titleFilesAudio_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Audio";

            titleFilesVideo.ColorFillSolid = Color.Transparent;
            titleFilesVideo.BorderColor = Color.Transparent;
            titleFilesAudio.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesAudio.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesEbooks.ColorFillSolid = Color.Transparent;
            titleFilesEbooks.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles();
        }

        private void titleFilesEbooks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Ebooks";

            titleFilesVideo.ColorFillSolid = Color.Transparent;
            titleFilesVideo.BorderColor = Color.Transparent;
            titleFilesAudio.ColorFillSolid = Color.Transparent;
            titleFilesAudio.BorderColor = Color.Transparent;
            titleFilesEbooks.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesEbooks.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles();
        }

        private void titleFilesTorrents_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Torrents";

            titleFilesVideo.ColorFillSolid = Color.Transparent;
            titleFilesVideo.BorderColor = Color.Transparent;
            titleFilesAudio.ColorFillSolid = Color.Transparent;
            titleFilesAudio.BorderColor = Color.Transparent;
            titleFilesEbooks.ColorFillSolid = Color.Transparent;
            titleFilesEbooks.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesTorrents.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles();
        }

        private void titleFilesSubtitles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Subtitles";

            titleFilesVideo.ColorFillSolid = Color.Transparent;
            titleFilesVideo.BorderColor = Color.Transparent;
            titleFilesAudio.ColorFillSolid = Color.Transparent;
            titleFilesAudio.BorderColor = Color.Transparent;
            titleFilesEbooks.ColorFillSolid = Color.Transparent;
            titleFilesEbooks.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesSubtitles.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles();
        }

        private void titleFilesArchives_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Archives";

            titleFilesVideo.ColorFillSolid = Color.Transparent;
            titleFilesVideo.BorderColor = Color.Transparent;
            titleFilesAudio.ColorFillSolid = Color.Transparent;
            titleFilesAudio.BorderColor = Color.Transparent;
            titleFilesEbooks.ColorFillSolid = Color.Transparent;
            titleFilesEbooks.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesArchives.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles();
        }

        private void titleFilesLocal_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Local";

            titleFilesVideo.ColorFillSolid = Color.Transparent;
            titleFilesVideo.BorderColor = Color.Transparent;
            titleFilesAudio.ColorFillSolid = Color.Transparent;
            titleFilesAudio.BorderColor = Color.Transparent;
            titleFilesEbooks.ColorFillSolid = Color.Transparent;
            titleFilesEbooks.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesLocal.BorderColor = Color.FromArgb(42, 42, 42);

            loadLocalFiles();
            showFiles();
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

        private void dataGridFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedFiles == "Local") { showFileDetails(dataGridFiles.CurrentRow.Cells[3].Value.ToString(), true, dataGridFiles.CurrentRow.Cells[2].Value.ToString(), dataGridFiles.CurrentRow.Cells[3].Value.ToString()); }
            else { showFileDetails(dataGridFiles.CurrentRow.Cells[5].Value.ToString(), false, dataGridFiles.CurrentRow.Cells[2].Value.ToString(), dataGridFiles.CurrentRow.Cells[3].Value.ToString()); }
        }

        public void showFiles()
        {
            if (txtFilesSearchBox.Text != "")
            {
                imgSpinner.Visible = true;

                if (selectedFiles == "Video")
                {
                    showSelectedFiles(dataFilesVideo);
                }
                else if (selectedFiles == "Audio")
                {
                    showSelectedFiles(dataFilesAudio);
                }
                else if (selectedFiles == "Ebooks")
                {
                    showSelectedFiles(dataFilesEbooks);
                }
                else if (selectedFiles == "Subtitles")
                {
                    showSelectedFiles(dataFilesSubtitles);
                }
                else if (selectedFiles == "Torrents")
                {
                    showSelectedFiles(dataFilesTorrents);
                }
                else if (selectedFiles == "Archives")
                {
                    showSelectedFiles(dataFilesArchives);
                }
                else if (selectedFiles == "Local")
                {
                    showSelectedFiles(dataFilesLocal.ToArray());
                }
            }
        }

        delegate void loadFilesCallBack(string[] files);
        public void showSelectedFiles(string[] files)
        {
            BackGroundWorker.RunWorkAsync<List<string>>(() => searchFiles(files), (data) =>
            {
                if (tabFiles.InvokeRequired)
                {
                    loadFilesCallBack b = new loadFilesCallBack(showSelectedFiles);
                    Invoke(b, new object[] { files });
                }
                else
                {
                    cmboBoxFilesSort.SelectedIndex = 0; dataGridFiles.Rows.Clear();
                    cmboBoxFilesHost.Items.Clear(); cmboBoxFilesHost.Items.Add("Any");
                    cmboBoxFilesFormat.Items.Clear(); cmboBoxFilesFormat.Items.Add("Any");

                    foreach (string jsonData in data)
                    {
                        var dataJson = DatabaseFilesEntity.FromJson(jsonData);

                        dataGridFiles.Rows.Add(dataJson.Type, dataJson.Title, dataJson.Size, dataJson.DateAdded, dataJson.Host, dataJson.URL);
                        if (!(cmboBoxFilesFormat.Items.Contains(dataJson.Type))) { cmboBoxFilesFormat.Items.Add(dataJson.Type); }
                        if (!(cmboBoxFilesHost.Items.Contains(dataJson.Host))) { cmboBoxFilesHost.Items.Add(dataJson.Host); }
                    }

                    cmboBoxFilesHost.DropDownWidth = DropDownWidth(cmboBoxFilesHost);
                    imgSpinner.Visible = false;
                }
            });
        }

        private void btnSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            showFiles();
        }

        object loadFilesLock = new object();
        public List<string> searchFiles(string[] data)
        {
            lock (loadFilesLock)
            {
                List<string> urls = new List<string>();

                foreach (string file in data)
                {
                    var dataJson = DatabaseFilesEntity.FromJson(file);

                    if (UtilityTools.ContainsAll(dataJson.Title.ToLower(), UtilityTools.GetWords(txtFilesSearchBox.Text.ToLower())) && dataJson.Title.Contains(selectedFilesQuality) && dataJson.Type.Contains(selectedFilesFileType) && dataJson.Host.Contains(selectedFilesHost))
                    {
                        urls.Add(dataJson.ToJson());
                    }

                }
                return urls;
            }
        }

        public void showFileDetails(string webFile, bool isLocal, string fileSize = "", string fileDateAdded = "")
        {
            imgSpinner.Visible = true;

            ctrlDetails MovieDetails = new ctrlDetails();

            string[] movieName = fileNames.getMovieAndYear(Path.GetFileNameWithoutExtension(webFile));

            foreach (string movie in dataMovies)
            {
                if (string.IsNullOrEmpty(movie) == false)
                {
                    var data = OMDbEntity.FromJson(movie);

                    if (data.Title == movieName[0] && data.Year == movieName[1])
                    {
                        MovieDetails.infoTitle.Text = data.Title;
                        MovieDetails.infoYear.Text = data.Year;

                        try
                        {
                            MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.Poster), 1);
                            MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.imageFanart), 0.2F);
                        }
                        catch { }

                        foreach (string movieLink in data.Sources)
                        {
                            MovieDetails.addStream(movieLink, false, false, MovieDetails.panelFiles);
                        }

                        if (data.YifyTorrent480p != null && data.YifyTorrent480p != "")
                        {
                            MovieDetails.addStream(data.YifyTorrent480p, false, true, MovieDetails.panelTorrents, "480p");
                        }

                        if (data.YifyTorrent720p != null && data.YifyTorrent720p != "")
                        {
                            MovieDetails.addStream(data.YifyTorrent720p, false, true, MovieDetails.panelTorrents, "720p");
                        }

                        if (data.YifyTorrent1080p != null && data.YifyTorrent1080p != "")
                        {
                            MovieDetails.addStream(data.YifyTorrent1080p, false, true, MovieDetails.panelTorrents, "1080p");
                        }

                        MovieDetails.infoGenre.Text = data.Genre;
                        MovieDetails.infoSynopsis.Text = data.Plot;
                        MovieDetails.infoRuntime.Text = data.Runtime;
                        MovieDetails.infoRated.Text = data.Rated;
                        MovieDetails.infoDirector.Text = data.Director;
                        MovieDetails.infoCast.Text = data.Actors;

                        MovieDetails.infoRatingIMDb.Text = data.ImdbRating;
                        MovieDetails.infoImdbId = data.ImdbID;

                        MovieDetails.infoImagePoster = data.Poster;

                        MovieDetails.infoTrailerUrl = data.trailerUrl;
                        MovieDetails.infoFanartUrl = data.imageFanart;
                        MovieDetails.infoImagePoster = data.Poster;
                    }
                }
            }

            if (MovieDetails.infoTitle.Text == "Movie Title" && MovieDetails.infoYear.Text == "Year")
            {
                MovieDetails.infoTitle.Text = Path.GetFileNameWithoutExtension(webFile);
                MovieDetails.infoYear.Visible = false;

                MovieDetails.infoGenre.Visible = false;
                MovieDetails.infoSynopsis.Visible = false;
                MovieDetails.infoRuntime.Visible = false;
                MovieDetails.infoRated.Visible = false;
                MovieDetails.infoDirector.Visible = false;
                MovieDetails.infoCast.Visible = false;

                MovieDetails.infoRatingIMDb.Visible = false;
                MovieDetails.infoImdbId = "";

                MovieDetails.infoImagePoster = "";

                MovieDetails.infoTrailerUrl = "";
                MovieDetails.infoFanartUrl = "";
                MovieDetails.infoImagePoster = "";

                MovieDetails.infoSplitter0.Visible = false;
                MovieDetails.infoSplitter1.Visible = false;
                MovieDetails.infoSplitter2.Visible = false;
                MovieDetails.infoSplitter3.Visible = false;
                MovieDetails.infoSplitter4.Visible = false;
                MovieDetails.lblSubCast.Visible = false;
                MovieDetails.lblSubDirector.Visible = false;
                MovieDetails.imgIMDb.Visible = false;
            }

            MovieDetails.addStream(webFile, isLocal, false, MovieDetails.panelFiles, fileSize, fileDateAdded);

            MovieDetails.Dock = DockStyle.Fill;

            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(MovieDetails);
            imgSpinner.Visible = false;
            tab.SelectedTab = tabBlank;
        }

        private void bgFilesSearchBox_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtFilesSearchBox.Focus();
        }

        private void txtFilesSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showFiles();
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

            if (cmboBoxFilesSort.SelectedIndex == 0) { cmboBoxFilesSort.DropDownWidth = DropDownWidth(cmboBoxFilesSort); showFiles(); }
            else if (cmboBoxFilesSort.SelectedIndex == 1) { dataGridFiles.Sort(dataGridFiles.Columns[0], ListSortDirection.Ascending); }
            else if (cmboBoxFilesSort.SelectedIndex == 2) { dataGridFiles.Sort(dataGridFiles.Columns[0], ListSortDirection.Descending); }
        }

        // Filter Files by File Format
        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }

        private void btnFilesFileType_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesFormat.DroppedDown = true;
        }

        private void cmboBoxFilesFileFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var startText = btnFilesFormat.Text.Split(':');
            btnFilesFormat.Text = startText[0] + ": " + cmboBoxFilesFormat.SelectedItem.ToString();

            Font myFont = new Font(btnFilesFormat.Font.FontFamily, this.btnFilesFormat.Font.Size);
            SizeF mySize = btnFilesFormat.CreateGraphics().MeasureString(btnFilesFormat.Text, myFont);
            panelFilesFormat.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();

            if (cmboBoxFilesFormat.SelectedIndex == 0) { selectedFilesFileType = ""; }
            else { selectedFilesFileType = cmboBoxFilesFormat.SelectedItem.ToString(); }

            showFiles();
        }

        // Filter Files by Host
        private void btnFilesHost_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesHost.DroppedDown = true;
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

            showFiles();

            cmboBoxFilesHost.DropDownWidth = DropDownWidth(cmboBoxFilesHost);
        }

        // Filter Files by Quality
        private void btnFilesQuality_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesQuality.DroppedDown = true;
        }

        private void cmboBoxFilesQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            var startText = btnFilesQuality.Text.Split(':');
            btnFilesQuality.Text = startText[0] + ": " + cmboBoxFilesQuality.SelectedItem.ToString();

            Font myFont = new Font(btnFilesQuality.Font.FontFamily, this.btnFilesQuality.Font.Size);
            SizeF mySize = btnFilesQuality.CreateGraphics().MeasureString(btnFilesQuality.Text, myFont);
            panelFilesQuality.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxFilesQuality.SelectedIndex == 0) { selectedFilesQuality = ""; }
            else { selectedFilesQuality = cmboBoxFilesQuality.SelectedItem.ToString(); }

            showFiles();
        }
        //

        // Bookmarks
        string selectedBookmarksType = "";
        
        private void dataGridBookmarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridBookmarks.CurrentRow.Cells[3].Value.ToString() == rm.GetString("local")) showFileDetails(dataGridBookmarks.CurrentRow.Cells[4].Value.ToString(), true);
            else showFileDetails(dataGridBookmarks.CurrentRow.Cells[4].Value.ToString(), false);
        }

        delegate void loadBookmarksCallBack();
        public void showBookmarks()
        {
            BackGroundWorker.RunWorkAsync<List<string>>(() => searchBookmarks(), (data) =>
            {
                if (tabBookmarks.InvokeRequired)
                {
                    loadBookmarksCallBack b = new loadBookmarksCallBack(showBookmarks);
                    Invoke(b, new object[] { });
                }
                else
                {
                    cmboBoxBookmarksSort.SelectedIndex = 0;
                    dataGridBookmarks.Rows.Clear();

                    foreach (string fileUrl in data)
                    {
                        string formattedHost;
                        if (new Uri(fileUrl).Host == "") { formattedHost = rm.GetString("local"); } else { formattedHost = new Uri(fileUrl).Host.Replace("www.", ""); }
                        dataGridBookmarks.Rows.Add(UtilityTools.getContainingListOfURL(fileUrl), Path.GetFileNameWithoutExtension(new Uri(fileUrl).LocalPath), Path.GetExtension(fileUrl).Replace(".", "").ToUpper(), formattedHost, fileUrl);
                    }

                    imgSpinner.Visible = false;
                }
            });
        }

        object loadBookmarksLock = new object();
        public List<string> searchBookmarks()
        {
            lock (loadBookmarksLock)
            {
                List<string> urls = new List<string>();

                foreach (string fileUrl in Properties.Settings.Default.dataBookmarks)
                {
                    var url = new Uri(fileUrl);
                    if (UtilityTools.ContainsAll(Path.GetFileNameWithoutExtension(new Uri(fileUrl).LocalPath), UtilityTools.GetWords(txtBookmarksSearchBox.Text.ToLower())) && UtilityTools.getContainingListOfURL(fileUrl).Contains(selectedBookmarksType))
                    {
                        urls.Add(fileUrl);
                    }
                }
                return urls;
            }
        }                

        private void dataGridBookmarks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridBookmarks.Rows.Count == 0) emptyDataBookmarks.Visible = true; else emptyDataBookmarks.Visible = false;
        }

        private void dataGridBookmarks_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridBookmarks.Rows.Count == 0) emptyDataBookmarks.Visible = true; else emptyDataBookmarks.Visible = false;
        }

        // Search Bookmarks by Text
        private void btnSearchBookmarks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            showBookmarks();
        }

        private void txtBookmarksSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showBookmarks();
            }
        }

        private void bgBookmarksSearchBox_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            txtBookmarksSearchBox.Focus();
        }

        // Sort Bookmarks (Any : A-Z : Z-A)
        private void btnBookmarksSort_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxBookmarksSort.DroppedDown = true;
        }

        private void cmboBoxBookmarksSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgSpinner.Visible = true;

            var startText = btnBookmarksSort.Text.Split(':');
            btnBookmarksSort.Text = startText[0] + ": " + cmboBoxBookmarksSort.SelectedItem.ToString();

            Font myFont = new Font(btnBookmarksSort.Font.FontFamily, this.btnBookmarksSort.Font.Size);
            SizeF mySize = btnBookmarksSort.CreateGraphics().MeasureString(btnBookmarksSort.Text, myFont);
            panelBookmarksSort.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxBookmarksSort.SelectedIndex == 0) { cmboBoxBookmarksSort.DropDownWidth = DropDownWidth(cmboBoxBookmarksSort); showBookmarks(); }
            else if (cmboBoxBookmarksSort.SelectedIndex == 1) { dataGridBookmarks.Sort(dataGridBookmarks.Columns[1], ListSortDirection.Ascending); }
            else if (cmboBoxBookmarksSort.SelectedIndex == 2) { dataGridBookmarks.Sort(dataGridBookmarks.Columns[1], ListSortDirection.Descending); }

            imgSpinner.Visible = false;
        }

        // Filter Bookmarks by Type
        private void btnBookmarksType_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxBookmarksType.DroppedDown = true;
        }

        private void cmboBoxBookmarksType_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgSpinner.Visible = true;

            var startText = btnBookmarksType.Text.Split(':');
            btnBookmarksType.Text = startText[0] + ": " + cmboBoxBookmarksType.SelectedItem.ToString();

            Font myFont = new Font(btnBookmarksType.Font.FontFamily, this.btnBookmarksType.Font.Size);
            SizeF mySize = btnBookmarksType.CreateGraphics().MeasureString(btnBookmarksType.Text, myFont);
            panelBookmarksType.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxBookmarksType.SelectedIndex == 0) { selectedBookmarksType = ""; showBookmarks(); }
            else { selectedBookmarksType = cmboBoxBookmarksType.SelectedItem.ToString(); showBookmarks(); }

            imgSpinner.Visible = false;
        }
        //

        // Downloads tab
        public static List<string> currentDownloads = new List<string>();

        public void doDownloadFile(string fileURL)
        {
            ctrlDownloadItem ctrlItem = new ctrlDownloadItem();
            ctrlItem.progressBar1.BorderColor = tabDownloads.BackColor;
            ctrlItem.infoStatus.Text = rm.GetString("connecting");
            ctrlItem.Width = panelDownloads.ClientSize.Width - 7;
            panelDownloads.Controls.Add(ctrlItem);
            ctrlItem.doDownloadFile(fileURL);
            currentDownloads.Add(fileURL);
        }

        private void panelDownloadItems_ControlAdded(object sender, ControlEventArgs e)
        {
            if (panelDownloads.Controls.Count == 0) { lblNoDownloads.Visible = true; titleDownloads.Text = rm.GetString("titleDownloads"); } else { lblNoDownloads.Visible = false; titleDownloads.Text = rm.GetString("titleDownloads") + " (" + panelDownloads.Controls.Count.ToString() + ")"; }
        }

        private void panelDownloadItems_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (panelDownloads.Controls.Count == 0) { lblNoDownloads.Visible = true; titleDownloads.Text = rm.GetString("titleDownloads"); } else { lblNoDownloads.Visible = false; titleDownloads.Text = rm.GetString("titleDownloads") + " (" + panelDownloads.Controls.Count.ToString() + ")"; }
        }

        //

        // About tab
        private void imgCloseAbout_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = currentTab;
        }

        private void lblAboutReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/invu/opentheatre/issues/new");
        }
        //

        // Settings tab
        public void loadSettings()
        {
            // UI
            btnSettingsGeneralLanguage.Text = Properties.Settings.Default.userLanguage;

            chkSettingsClearData.Checked = Properties.Settings.Default.clearDataOnClose;
            chkSettingsCustomConnection.Checked = Properties.Settings.Default.connectionCustom;

            txtBoxSettingsDownloadsDirectory.WaterMark = Properties.Settings.Default.downloadsDirectory;
            txtBoxSettingsDownloadsDirectory.Text = Properties.Settings.Default.downloadsDirectory;

            txtBoxSettingsConnectionHost.Text = Properties.Settings.Default.connectionHost;
            txtBoxSettingsConnectionPort.Text = Convert.ToString(Properties.Settings.Default.connectionPort);
            txtBoxSettingsConnectionUsername.Text = Properties.Settings.Default.connectionUsername;
            txtBoxSettingsConnectionPassword.Text = Properties.Settings.Default.connectionPassword;

            // Enable/Disable Connection Settings
            lblSettingsConnectionHost.Enabled = Properties.Settings.Default.connectionCustom;
            lblSettingsConnectionPort.Enabled = Properties.Settings.Default.connectionCustom;
            lblSettingsConnectionUsername.Enabled = Properties.Settings.Default.connectionCustom;
            lblSettingsConnectionPassword.Enabled = Properties.Settings.Default.connectionCustom;

            txtBoxSettingsConnectionHost.Enabled = Properties.Settings.Default.connectionCustom;
            txtBoxSettingsConnectionPort.Enabled = Properties.Settings.Default.connectionCustom;
            txtBoxSettingsConnectionUsername.Enabled = Properties.Settings.Default.connectionCustom;
            txtBoxSettingsConnectionPassword.Enabled = Properties.Settings.Default.connectionCustom;

            bgSettingsConnectionHost.Enabled = Properties.Settings.Default.connectionCustom;
            bgSettingsConnectionPort.Enabled = Properties.Settings.Default.connectionCustom;
            bgSettingsConnectionUsername.Enabled = Properties.Settings.Default.connectionCustom;
            bgSettingsConnectionPassword.Enabled = Properties.Settings.Default.connectionCustom;
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

        private void imgSettingsDownloadsDirectory_Click(object sender, EventArgs e)
        {
            var a = new FolderBrowserDialog();
            if (a.ShowDialog() == DialogResult.OK) { txtBoxSettingsDownloadsDirectory.WaterMark = a.SelectedPath + @"\"; txtBoxSettingsDownloadsDirectory.Text = a.SelectedPath + @"\"; }
        }

        private void chkSettingsCustomConnection_CheckedChanged(object sender, EventArgs e)
        {
            //* UI *\\
            Thread.Sleep(500);

            lblSettingsConnectionHost.Enabled = chkSettingsCustomConnection.Checked;
            lblSettingsConnectionPort.Enabled = chkSettingsCustomConnection.Checked;
            lblSettingsConnectionUsername.Enabled = chkSettingsCustomConnection.Checked;
            lblSettingsConnectionPassword.Enabled = chkSettingsCustomConnection.Checked;

            txtBoxSettingsConnectionHost.Enabled = chkSettingsCustomConnection.Checked;
            txtBoxSettingsConnectionPort.Enabled = chkSettingsCustomConnection.Checked;
            txtBoxSettingsConnectionUsername.Enabled = chkSettingsCustomConnection.Checked;
            txtBoxSettingsConnectionPassword.Enabled = chkSettingsCustomConnection.Checked;

            bgSettingsConnectionHost.Enabled = chkSettingsCustomConnection.Checked;
            bgSettingsConnectionPort.Enabled = chkSettingsCustomConnection.Checked;
            bgSettingsConnectionUsername.Enabled = chkSettingsCustomConnection.Checked;
            bgSettingsConnectionPassword.Enabled = chkSettingsCustomConnection.Checked;

            Thread.Sleep(500);
        }

        private void btnSettingsSave_ClickButtonArea(object sender, MouseEventArgs e)
        {
            Thread.Sleep(500);
            if (cmboboxSettingsLanguage.GetItemText(cmboboxSettingsLanguage.SelectedItem) == "") { Properties.Settings.Default.userLanguage = btnSettingsGeneralLanguage.Text; }
            else { Properties.Settings.Default.userLanguage = cmboboxSettingsLanguage.GetItemText(cmboboxSettingsLanguage.SelectedItem); }
            Properties.Settings.Default.clearDataOnClose = chkSettingsClearData.Checked;
            Properties.Settings.Default.downloadsDirectory = txtBoxSettingsDownloadsDirectory.Text;
            Properties.Settings.Default.connectionCustom = chkSettingsCustomConnection.Checked;
            Properties.Settings.Default.connectionHost = txtBoxSettingsConnectionHost.Text;
            Properties.Settings.Default.connectionPort = txtBoxSettingsConnectionPort.Text;
            Properties.Settings.Default.connectionUsername = txtBoxSettingsConnectionUsername.Text;
            Properties.Settings.Default.connectionPassword = txtBoxSettingsConnectionPassword.Text;
            Thread.Sleep(500);
            Properties.Settings.Default.Save();
            Thread.Sleep(500);
        }
        
        private void btnSettingsRestoreDefault_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Thread.Sleep(500);
            Properties.Settings.Default.clearDataOnClose = false;
            Properties.Settings.Default.connectionCustom = false;
            Properties.Settings.Default.connectionHost = "";
            Properties.Settings.Default.connectionPort = "";
            Properties.Settings.Default.connectionUsername = "";
            Properties.Settings.Default.connectionPassword = "";
            Properties.Settings.Default.downloadsDirectory = pathDownloadsDefault;
            Thread.Sleep(500);
            loadSettings();
            Thread.Sleep(500);
        }
    }
}