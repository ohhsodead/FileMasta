using PopcornTimeAPI;
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

namespace OpenTheatre
{
    public partial class frmOpenTheatre : Form
    {
        public frmOpenTheatre()
        {
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
            if (e.CloseReason == CloseReason.UserClosing) { Properties.Settings.Default.Save(); if (Properties.Settings.Default.clearDataOnClose == true) { Directory.Delete(pathData, true); } }
        }

        private void frmOpenTheatre_Load(object sender, EventArgs e)
        {
            UtilityTools.checkForUpdate();

            if (Properties.Settings.Default.downloadsDirectory == "") { Properties.Settings.Default.downloadsDirectory = pathDownloadsDefault; Directory.CreateDirectory(pathDownloadsDefault); }
            loadSettings();

            currentTab = tabMovies;

            Directory.CreateDirectory(pathRoot);
            Directory.CreateDirectory(pathData);

            tabAbout.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F);
            tabSettings.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F);

            lblAboutVersion.Text = "v" + Application.ProductVersion;

            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }


        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string errorFile = "null";

            try
            {
                //
                if (UtilityTools.doUpdateDataFile(pathData + "open-movies.json") == true)
                {
                    client.DownloadFile(new Uri(linkMovies), pathData + "open-movies.json");
                }

                dataMovies = File.ReadAllLines(pathData + "open-movies.json");
                //


                //
                if (UtilityTools.doUpdateDataFile(pathData + "open-movies-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesMovies), pathData + "open-movies-files.json");
                }

                dataFilesMovies = File.ReadAllLines(pathData + "open-movies-files.json");
                //


                //
                if (UtilityTools.doUpdateDataFile(pathData + "open-series-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesSeries), pathData + "open-series-files.json");
                }

                dataFilesSeries = File.ReadAllLines(pathData + "open-series-files.json");
                //


                //
                if (UtilityTools.doUpdateDataFile(pathData + "open-anime-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesAnime), pathData + "open-anime-files.json");
                }

                dataFilesAnime = File.ReadAllLines(pathData + "open-anime-files.json");
                //


                //
                if (UtilityTools.doUpdateDataFile(pathData + "open-subtitles-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesSubtitles), pathData + "open-subtitles-files.json");
                }

                dataFilesSubtitles = File.ReadAllLines(pathData + "open-subtitles-files.json");
                //


                //
                if (UtilityTools.doUpdateDataFile(pathData + "open-torrents-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesTorrents), pathData + "open-torrents-files.json");
                }

                dataFilesTorrents = File.ReadAllLines(pathData + "open-torrents-files.json");
                //


                //
                if (UtilityTools.doUpdateDataFile(pathData + "open-archives-files.json") == true)
                {
                    client.DownloadFile(new Uri(linkFilesArchives), pathData + "open-archives-files.json");
                }

                dataFilesArchives = File.ReadAllLines(pathData + "open-archives-files.json");
                //
            }
            catch (Exception ex) { MessageBox.Show("We're unable to load database at this time. If this issue persists please open an issue on our GitHub page. (" + errorFile +")\n\n" + ex.Message); }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            searchFiles(dataFilesMovies);
            loadMovies(52);
            Controls.Remove(frmSplash);
        }

        public static string[] dataFilesArchives, dataFilesTorrents, dataFilesSubtitles, dataFilesAnime, dataFilesSeries, dataFilesMovies, dataMovies;
        

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
                currentTab = tabBookmarks;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = true;
                titleLineSettings.Visible = false;
                titleLineAbout.Visible = false;

                searchBookmarks();
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
                currentTab = tabSettings ;
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

                            if (data.Title.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) | data.Actors.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) && data.Year.Contains(selectedYear) && data.Genre.ToLower().Contains(selectedGenre.ToLower()))
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
                                ctrlPoster.infoMovieLinks = data.Sources;

                                try
                                {
                                    string jsonData = client.DownloadString("https://tv-v2.api-fetch.website/movie/" + data.ImdbID);
                                    var jsonDataPT = PopcornTimeEntity.FromJson(jsonData);
                                    ctrlPoster.infoImageFanart = jsonDataPT.Images.Fanart;
                                    ctrlPoster.infoTrailer = jsonDataPT.Trailer;
                                }
                                catch { ctrlPoster.infoImageFanart = ""; ctrlPoster.infoTrailer = ""; }

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
        private void txtMoviesSearchBox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = btnSearchMovies;
        }

        private void txtMoviesSearchBox_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
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
            btnMoviesGenre.Text = "Genre : " + cmboBoxMoviesGenre.SelectedItem.ToString();

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
            btnMoviesYear.Text = "Year : " + cmboBoxMoviesYear.SelectedItem.ToString();

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

            try
            {
                MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.Poster), 1);
            }
            catch { }

            if (data.Poster == "") { MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 1); }

            try
            {
                // Details from Popcorn Time API for Background (fanart/trailer)
                var jsonPopcornTime = client.DownloadString("https://tv-v2.api-fetch.website/movie/" + MovieDetails.infoImdbId);
                var dataPT = PopcornTimeEntity.FromJson(jsonPopcornTime);

                try { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(dataPT.Images.Fanart), 0.2F); }
                catch { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.2F); }
                MovieDetails.infoFanartUrl = dataPT.Images.Fanart;
                MovieDetails.infoTrailerUrl = dataPT.Trailer;
            }
            catch
            {
                MovieDetails.infoFanartUrl = "";
                MovieDetails.infoTrailerUrl = "";
            }

            if (MovieDetails.infoFanartUrl == "") { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F); }
            if (MovieDetails.infoTrailerUrl == "") { MovieDetails.btnWatchTrailer.Visible = false; }

            foreach (string movieLink in data.Sources)
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.infoFileURL = new Uri(movieLink).AbsoluteUri;
                ctrlInfo.infoFileHost.Text = new Uri(movieLink).Host.Replace("www.", "");
                ctrlInfo.infoFileName.Text = Path.GetFileNameWithoutExtension(new Uri(movieLink).LocalPath);
                MovieDetails.panelStreams.Controls.Add(ctrlInfo);
            }

            MovieDetails.Dock = DockStyle.Fill;
            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(MovieDetails);
            imgSpinner.Visible = false;
            tab.SelectedTab = tabBlank;
        }

        // Files (& Sub Tabs)
        string selectedFilesFileType = "", selectedFilesHost = "", selectedFilesQuality = "", selectedFiles = "Movies"; // Files Filter Preferences

        private void titleFilesMovies_ClickButtonArea(object Sender, MouseEventArgs e)
        {
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

            searchFiles(dataFilesMovies);
        }

        private void titleFilesAnime_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Anime";

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

            searchFiles(dataFilesAnime);
        }

        private void titleFilesSeries_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Series";

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

            searchFiles(dataFilesSeries);
        }

        private void titleFilesTorrents_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Torrents";

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

            searchFiles(dataFilesTorrents);
        }

        private void titleFilesSubtitles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Subtitles";

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

            searchFiles(dataFilesSubtitles);
        }


        private void titleFilesArchives_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Archives";

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

            searchFiles(dataFilesArchives);
        }

        private void dataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGridFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showFileDetails(dataGridFiles.CurrentRow.Cells[3].Value.ToString());
        }

        public void showSelectedFiles()
        {
            if (selectedFiles == "Series")
            {
                searchFiles(dataFilesSeries);
            }
            else if (selectedFiles == "Movies")
            {
                searchFiles(dataFilesMovies);
            }
            else if (selectedFiles == "Anime")
            {
                searchFiles(dataFilesAnime);
            }
            else if (selectedFiles == "Subtitles")
            {
                searchFiles(dataFilesSubtitles);
            }
            else if (selectedFiles == "Torrents")
            {
                searchFiles(dataFilesTorrents);
            }
            else if (selectedFiles == "Archives")
            {
                searchFiles(dataFilesArchives);
            }
        }

        private void btnSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            showSelectedFiles();
        }

        public void searchFiles(string[] data)
        {
            string errorFile = "null";

            try
            {
                cmboBoxFilesSort.SelectedIndex = 0;
                cmboBoxFilesHost.Items.Clear();
                cmboBoxFilesHost.Items.Add("Any");
                cmboBoxFilesFormat.Items.Clear();
                cmboBoxFilesFormat.Items.Add("Any");
                dataGridFiles.Rows.Clear();
                string[] keyWords = Regex.Split(txtFilesSearchBox.Text, @"\s+");

                foreach (string file in data)
                {
                    errorFile = file;
                    var dataJson = DatabaseFilesEntity.FromJson(file);

                    if (UtilityTools.ContainsAll(dataJson.URL.ToLower(), UtilityTools.GetWords(txtFilesSearchBox.Text.ToLower())) && dataJson.URL.Contains(selectedFilesQuality) && dataJson.Type.Contains(selectedFilesFileType) && dataJson.Host.Contains(selectedFilesHost))
                    {
                        dataGridFiles.Rows.Add(dataJson.Title, dataJson.Type, dataJson.Host, dataJson.URL);
                        if (!(cmboBoxFilesFormat.Items.Contains(dataJson.Type))) { cmboBoxFilesFormat.Items.Add(dataJson.Type); }
                        if (!(cmboBoxFilesHost.Items.Contains(dataJson.Host))) { cmboBoxFilesHost.Items.Add(dataJson.Host); }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Unable to search database. Please try again in a moment. (" + errorFile +")\n\n" + ex.Message); }
        }

        public void showFileDetails(string webFile)
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
                try
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
                catch (Exception ex) { }
            }

            try
            {
                // Details from Popcorn Time API for Background (fanart/trailer)
                var jsonPopcornTime = client.DownloadString("https://tv-v2.api-fetch.website/movie/" + MovieDetails.infoImdbId);
                var data = PopcornTimeEntity.FromJson(jsonPopcornTime);

                try { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(data.Images.Fanart), 0.2F); }
                catch { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.2F); }
                MovieDetails.infoFanartUrl = data.Images.Fanart;
                MovieDetails.infoTrailerUrl = data.Trailer;
            }
            catch
            {
                MovieDetails.infoFanartUrl = "";
                MovieDetails.infoTrailerUrl = "";
            }

            if (MovieDetails.infoFanartUrl == "") { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F); }
            if (MovieDetails.infoTrailerUrl == "") { MovieDetails.btnWatchTrailer.Visible = false; }

            ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
            ctrlInfo.infoFileURL = new Uri(webFile).AbsoluteUri;
            ctrlInfo.infoFileHost.Text = new Uri(webFile).Host.Replace("www.", "");
            ctrlInfo.infoFileName.Text = Path.GetFileNameWithoutExtension(new Uri(webFile).LocalPath);
            MovieDetails.panelStreams.Controls.Add(ctrlInfo);

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

        private void txtFilesSearchBox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = btnSearchFiles;
        }

        private void txtFilesSearchBox_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null; //
        }

        // Sort Files 
        private void btnFilesSort_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesSort.DroppedDown = true;
        }

        private void cmboBoxFilesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFilesSort.Text = "Sort : " + cmboBoxFilesSort.SelectedItem.ToString();

            Font myFont = new Font(btnFilesSort.Font.FontFamily, this.btnFilesSort.Font.Size);
            SizeF mySize = btnFilesSort.CreateGraphics().MeasureString(btnFilesSort.Text, myFont);
            panelFilesSort.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxFilesSort.SelectedIndex == 0) { cmboBoxFilesSort.DropDownWidth = DropDownWidth(cmboBoxFilesSort); showSelectedFiles(); }
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
            return maxWidth - 10;
        }

        private void btnFilesFileType_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesFormat.DroppedDown = true;
        }

        private void cmboBoxFilesFileFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFilesFormat.Text = "Format : " + cmboBoxFilesFormat.SelectedItem.ToString();

            Font myFont = new Font(btnFilesFormat.Font.FontFamily, this.btnFilesFormat.Font.Size);
            SizeF mySize = btnFilesFormat.CreateGraphics().MeasureString(btnFilesFormat.Text, myFont);
            panelFilesFormat.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();

            if (cmboBoxFilesFormat.SelectedIndex == 0) { selectedFilesFileType = ""; }
            else { selectedFilesFileType = cmboBoxFilesFormat.SelectedItem.ToString(); }

            showSelectedFiles();
        }

        // Filter Files by Host
        private void btnFilesHost_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesHost.DroppedDown = true;
        }

        private void cmboBoxFilesHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFilesHost.Text = "Host : " + cmboBoxFilesHost.SelectedItem.ToString();

            Font myFont = new Font(btnFilesHost.Font.FontFamily, this.btnFilesHost.Font.Size);
            SizeF mySize = btnFilesHost.CreateGraphics().MeasureString(btnFilesHost.Text, myFont);
            panelFilesHost.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxFilesHost.SelectedIndex == 0) { selectedFilesHost = ""; }
            else { selectedFilesHost = cmboBoxFilesHost.SelectedItem.ToString(); }

            showSelectedFiles();

            cmboBoxFilesHost.DropDownWidth = DropDownWidth(cmboBoxFilesHost);
        }

        // Filter Files by Quality
        private void btnFilesQuality_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxFilesQuality.DroppedDown = true;
        }

        private void cmboBoxFilesQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFilesQuality.Text = "Quality : " + cmboBoxFilesQuality.SelectedItem.ToString();

            Font myFont = new Font(btnFilesQuality.Font.FontFamily, this.btnFilesQuality.Font.Size);
            SizeF mySize = btnFilesQuality.CreateGraphics().MeasureString(btnFilesQuality.Text, myFont);
            panelFilesQuality.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxFilesQuality.SelectedIndex == 0) { selectedFilesQuality = ""; }
            else { selectedFilesQuality = cmboBoxFilesQuality.SelectedItem.ToString(); }

            showSelectedFiles();
        }
        //

        // Bookmarks
        string selectedBookmarksType = "";
        
        private void dataGridBookmarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showFileDetails(dataGridBookmarks.CurrentRow.Cells[4].Value.ToString());
        }

        public void searchBookmarks()
        {
            try
            {
                dataGridBookmarks.Rows.Clear();

                foreach (string fileUrl in Properties.Settings.Default.dataBookmarks)
                {
                    var url = new Uri(fileUrl);
                    if (UtilityTools.ContainsAll(fileUrl.ToLower(), UtilityTools.GetWords(txtBookmarksSearchBox.Text.ToLower())) && UtilityTools.getContainingListOfURL(fileUrl).Contains(selectedBookmarksType))
                    {
                        dataGridBookmarks.Rows.Add(UtilityTools.getContainingListOfURL(fileUrl), Path.GetFileName(new Uri(fileUrl).LocalPath), Path.GetExtension(fileUrl).Replace(".", "").ToUpper(), new Uri(fileUrl).Host, new Uri(fileUrl).AbsoluteUri);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("There was a problem searching for your bookmarks.\n\n" + ex.Message); }
        }

        // Search Bookmarks by Text
        private void btnSearchBookmarks_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            searchBookmarks();
        }
        
        private void txtBookmarksSearchBox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = btnSearchBookmarks;
        }

        private void txtBookmarksSearchBox_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
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
            btnBookmarksSort.Text = "Sort : " + cmboBoxBookmarksSort.SelectedItem.ToString();

            Font myFont = new Font(btnBookmarksSort.Font.FontFamily, this.btnBookmarksSort.Font.Size);
            SizeF mySize = btnBookmarksSort.CreateGraphics().MeasureString(btnBookmarksSort.Text, myFont);
            panelBookmarksSort.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxBookmarksSort.SelectedIndex == 0) { cmboBoxBookmarksSort.DropDownWidth = DropDownWidth(cmboBoxBookmarksSort); searchBookmarks(); }
            else if (cmboBoxBookmarksSort.SelectedIndex == 1) { dataGridBookmarks.Sort(dataGridBookmarks.Columns[1], ListSortDirection.Ascending); }
            else if (cmboBoxBookmarksSort.SelectedIndex == 2) { dataGridBookmarks.Sort(dataGridBookmarks.Columns[1], ListSortDirection.Descending); }
        }

        // Filter Bookmarks by Type
        private void btnBookmarksType_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            cmboBoxBookmarksType.DroppedDown = true;
        }

        private void cmboBoxBookmarksType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBookmarksType.Text = "Type : " + cmboBoxBookmarksType.SelectedItem.ToString();

            Font myFont = new Font(btnBookmarksType.Font.FontFamily, this.btnBookmarksType.Font.Size);
            SizeF mySize = btnBookmarksType.CreateGraphics().MeasureString(btnBookmarksType.Text, myFont);
            panelBookmarksType.Width = (((int)(Math.Round(mySize.Width, 0))) + 26);
            Refresh();
            if (cmboBoxBookmarksType.SelectedIndex == 0) { selectedBookmarksType = ""; searchBookmarks(); }
            else { selectedBookmarksType = cmboBoxBookmarksType.SelectedItem.ToString(); searchBookmarks(); }
        }
        //

        // Downloads tab
        public static List<string> currentDownloads = new List<string>();

        public void doDownloadFile(string fileURL)
        {
            ctrlDownloadItem ctrlItem = new ctrlDownloadItem();
            ctrlItem.progressBar1.BorderColor = tabDownloads.BackColor;
            ctrlItem.infoStatus.Text = "Connecting";
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
            Process.Start("https://github.com/invu/opentheatre-app/issues/new");
        }
        //

        // Settings tab
        public void loadSettings()
        {
            // UI
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

        private void chkSettingsClearData_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.clearDataOnClose = chkSettingsClearData.Checked;
        }

        private void imgSettingsDownloadsDirectory_Click(object sender, EventArgs e)
        {
            var a = new FolderBrowserDialog();
            if (a.ShowDialog() == DialogResult.OK) { Properties.Settings.Default.downloadsDirectory = a.SelectedPath + @"\"; txtBoxSettingsDownloadsDirectory.WaterMark = Properties.Settings.Default.downloadsDirectory; txtBoxSettingsDownloadsDirectory.Text = Properties.Settings.Default.downloadsDirectory; }
        }

        private void chkSettingsCustomConnection_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.connectionCustom = chkSettingsCustomConnection.Checked;

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