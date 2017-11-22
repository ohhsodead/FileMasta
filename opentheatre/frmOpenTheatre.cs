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

        private BackgroundWorker worker;

        public static frmOpenTheatre form = null;
        public ctrlSplashScreen frmSplash;
        protected override void OnPaint(PaintEventArgs e) { }

        public static string linkFilesMovies = "https://dl.dropbox.com/s/jtac1zhsdhy6931/open-movies-files.json?dl=0";
        public static string linkFilesSeries = "https://dl.dropbox.com/s/2ze0xayim0cgk70/open-series-files.json?dl=0";
        public static string linkFilesAnime = "https://dl.dropbox.com/s/e5lhyejb56cwo9k/open-anime-files.json?dl=0";
        public static string linkFilesSubtitles = "https://dl.dropbox.com/s/ckkxsogprgviyto/open-subtitles-files.json?dl=0";
        public static string linkFilesTorrents = "https://dl.dropbox.com/s/nkzzyk4vr6k4rlr/open-torrents-files.json?dl=0"; 
        public static string linkMovies = "https://dl.dropbox.com/s/ionv8bszlgvf1xc/open-movies.json?dl=0";
        public static string linkLatestVersion = "https://raw.githubusercontent.com/invu/opentheatre-app/master/assets/opentheatre-version.txt";
        public static string pathInstallerFileName = "OpenTheatreInstaller.exe";
        public static string pathDownloadInstaller = KnownFolders.GetPath(KnownFolder.Downloads) + @"\" + pathInstallerFileName;
        public static string pathRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenTheatre\";
        public static string pathData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenTheatre\Data\";
        public static string pathDownloads = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenTheatre\Downloads\";

        public static string getLatestInstaller(Version newVersion)
        {
            return "https://github.com/invu/opentheatre-app/releases/download/" + newVersion.ToString() + "/" + pathInstallerFileName;
        }

        public static Bitmap LoadPicture(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            catch
            {
                // Do nothing... 
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }

        WebClient client = new WebClient();

        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public static string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public static string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public static string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";

        private void frmOpenTheatre_Load(object sender, EventArgs e)
        {
            UtilityTools.checkForUpdate();

            currentTab = tabMovies;

            Directory.CreateDirectory(pathRoot);
            Directory.CreateDirectory(pathData);
            Directory.CreateDirectory(pathDownloads);

            tabAbout.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F);

            lblAboutVersion.Text = "v" + Application.ProductVersion;

            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }


        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //
                if (File.Exists(pathData + "open-movies.json"))
                {
                    if (UtilityTools.IsBelowThreshold(pathData + "open-movies.json", 12) == true) // if movie posters db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkMovies), pathData + "open-movies.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkMovies), pathData + "open-movies.json"); }

                dataMovies = File.ReadAllLines(pathData + "open-movies.json");
                //


                //
                if (File.Exists(pathData + "open-movies-files.json"))
                {
                    if (UtilityTools.IsBelowThreshold(pathData + "open-movies-files.json", 12) == true) // if movies db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkFilesMovies), pathData + "open-movies-files.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkFilesMovies), pathData + "open-movies-files.json"); }

                dataFilesMovies = File.ReadAllLines(pathData + "open-movies-files.json");
                //


                //
                if (File.Exists(pathData + "open-series-files.json"))
                {
                    if (UtilityTools.IsBelowThreshold(pathData + "open-series-files.json", 12) == true) // if series db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkFilesSeries), pathData + "open-series-files.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkFilesSeries), pathData + "open-series-files.json"); }

                dataFilesSeries = File.ReadAllLines(pathData + "open-series-files.json");
                //


                //
                if (File.Exists(pathData + "open-anime-files.json"))
                {
                    if (UtilityTools.IsBelowThreshold(pathData + "open-anime-files.json", 12) == true) // if anime db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkFilesAnime), pathData + "open-anime-files.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkFilesAnime), pathData + "open-anime-files.json"); }

                dataFilesAnime = File.ReadAllLines(pathData + "open-anime-files.json");
                //


                //
                if (File.Exists(pathData + "open-subtitles-files.json"))
                {
                    if (UtilityTools.IsBelowThreshold(pathData + "open-subtitles-files.json", 12) == true) // if subtitles db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkFilesSubtitles), pathData + "open-subtitles-files.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkFilesSubtitles), pathData + "open-subtitles-files.json"); }

                dataFilesSubtitles = File.ReadAllLines(pathData + "open-subtitles-files.json");
                //


                //
                if (File.Exists(pathData + "open-torrents-files.json"))
                {
                    if (UtilityTools.IsBelowThreshold(pathData + "open-torrents-files.json", 12) == true) // if torrents db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkFilesTorrents), pathData + "open-torrents-files.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkFilesTorrents), pathData + "open-torrents-files.json"); }

                dataFilesTorrents = File.ReadAllLines(pathData + "open-torrents-files.json");
                //
                
                foreach (string file in dataFilesMovies)
                {
                    var data = DatabaseFilesEntity.FromJson(file);
                    dataGridFiles.Rows.Add(data.Title, data.Type, data.Host, data.URL);
                    if (!(cmboBoxFilesFormat.Items.Contains(data.Type))) { cmboBoxFilesFormat.Items.Add(data.Type); }
                    if (!(cmboBoxFilesHost.Items.Contains(data.Host))) { cmboBoxFilesHost.Items.Add(data.Host); }
                }

                cmboBoxFilesHost.DropDownWidth = DropDownWidth(cmboBoxFilesHost);

                foreach (string fileUrl in Properties.Settings.Default.Bookmarks)
                {
                    dataGridBookmarks.Rows.Add(UtilityTools.getContainingListOfURL(fileUrl), Path.GetFileName(new Uri(fileUrl).LocalPath), Path.GetExtension(fileUrl).Replace(".", "").ToUpper(), new Uri(fileUrl).Host, new Uri(fileUrl).AbsoluteUri);
                }
            }
            catch (Exception ex) { MessageBox.Show("Unable to load movies.\n\n" + ex.Message); }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadMovies(52);
            Controls.Remove(frmSplash);
        }

        public static string[] dataFilesTorrents, dataFilesSubtitles, dataFilesAnime, dataFilesSeries, dataFilesMovies, dataMovies, dataBookmarks;
        
        // Load/Show Movies
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

                                ctrlPoster.infoGenres = data.Genre;
                                ctrlPoster.infoSynopsis = data.Plot;
                                ctrlPoster.infoRuntime = data.Runtime;
                                ctrlPoster.infoRated = data.Rated;
                                ctrlPoster.infoDirector = data.Director;
                                ctrlPoster.infoCast = data.Actors;

                                ctrlPoster.infoImdbRating = data.ImdbRating;
                                ctrlPoster.infoImdbId = data.ImdbID;

                                ctrlPoster.infoPoster.BackgroundImage = LoadPicture(data.Poster);
                                ctrlPoster.infoImagePoster = data.Poster;
                                ctrlPoster.Name = data.ImdbID;
                                ctrlPoster.infoMovieLinks = data.Sources;

                                try
                                {
                                    string jsonData = client.DownloadString("https://tv-v2.api-fetch.website/movie/" + data.ImdbID);
                                    var jsonDataPT = PopcornTimeEntity.FromJson(jsonData);
                                    ctrlPoster.infoImageFanart = jsonDataPT.Images.Fanart;
                                }
                                catch { ctrlPoster.infoImageFanart = ""; }

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
            imgSpinnerGIF.Visible = true;
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

                    imgSpinnerGIF.Visible = false;
                    tab.SelectedTab = tabMovies;
                }
            });
        }


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
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabFiles)
            {
                currentTab = tabFiles;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = true;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = false;
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabDownloads)
            {
                currentTab = tabFiles;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = true;
                titleLineBookmarks.Visible = false;
                titleLineAbout.Visible = false;
            }
            else if (tab.SelectedTab == tabBookmarks)
            {
                currentTab = tabBookmarks;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = true;
                titleLineAbout.Visible = false;

                searchBookmarks();
            }
            else if (tab.SelectedTab == tabAbout)
            {
                currentTab = tabFiles;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineDownloads.Visible = false;
                titleLineBookmarks.Visible = false;
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

        private void btnSearchMovies_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            panelMovies.Controls.Clear();
            countedMovies = 0;
            loadMovies(52);
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


        // Files (& Sub Tabs)
        string selectedFilesFileType = "", selectedFilesHost = "", selectedFilesQuality = "", selectedFiles = "Movies"; // Files Filter Preferences

        private void titleFilesMovies_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Movies";

            titleFilesMovies.ColorFillSolid = Color.FromArgb(27, 27, 27);
            titleFilesMovies.BorderColor = Color.FromArgb(27, 27, 27);
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;

            searchFiles(dataFilesMovies);
        }

        private void titleFilesAnime_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Anime";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.Transparent;
            titleFilesSeries.BorderColor = Color.Transparent;
            titleFilesAnime.ColorFillSolid = Color.FromArgb(27, 27, 27);
            titleFilesAnime.BorderColor = Color.FromArgb(27, 27, 27);
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;

            searchFiles(dataFilesAnime);
        }

        private void titleFilesSeries_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            selectedFiles = "Series";

            titleFilesMovies.ColorFillSolid = Color.Transparent;
            titleFilesMovies.BorderColor = Color.Transparent;
            titleFilesSeries.ColorFillSolid = Color.FromArgb(27, 27, 27);
            titleFilesSeries.BorderColor = Color.FromArgb(27, 27, 27);
            titleFilesAnime.ColorFillSolid = Color.Transparent;
            titleFilesAnime.BorderColor = Color.Transparent;
            titleFilesSubtitles.ColorFillSolid = Color.Transparent;
            titleFilesSubtitles.BorderColor = Color.Transparent;
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;

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
            titleFilesTorrents.ColorFillSolid = Color.FromArgb(27, 27, 27);
            titleFilesTorrents.BorderColor = Color.FromArgb(27, 27, 27);

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
            titleFilesSubtitles.ColorFillSolid = Color.FromArgb(27, 27, 27);
            titleFilesSubtitles.BorderColor = Color.FromArgb(27, 27, 27);
            titleFilesTorrents.ColorFillSolid = Color.Transparent;
            titleFilesTorrents.BorderColor = Color.Transparent;

            searchFiles(dataFilesSubtitles);
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
        }

        private void btnSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            showSelectedFiles();
        }

        public void searchFiles(string[] data)
        {
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
                    var dataJson = DatabaseFilesEntity.FromJson(file);

                    if (UtilityTools.ContainsAll(dataJson.URL.ToLower(), UtilityTools.GetWords(txtFilesSearchBox.Text.ToLower())) && dataJson.URL.Contains(selectedFilesQuality) && dataJson.Type.Contains(selectedFilesFileType) && dataJson.Host.Contains(selectedFilesHost))
                    {
                        dataGridFiles.Rows.Add(dataJson.Title, dataJson.Type, dataJson.Host, dataJson.URL);
                        if (!(cmboBoxFilesFormat.Items.Contains(dataJson.Type))) { cmboBoxFilesFormat.Items.Add(dataJson.Type); }
                        if (!(cmboBoxFilesHost.Items.Contains(dataJson.Host))) { cmboBoxFilesHost.Items.Add(dataJson.Host); }
                    }
                }

                tab.SelectedTab = tabFiles;
            }
            catch { MessageBox.Show("Unable to search database. Please try again in a moment."); }
        }

        public void showFileDetails(string webFile)
        {
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

                            try { MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(LoadPicture(data.Poster), 1); } catch { MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 0.5F); }
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

                try { tabBlank.BackgroundImage = UtilityTools.ChangeOpacity(LoadPicture(data.Images.Fanart), 0.2F); }
                catch { tabBlank.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.2F); }
                MovieDetails.infoFanartUrl = data.Images.Fanart;
                MovieDetails.infoTrailerUrl = data.Trailer;
                //MovieDetails.btnFileTrailer.Visible = true;
            }
            catch
            {
                tabBlank.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.4F);
                MovieDetails.infoFanartUrl = "";
                MovieDetails.infoTrailerUrl = "";
                //MovieDetails.btnFileTrailer.Visible = false;
            }

            ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
            ctrlInfo.infoFileURL = webFile;
            ctrlInfo.infoFileHost.Text = new Uri(webFile).Host;
            ctrlInfo.infoFileName.Text = Path.GetFileName(new Uri(webFile).LocalPath);
            MovieDetails.panelStreams.Controls.Add(ctrlInfo);
            MovieDetails.Dock = DockStyle.Fill;
            tabBlank.Controls.Clear();
            tabBlank.Controls.Add(MovieDetails);
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

        private void frmOpenTheatre_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
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
            if (cmboBoxFilesSort.SelectedIndex == 0) { cmboBoxFilesHost.DropDownWidth = DropDownWidth(cmboBoxFilesHost); showSelectedFiles(); }
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
        }


        // Bookmarks
        string selectedBookmarksType = "";
        
        private void dataGridBookmarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showFileDetails(dataGridBookmarks.CurrentRow.Cells[4].Value.ToString());
        }

        public void addToBookmarks(string fileUrl)
        {
            DatabaseFilesEntity data = new DatabaseFilesEntity();
            data.Title = Path.GetFileName(new Uri(fileUrl).LocalPath);
            data.URL = new Uri(fileUrl).AbsoluteUri;
            data.Host = new Uri(fileUrl).Host;
            data.Type = Path.GetExtension(fileUrl).Replace(".", "").ToUpper();
        }

        public void searchBookmarks()
        {
            dataGridBookmarks.Rows.Clear();

            foreach (string fileUrl in Properties.Settings.Default.Bookmarks)
            {
                var url = new Uri(fileUrl);
                if (UtilityTools.ContainsAll(fileUrl.ToLower(), UtilityTools.GetWords(txtBookmarksSearchBox.Text.ToLower())) && UtilityTools.getContainingListOfURL(fileUrl).Contains(selectedBookmarksType))
                {
                    dataGridBookmarks.Rows.Add(UtilityTools.getContainingListOfURL(fileUrl), Path.GetFileName(new Uri(fileUrl).LocalPath), Path.GetExtension(fileUrl).Replace(".", "").ToUpper(), new Uri(fileUrl).Host, new Uri(fileUrl).AbsoluteUri);
                }
            }
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
            if (cmboBoxBookmarksSort.SelectedIndex == 0) { searchBookmarks(); }
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


        // Downloads 
        public void doDownloadFile(string url)
        {
            ctrlDownloadItem ctrlItem = new ctrlDownloadItem();
            ctrlItem.lblPercentage.Text = "Connecting...";
            ctrlItem.Width = panelDownloads.ClientSize.Width - 7;
            panelDownloads.Controls.Add(ctrlItem);
            ctrlItem.doDownloadFile(url);
        }

        private void panelDownloadItems_ControlAdded(object sender, ControlEventArgs e)
        {
            if (panelDownloads.Controls.Count == 0) { lblNoDownloads.Visible = true; } else { lblNoDownloads.Visible = false; }
        }

        private void panelDownloadItems_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (panelDownloads.Controls.Count == 0) { lblNoDownloads.Visible = true; } else { lblNoDownloads.Visible = false; }
        }


        // About tab
        private void imgCloseAbout_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = currentTab;
        }

        private void lblAboutReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/invu/OpenTheatre-app/issues/new");
        }

    }
}