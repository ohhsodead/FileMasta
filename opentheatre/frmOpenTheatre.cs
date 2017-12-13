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
        public static string linkMovies = "https://dl.dropbox.com/s/ionv8bszlgvf1xc/open-movies.json?dl=0"; // posters
        public static string linkFilesMovies = "https://dl.dropbox.com/s/jtac1zhsdhy6931/open-movies-files.json?dl=0";
        public static string linkFilesSeries = "https://dl.dropbox.com/s/2ze0xayim0cgk70/open-series-files.json?dl=0";
        public static string linkFilesAnime = "https://dl.dropbox.com/s/e5lhyejb56cwo9k/open-anime-files.json?dl=0";
        public static string linkFilesSubtitles = "https://dl.dropbox.com/s/ckkxsogprgviyto/open-subtitles-files.json?dl=0";
        public static string linkFilesTorrents = "https://dl.dropbox.com/s/nkzzyk4vr6k4rlr/open-torrents-files.json?dl=0";
        public static string linkFilesArchives = "https://dl.dropbox.com/s/el93946do0og2gg/open-archives-files.json?dl=0";

        // Updates
        public static string linkLatestVersion = "https://raw.githubusercontent.com/invu/opentheatre-app/master/assets/opentheatre-version.txt";
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
                if (UtilityTools.doUpdateFile(linkMovies, "open-movies.json") == true)
                {
                    client.DownloadFile(new Uri(linkMovies), pathData + "open-movies.json");
                }

                dataMovies = File.ReadAllLines(pathData + "open-movies.json");
                //


                //
                if (UtilityTools.doUpdateFile(linkFilesMovies, "open-movies-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesMovies), pathData + "open-movies-files.json");
                }

                dataFilesMovies = File.ReadAllLines(pathData + "open-movies-files.json");
                //


                //
                if (UtilityTools.doUpdateFile(linkFilesSeries, "open-series-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesSeries), pathData + "open-series-files.json");
                }

                dataFilesSeries = File.ReadAllLines(pathData + "open-series-files.json");
                //


                //
                if (UtilityTools.doUpdateFile(linkFilesAnime, "open-anime-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesAnime), pathData + "open-anime-files.json");
                }

                dataFilesAnime = File.ReadAllLines(pathData + "open-anime-files.json");
                //


                //
                if (UtilityTools.doUpdateFile(linkFilesSubtitles, "open-subtitles-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesSubtitles), pathData + "open-subtitles-files.json");
                }

                dataFilesSubtitles = File.ReadAllLines(pathData + "open-subtitles-files.json");
                //


                //
                if (UtilityTools.doUpdateFile(linkFilesTorrents, "open-torrents-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesTorrents), pathData + "open-torrents-files.json");
                }

                dataFilesTorrents = File.ReadAllLines(pathData + "open-torrents-files.json");
                //


                //
                if (UtilityTools.doUpdateFile(linkFilesArchives, "open-archives-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesArchives), pathData + "open-archives-files.json");
                }

                dataFilesArchives = File.ReadAllLines(pathData + "open-archives-files.json");
                //

                // Get Local Files
                loadLocalFiles();
            }
            catch (Exception ex) { showStatusTab(rm.GetString("errorConnectToServer") + "\n\n" + ex.Message); Directory.Delete(pathData, true); }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            showFiles();
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

        public static string[] dataFilesArchives, dataFilesTorrents, dataFilesSubtitles, dataFilesAnime, dataFilesSeries, dataFilesMovies, dataMovies;
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
                if (currentTab != tabBookmarks) { searchBookmarks(); }

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
        public List<ctrlMoviesPoster> LoadMovies(int loadCount)
        {
            lock (loadMoviesLock)
            {
                List<ctrlMoviesPoster> MoviesPosters = new List<ctrlMoviesPoster>();
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
                                ctrlMoviesPoster ctrlPoster = new ctrlMoviesPoster();
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
                                ctrlPoster.infoMovieTorrent480p = data.torrent480p;
                                ctrlPoster.infoMovieTorrent720p = data.torrent720p;
                                ctrlPoster.infoMovieTorrent1080p = data.torrent1080p;

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
            BackGroundWorker.RunWorkAsync<List<ctrlMoviesPoster>>(() => LoadMovies(count), (data) =>
            {
                if (panelMovies.InvokeRequired)
                {
                    loadMoviesCallBack b = new loadMoviesCallBack(loadMovies);
                    Invoke(b, new object[] { count });
                }
                else
                {
                    foreach (ctrlMoviesPoster item in data)
                    {
                        panelMovies.Controls.Add(item);
                    }

                    imgSpinner.Visible = false;
                    tab.SelectedTab = tabMovies;
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

            MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.Poster), 1);

            if (data.Poster == "") { MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 1); }

            MovieDetails.infoFanartUrl = data.imageFanart;
            MovieDetails.infoTrailerUrl = data.trailerUrl;

            if (MovieDetails.infoFanartUrl == "") { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F); }
            if (MovieDetails.infoTrailerUrl == "") { MovieDetails.btnWatchTrailer.Visible = false; }

            foreach (string movieLink in data.Sources)
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.infoFileURL = new Uri(movieLink).AbsoluteUri;
                ctrlInfo.infoFileHost.Text = new Uri(movieLink).Host.Replace("www.", "");
                ctrlInfo.infoFileName.Text = Path.GetFileNameWithoutExtension(new Uri(movieLink).LocalPath);
                MovieDetails.panelFiles.Controls.Add(ctrlInfo);
            }

            //  Magnet : magnet:?xt=urn:btih:TORRENT_HASH&dn=Url+Encoded+Movie+Name&tr=http://track.one:1234/announce&tr=udp://track.two:80
            string trackers = "&tr=" + "udp://open.demonii.com:1337/announce" + " &tr=" + "udp://tracker.openbittorrent.com:80" + "&tr=" + "udp://tracker.coppersurfer.tk:6969" + "&tr=" + "udp://glotorrents.pw:6969/announce" + "&tr=" + "udp://tracker.opentrackr.org:1337/announce" + "&tr=" + "udp://torrent.gresille.org:80/announce" + "&tr=" + "udp://p4p.arenabg.com:1337" + "&tr=" + "udp://tracker.leechers-paradise.org:6969";

            if (data.torrent480p != "")
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.isTorrent = true;
                ctrlInfo.infoFileURL = new Uri(data.torrent480p).AbsoluteUri;
                ctrlInfo.infoFileHost.Text = new Uri(data.torrent480p).Host.Replace("www.", "");
                ctrlInfo.infoFileName.Text = data.Title + " (" + data.Year + ") [" + "480p" + "] [" + "YTS.AG" + "]";
                ctrlInfo.infoMagnet = "magnet:?xt=urn:btih:" + Path.GetFileName(data.torrent480p) + "&dn=" + data.Title.Replace(" ", "+") + "%28" + data.Year + "%29+%5B" + "720p" + "%5D+%5B" + "YTS.AG" + "%5D" + trackers;
                MovieDetails.panelTorrents.Controls.Add(ctrlInfo);
            }

            if (data.torrent720p != "")
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.isTorrent = true;
                ctrlInfo.infoFileURL = new Uri(data.torrent720p).AbsoluteUri;
                ctrlInfo.infoFileHost.Text = new Uri(data.torrent720p).Host.Replace("www.", "");
                ctrlInfo.infoFileName.Text = data.Title + " (" + data.Year + ") [" + "720p" + "] [" + "YTS.AG" + "]";
                ctrlInfo.infoMagnet = "magnet:?xt=urn:btih:" + Path.GetFileName(data.torrent720p) + "&dn=" + data.Title.Replace(" ", "+") + "%28" + data.Year + "%29+%5B" + "720p" + "%5D+%5B" + "YTS.AG" + "%5D" + trackers;
                MovieDetails.panelTorrents.Controls.Add(ctrlInfo);
            }

            if (data.torrent1080p != "")
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.isTorrent = true;
                ctrlInfo.infoFileURL = new Uri(data.torrent1080p).AbsoluteUri;
                ctrlInfo.infoFileHost.Text = new Uri(data.torrent1080p).Host.Replace("www.", "");
                ctrlInfo.infoFileName.Text = data.Title + " (" + data.Year + ") [" + "1080p" + "] [" + "YTS.AG" + "]";
                ctrlInfo.infoMagnet = "magnet:?xt=urn:btih:" + Path.GetFileName(data.torrent1080p) + "&dn=" + data.Title.Replace(" ", "+") + "%28" + data.Year + "%29+%5B" + "720p" + "%5D+%5B" + "YTS.AG" + "%5D" + trackers;
                MovieDetails.panelTorrents.Controls.Add(ctrlInfo);
            }

            MovieDetails.Dock = DockStyle.Fill;
            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(MovieDetails);
            imgSpinner.Visible = false;
            tab.SelectedTab = tabBlank;
        }


        // Files
        string selectedFilesFileType = "", selectedFilesHost = "", selectedFilesQuality = "", selectedFiles = "Movies"; // Files Filter Preferences

        private void loadLocalFiles()
        {
            dataFilesLocal.Clear();

            foreach (string fileName in Directory.GetFiles(Properties.Settings.Default.downloadsDirectory))
            {
                var data = new DatabaseFilesEntity();
                data.Title = Path.GetFileNameWithoutExtension(fileName);
                data.Host = "Local";
                data.Type = Path.GetExtension(fileName).Replace(".", "").ToUpper();
                data.URL = fileName;
                dataFilesLocal.Add(data.ToJson());
            }
        }

        private void titleFilesMovies_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true;
            selectedFiles = "Movies";

            titleFilesMovies.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesMovies.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles();
            imgSpinner.Visible = false;
        }

        private void titleFilesAnime_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Anime";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesAnime.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles(); imgSpinner.Visible = false;

        }

        private void titleFilesSeries_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Series";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesSeries.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles(); imgSpinner.Visible = false;
        }

        private void titleFilesTorrents_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Torrents";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesTorrents.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles(); imgSpinner.Visible = false;
        }

        private void titleFilesSubtitles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Subtitles";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesSubtitles.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles(); imgSpinner.Visible = false;
        }

        private void titleFilesArchives_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Archives";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesArchives.BorderColor = Color.FromArgb(42, 42, 42);
            titleFilesLocal.ColorFillSolid = Color.Transparent;
            titleFilesLocal.BorderColor = Color.Transparent;

            showFiles(); imgSpinner.Visible = false;
        }

        private void titleFilesLocal_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            imgSpinner.Visible = true; selectedFiles = "Local";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;
            titleFilesArchives.ColorFillSolid = Color.Transparent;
            titleFilesArchives.BorderColor = Color.Transparent;
            titleFilesLocal.ColorFillSolid = Color.FromArgb(42, 42, 42);
            titleFilesLocal.BorderColor = Color.FromArgb(42, 42, 42);

            loadLocalFiles();
            showFiles(); imgSpinner.Visible = false;
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
            if (dataGridFiles.CurrentRow.Cells[2].Value.ToString() == rm.GetString("local")) { showFileDetails(dataGridFiles.CurrentRow.Cells[3].Value.ToString(), true); }
            else { showFileDetails(dataGridFiles.CurrentRow.Cells[3].Value.ToString(), false); }
        }

        public void showFiles()
        {
            if (selectedFiles == "Movies")
            {
                showSelectedFiles(dataFilesMovies);
            }
            else if (selectedFiles == "Series")
            {
                showSelectedFiles(dataFilesSeries);
            }
            else if (selectedFiles == "Anime")
            {
                showSelectedFiles(dataFilesAnime);
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

                        dataGridFiles.Rows.Add(dataJson.Title, dataJson.Type, dataJson.Host, dataJson.URL);
                        if (!(cmboBoxFilesFormat.Items.Contains(dataJson.Type))) { cmboBoxFilesFormat.Items.Add(dataJson.Type); }
                        if (!(cmboBoxFilesHost.Items.Contains(dataJson.Host))) { cmboBoxFilesHost.Items.Add(dataJson.Host); }
                    }

                    cmboBoxFilesHost.DropDownWidth = DropDownWidth(cmboBoxFilesHost);
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

        public void showFileDetails(string webFile, bool isLocal)
        {
            imgSpinner.Visible = true;

            ctrlDetails MovieDetails = new ctrlDetails();

            string omdbUrl = null;

            string[] movieName = fileNames.getMovieAndYear(Path.GetFileNameWithoutExtension(webFile));
            string[] tvshowName = fileNames.getTVShowName(Path.GetFileNameWithoutExtension(webFile));

            if (!(movieName == null)) { omdbUrl = "http://omdbapi.com/?apikey=c933e052&t=" + movieName[0] + "&y=" + movieName[1] + "&plot=full"; }
            else if (!(tvshowName == null)) { omdbUrl = "http://omdbapi.com/?apikey=c933e052&t=" + tvshowName[0] + "&Season=" + tvshowName[1] + "&Episode=" + tvshowName[2]; }

            if (omdbUrl != null)
            {
                using (WebClient wc = new WebClient())
                {
                    var JsonOMDbAPI = wc.DownloadString(omdbUrl);
                    var data = OMDbEntity.FromJson(JsonOMDbAPI);

                    if (data.Response == "True")
                    {

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

                        MovieDetails.infoFanartUrl = data.imageFanart;
                        MovieDetails.infoTrailerUrl = data.trailerUrl;

                        try { MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.Poster), 1); } catch { MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 0.5F); }
                    }
                    else
                    {
                        MovieDetails.infoTitle.Text = Path.GetFileNameWithoutExtension(new Uri(webFile).LocalPath);
                        MovieDetails.infoYear.Visible = false;
                        MovieDetails.infoGenre.Visible = false;
                        MovieDetails.infoSynopsis.Visible = false;
                        MovieDetails.infoRuntime.Visible = false;
                        MovieDetails.infoRated.Visible = false;
                        MovieDetails.infoDirector.Visible = false;
                        MovieDetails.infoCast.Visible = false;
                        MovieDetails.infoRatingIMDb.Visible = false;

                        MovieDetails.infoSplitter0.Visible = false;
                        MovieDetails.infoSplitter1.Visible = false;
                        MovieDetails.infoSplitter2.Visible = false;
                        MovieDetails.infoSplitter3.Visible = false;
                        MovieDetails.infoSplitter4.Visible = false;
                        MovieDetails.imgIMDb.Visible = false;
                        MovieDetails.lblSubDirector.Visible = false;
                        MovieDetails.lblSubCast.Visible = false;


                        MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 0.5F);
                    }
                }
            }

            if (MovieDetails.infoFanartUrl == "") { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F); }
            if (MovieDetails.infoTrailerUrl == "") { MovieDetails.btnWatchTrailer.Visible = false; }

            ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
            ctrlInfo.infoFileURL = webFile;
            ctrlInfo.infoFileHost.Text = new Uri(webFile).Host.Replace("www.", "");
            ctrlInfo.infoFileName.Text = Path.GetFileNameWithoutExtension(new Uri(webFile).LocalPath);
            ctrlInfo.isLocal = isLocal;
            MovieDetails.panelFiles.Controls.Add(ctrlInfo);
            MovieDetails.panelTitleTorrents.Visible = false;
            MovieDetails.panelTorrents.Visible = false;

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
            if (dataGridBookmarks.CurrentRow.Cells[3].Value.ToString() == "Local") showFileDetails(dataGridBookmarks.CurrentRow.Cells[4].Value.ToString(), true);
            else showFileDetails(dataGridBookmarks.CurrentRow.Cells[4].Value.ToString(), false);
        }

        public void searchBookmarks()
        {
            imgSpinner.Visible = true;

            cmboBoxBookmarksSort.SelectedIndex = 0;
            dataGridBookmarks.Rows.Clear();

            foreach (string fileUrl in Properties.Settings.Default.dataBookmarks)
            {
                var url = new Uri(fileUrl);
                if (UtilityTools.ContainsAll(Path.GetFileNameWithoutExtension(new Uri(fileUrl).LocalPath), UtilityTools.GetWords(txtBookmarksSearchBox.Text.ToLower())) && UtilityTools.getContainingListOfURL(fileUrl).Contains(selectedBookmarksType))
                {
                    string formattedHost;
                    if (new Uri(fileUrl).Host == "") { formattedHost = rm.GetString("local"); } else { formattedHost = new Uri(fileUrl).Host.Replace("www.", ""); }
                    dataGridBookmarks.Rows.Add(UtilityTools.getContainingListOfURL(fileUrl), Path.GetFileNameWithoutExtension(new Uri(fileUrl).LocalPath), Path.GetExtension(fileUrl).Replace(".", "").ToUpper(), formattedHost, fileUrl);
                }
            }

            imgSpinner.Visible = false;
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
            searchBookmarks();
        }

        private void txtBookmarksSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBookmarks();
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
            if (cmboBoxBookmarksSort.SelectedIndex == 0) { cmboBoxBookmarksSort.DropDownWidth = DropDownWidth(cmboBoxBookmarksSort); searchBookmarks(); }
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
            if (cmboBoxBookmarksType.SelectedIndex == 0) { selectedBookmarksType = ""; searchBookmarks(); }
            else { selectedBookmarksType = cmboBoxBookmarksType.SelectedItem.ToString(); searchBookmarks(); }

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
            if (panelDownloads.Controls.Count == 0) { lblNoDownloads.Visible = true; } else { lblNoDownloads.Visible = false; }
        }

        private void panelDownloadItems_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (panelDownloads.Controls.Count == 0) { lblNoDownloads.Visible = true; } else { lblNoDownloads.Visible = false; }
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

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(frmOpenTheatre));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void imgSettingsDownloadsDirectory_Click(object sender, EventArgs e)
        {
            var a = new FolderBrowserDialog();
            if (a.ShowDialog() == DialogResult.OK) { txtBoxSettingsDownloadsDirectory.WaterMark = a.SelectedPath + @"\"; txtBoxSettingsDownloadsDirectory.Text = a.SelectedPath + @"\"; }
        }

        private void chkSettingsCustomConnection_CheckedChanged(object sender, EventArgs e)
        {
            // Set UI

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
        }

        private void btnSettingsSave_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Properties.Settings.Default.userLanguage = cmboboxSettingsLanguage.SelectedItem.ToString();
            Properties.Settings.Default.clearDataOnClose = chkSettingsClearData.Checked;
            Properties.Settings.Default.downloadsDirectory = txtBoxSettingsDownloadsDirectory.Text;
            Properties.Settings.Default.connectionCustom = chkSettingsCustomConnection.Checked;
            Properties.Settings.Default.connectionHost = txtBoxSettingsConnectionHost.Text;
            Properties.Settings.Default.connectionPort = txtBoxSettingsConnectionPort.Text;
            Properties.Settings.Default.connectionUsername = txtBoxSettingsConnectionUsername.Text;
            Properties.Settings.Default.connectionPassword = txtBoxSettingsConnectionPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void btnSettingsRestoreDefault_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Properties.Settings.Default.clearDataOnClose = false;
            Properties.Settings.Default.connectionCustom = false;
            Properties.Settings.Default.connectionHost = "";
            Properties.Settings.Default.connectionPort = "";
            Properties.Settings.Default.connectionUsername = "";
            Properties.Settings.Default.connectionPassword = "";
            Properties.Settings.Default.downloadsDirectory = pathDownloadsDefault;

            loadSettings();
        }
    }
}