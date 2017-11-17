using PopcornTimeAPI;
using OMDbAPI;
using DatabaseFilesAPI;
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

        public string Random(ICollection<string> Items)
        {
            Random Rndm = new Random();
            List<string> StringList = new List<string>(Items);
            return StringList[Rndm.Next(0, Items.Count)];
        }

        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();
            return bmp;
        }

        WebClient client = new WebClient();

        public static string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        public static string pathMPCCodec64 = @"C:\Program Files(x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64.exe";
        public static string pathMPC64 = @"C:\Program Files\MPC-HC\mpc-hc64.exe";
        public static string pathMPC86 = @"C:\Program Files (x86)\MPC-HC\mpc-hc.exe";

        private void frmOpenTheatre_Load(object sender, EventArgs e)
        {
            checkForUpdate();

            currentTab = tabMovies;

            Directory.CreateDirectory(pathRoot);
            Directory.CreateDirectory(pathData);
            Directory.CreateDirectory(pathDownloads);

            tabAbout.BackgroundImage = ChangeOpacity(Properties.Resources.background_original, 0.5F);

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
                    if (IsBelowThreshold(pathData + "open-movies.json", 12) == true) // if anime db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkMovies), pathData + "open-movies.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkMovies), pathData + "open-movies.json"); }

                dataMoviesJson = File.ReadAllLines(pathData + "open-movies.json");
                //


                //
                if (File.Exists(pathData + "open-movies-files.json"))
                {
                    if (IsBelowThreshold(pathData + "open-movies-files.json", 12) == true) // if movies db older than 12 hours then write db
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
                    if (IsBelowThreshold(pathData + "open-series-files.json", 12) == true) // if series db older than 12 hours then write db
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
                    if (IsBelowThreshold(pathData + "open-anime-files.json", 12) == true) // if anime db older than 12 hours then write db
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
                    if (IsBelowThreshold(pathData + "open-subtitles-files.json", 12) == true) // if anime db older than 12 hours then write db
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
                    if (IsBelowThreshold(pathData + "open-torrents-files.json", 12) == true) // if anime db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkFilesTorrents), pathData + "open-torrents-files.json");
                    }
                }
                else { client.DownloadFile(new Uri(linkFilesTorrents), pathData + "open-torrents-files.json"); }

                dataFilesTorrents = File.ReadAllLines(pathData + "open-torrents-files.json");
                //


                foreach (string file in dataFilesMovies.Take(10000))
                {
                    var data = DatabaseFiles.FromJson(file);
                    dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL);
                }
            }
            catch (Exception ex) { MessageBox.Show("Unable to load movies.\n\n" + ex.Message); }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadMovies(52);
            Controls.Remove(frmSplash);
        }

        public static string[] dataFilesTorrents;
        public static string[] dataFilesSubtitles;
        public static string[] dataFilesAnime;
        public static string[] dataFilesSeries;
        public static string[] dataFilesMovies;
        public static string[] dataMovies;
        public static string[] dataMoviesJson;

        int countedMovies = 0;
        string selectedGenre = "";
        string selectedYear = "";

        object loadMoviesLock = new object();
        public List<ctrlMoviesPoster> LoadMovies(int loadCount)
        {
            lock (loadMoviesLock)
            {
                List<ctrlMoviesPoster> MoviesPosters = new List<ctrlMoviesPoster>();
                int loadedCount = 0;

                foreach (string movie in dataMoviesJson.Reverse().Skip(countedMovies))
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
                                catch { }

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


        public void checkForUpdate()
        {
            Version newVersion = null;
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(linkLatestVersion);
            StreamReader reader = new StreamReader(stream);
            newVersion = new Version(reader.ReadToEnd());
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            if (curVersion.CompareTo(newVersion) < 0)
            {
                MessageBox.Show("There is a new update available ready to be installed.", "OpenTheatre - Update Available");

                try
                {
                    client.DownloadFile(getLatestInstaller(newVersion), pathDownloadInstaller);
                    Process.Start(pathDownloadInstaller);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to run installer." + Environment.NewLine + Environment.NewLine + ex.Message, "OpenTheatre - Update Error");
                }
            }
        }

        public void showFileDetails(string webFile)
        {
            ctrlDetails MovieDetails = new ctrlDetails();

            string url = "";

            string[] movieName = getMovieAndYear(Path.GetFileNameWithoutExtension(webFile));
            string[] tvshowName = getTVShowName(Path.GetFileNameWithoutExtension(webFile));

            if (!(movieName == null)) { url = "http://omdbapi.com/?apikey=c933e052&t=" + movieName[0] + "&y=" + movieName[1] + "&plot=full"; }
            else if (!(tvshowName == null)) { url = "http://omdbapi.com/?apikey=c933e052&t=" + tvshowName[0] + "&Season=" + tvshowName[1] + "&Episode=" + tvshowName[2]; }

            if (url != "")
            {
                using (WebClient wc = new WebClient())
                {
                    var JsonOMDbAPI = wc.DownloadString(url);
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

                        try { MovieDetails.imgPoster.Image = ChangeOpacity(LoadPicture(data.Poster), 1); } catch { MovieDetails.imgPoster.Image = ChangeOpacity(Properties.Resources.default_poster, 0.5F); }
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


                        MovieDetails.imgPoster.Image = ChangeOpacity(Properties.Resources.default_poster, 0.5F);
                    }
                }
            }

            try
            {
                // Details from Popcorn Time API for Background (fanart/trailer)
                var jsonPopcornTime = client.DownloadString("https://tv-v2.api-fetch.website/movie/" + MovieDetails.infoImdbId);
                var data = PopcornTimeEntity.FromJson(jsonPopcornTime);

                try { tabBlank.BackgroundImage = ChangeOpacity(LoadPicture(data.Images.Fanart), 0.2F); }
                catch { tabBlank.BackgroundImage = ChangeOpacity(Properties.Resources.background_original, 0.2F); }
                MovieDetails.infoFanartUrl = data.Images.Fanart;
                MovieDetails.infoTrailerUrl = data.Trailer;
                //MovieDetails.btnFileTrailer.Visible = true;
            }
            catch
            {
                tabBlank.BackgroundImage = ChangeOpacity(Properties.Resources.background_original, 0.4F);
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

        public string[] getTVShowName(string input)
        {
            string Standard = @"^((?<series_name>.+?)[. _-]+)?s(?<season_num>\d+)[. _-]*e(?<ep_num>\d+)(([. _-]*e|-)(?<extra_ep_num>(?!(1080|720)[pi])\d+))*[. _-]*((?<extra_info>.+?)((?<![. _-])-(?<release_group>[^-]+))?)?$";
            var regexStandard = new Regex(Standard, RegexOptions.IgnoreCase);
            Match episode = regexStandard.Match(input);
            var Showname = episode.Groups["series_name"].Value;
            var Season = episode.Groups["season_num"].Value;
            var Episode = episode.Groups["ep_num"].Value;

            string[] tvshow = { Showname, Season, Episode };
            return tvshow;
        }

        string selectedFiles = "Movies";
        
        private void btnSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (selectedFiles == "Series")
            {
                if (!(txtFilesSearchBox.Text == "")) { searchDatabase(dataFilesSeries); } else { foreach (string file in dataFilesSeries) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); } }
            }
            else if (selectedFiles == "Movies")
            {
                if (!(txtFilesSearchBox.Text == "")) { searchDatabase(dataFilesMovies); } else { foreach (string file in dataFilesMovies) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); } }
            }
            else if (selectedFiles == "Anime")
            {
                if (!(txtFilesSearchBox.Text == "")) { searchDatabase(dataFilesAnime); } else { foreach (string file in dataFilesAnime) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); } }
            }
            else if (selectedFiles == "Subtitles")
            {
                if (!(txtFilesSearchBox.Text == "")) { searchDatabase(dataFilesSubtitles); } else { foreach (string file in dataFilesSubtitles) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); } }
            }
            else if (selectedFiles == "Torrents")
            {
                if (!(txtFilesSearchBox.Text == "")) { searchDatabase(dataFilesTorrents); } else { foreach (string file in dataFilesTorrents) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); } }
            }
        }

        public void searchDatabase(string[] data)
        {
            try
            {
                dataGrid.Rows.Clear();
                string[] keyWords = Regex.Split(txtFilesSearchBox.Text, @"\s+");

                foreach (string file in data)
                {
                    var dataJson = DatabaseFiles.FromJson(file);
                    if (GetWords(txtFilesSearchBox.Text.ToLower()).Any(x => dataJson.URL.ToLower().Contains(x)))
                    {
                        dataGrid.Rows.Add(dataJson.Title, dataJson.Type, dataJson.Host, dataJson.URL);
                    }
                }

                tab.SelectedTab = tabFiles;
            }
            catch { MessageBox.Show("Unable to search database. Please try again in a moment."); }
        }

        static string[] GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");

            var words = from m in matches.Cast<Match>()
                        where !string.IsNullOrEmpty(m.Value)
                        select TrimSuffix(m.Value);

            return words.ToArray();
        }

        static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }

        public string[] getMovieAndYear(string input)
        {
            string pattern = @"(?'title'.*)\.(?'year'[^\.]+)\.(?'pixelsize'[^\.]+)\.(?'format'[^\.]+)\.(?'formatsize'[^\.]+)\.(?'filename'[^\.]+)\.(?'extension'[^\.]+)";
            Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            string extension = match.Groups["extension"].Value;
            string fileName = match.Groups["filename"].Value;
            string formatSize = match.Groups["formatsize"].Value;
            string format = match.Groups["format"].Value;
            string pixelSize = match.Groups["pixelsize"].Value;
            string year = match.Groups["year"].Value;
            string title = match.Groups["title"].Value;
            title = title.Replace(".", " ");

            string[] movie = { title, year };
            return movie;
        }

        public static bool ContainsAll(string source, params string[] values)
        {
            return values.All(x => source.ToLower().Contains(x));
        }

        public bool IsBelowThreshold(string filename, int hours)
        {
            return new FileInfo(filename).LastAccessTime < DateTime.Now.AddHours(-hours);
        }

        private void imgCloseAbout_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = currentTab;
        }

        private void lblAboutReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/invu/OpenTheatre-app/issues/new");
        }

        private void dataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showFileDetails(dataGrid.CurrentRow.Cells[3].Value.ToString());
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

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab.SelectedTab == tabMovies)
            {
                currentTab = tabMovies;
                titleLineMovies.Visible = true;
                titleLineFiles.Visible = false;
                titleLineAbout.Visible = false;
                titleLineDownloads.Visible = false;
            }
            else if (tab.SelectedTab == tabFiles)
            {
                currentTab = tabFiles;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = true;
                titleLineAbout.Visible = false;
                titleLineDownloads.Visible = false;
            }
            else if (tab.SelectedTab == tabDownloads)
            {
                currentTab = tabFiles;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineAbout.Visible = false;
                titleLineDownloads.Visible = true;
            }
            else if (tab.SelectedTab == tabAbout)
            {
                currentTab = tabFiles;
                titleLineMovies.Visible = false;
                titleLineFiles.Visible = false;
                titleLineAbout.Visible = true;
                titleLineDownloads.Visible = false;
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

        private void imgAbout_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabAbout;
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

        // Files Titles
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

            dataGrid.Rows.Clear();
            foreach (string file in dataFilesMovies) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); }
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

            dataGrid.Rows.Clear();
            foreach (string file in dataFilesAnime) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); }
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

            dataGrid.Rows.Clear();
            foreach (string file in dataFilesSeries) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); }
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

            dataGrid.Rows.Clear();
            foreach (string file in dataFilesTorrents) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); }
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

            dataGrid.Rows.Clear();
            foreach (string file in dataFilesSubtitles) { var data = DatabaseFiles.FromJson(file); dataGrid.Rows.Add(data.Title, data.Type, data.Host, data.URL); }

        }
    }
}