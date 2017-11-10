using PopcornTimeAPI;
using OMDbAPI;
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

namespace OpenPlex
{
    public partial class frmOpenPlex : Form
    {
        public frmOpenPlex()
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

        public static frmOpenPlex form = null;
        public ctrlSplashScreen frmSplash;
        protected override void OnPaint(PaintEventArgs e) { }

        public static string linkMovies = "https://raw.githubusercontent.com/invu/openplex-app/master/Assets/openplex-movies-db.txt";
        public static string linkLatestVersion = "https://raw.githubusercontent.com/invu/openplex-app/master/Assets/openplex-version.txt";
        public static string pathInstallerFileName = "OpenPlexInstaller.exe";
        public static string pathDownloadInstaller = KnownFolders.GetPath(KnownFolder.Downloads) + @"\" + pathInstallerFileName;
        public static string pathRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenPlex\";
        public static string pathData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenPlex\Data\";
        public static string pathDownloads = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OpenPlex\Downloads\";

        public static string getLatestInstaller(Version newVersion)
        {
            return "https://github.com/invu/openplex-app/releases/download/" + newVersion.ToString() + "/" + pathInstallerFileName;
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

        private void frmOpenPlex_Load(object sender, EventArgs e)
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
                if (File.Exists(pathData + "openplex-movies-db.txt"))
                {
                    if (IsBelowThreshold(pathData + "openplex-movies-db.txt", 12) == true) // if movies db older than 12 hours then write db
                    {
                        client.DownloadFile(new Uri(linkMovies), pathData + "openplex-movies-db.txt");
                    }
                }
                else { client.DownloadFile(new Uri(linkMovies), pathData + "openplex-movies-db.txt"); }

                dataMovies = File.ReadAllLines(pathData + "openplex-movies-db.txt");


                try
                {
                    if (File.Exists(pathData + "openplex-movies-db.json")) // if json db exists
                    {
                        if (IsBelowThreshold(pathData + "openplex-movies-db.json", 12) == true) // if movies json db older than 12 hours then write json db
                        {
                            if (File.Exists(pathData + "openplex-movies-db.json")) { File.Delete(pathData + "openplex-movies-db.json"); }
                            using (StreamWriter sw = File.CreateText(pathData + "openplex-movies-db.json"))
                            {
                                foreach (string movie in dataMovies)
                                {
                                    try
                                    {
                                        string[] movieCredentials = movie.Split('~');
                                        var jsonOMDb = client.DownloadString("http://omdbapi.com/?apikey=c933e052&t=" + movieCredentials[0] + "&y=" + movieCredentials[1] + "&plot=short");
                                        var data = OMDbEntity.FromJson(jsonOMDb);
                                        if (data.Response == "True")
                                        {
                                            data.Sources = movieCredentials[2].Split('*');
                                            sw.WriteLine(data.ToJson());
                                        }
                                    }
                                    catch { }
                                }
                                sw.Close();
                                sw.Dispose();
                            }
                        }
                    }
                    else // if json db doesn't exist
                    {
                        if (File.Exists(pathData + "openplex-movies-db.json")) { File.Delete(pathData + "openplex-movies-db.json"); }
                        using (StreamWriter sw = File.CreateText(pathData + "openplex-movies-db.json"))
                        {
                            foreach (string movie in dataMovies)
                            {
                                try
                                {
                                    string[] movieCredentials = movie.Split('~');
                                    var jsonOMDb = client.DownloadString("http://omdbapi.com/?apikey=c933e052&t=" + movieCredentials[0] + "&y=" + movieCredentials[1] + "&plot=short");
                                    var data = OMDbEntity.FromJson(jsonOMDb);
                                    if (data.Response == "True")
                                    {
                                        data.Sources = movieCredentials[2].Split('*');
                                        sw.WriteLine(data.ToJson());
                                    }
                                }
                                catch { }
                            }
                            sw.Close();
                            sw.Dispose();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Unable to convert Json database. The app will be restarted.\n\n" + ex.Message); Directory.Delete(pathRoot, true); Application.Restart(); }


                dataMoviesJson = File.ReadAllLines(pathData + "openplex-movies-db.json");

                foreach (string movie in dataMovies)
                {
                    string[] movieCredentials = movie.Split('~');
                    foreach (string movie1 in movieCredentials[2].Split('*'))
                    {
                        dataFiles.Add(movie1);
                    }
                }

                foreach (string file in dataFiles.Take(100))
                {
                    dataGrid.Rows.Add(Path.GetFileNameWithoutExtension(new Uri(file).LocalPath), Path.GetExtension(file).Replace(".", "").ToUpper(), new Uri(file).Host.Replace("www.", ""), file);
                }
            }
            catch (Exception ex) { MessageBox.Show("Unable to load movies.\n\n" + ex.Message); }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadMovies(52);
            Controls.Remove(frmSplash);
        }

        public static string[] dataMovies;
        public static string[] dataMoviesJson;
        public static List<string> dataFiles = new List<string>();

        int countedMovies = 0;
        string selectedGenre = "";

        List<ctrlMoviesPoster> MoviesPosters = new List<ctrlMoviesPoster>();
        public List<ctrlMoviesPoster> LoadMovies(int loadCount)
        {
            int loadedCount = 0;

            foreach (string movie in dataMoviesJson.Reverse().Skip(countedMovies))
            {
                if (loadedCount < loadCount)
                {
                    if (string.IsNullOrEmpty(movie) == false)
                    {
                        try
                        {
                            var data = OMDbEntity.FromJson(movie);

                            if (data.Title.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) | data.Actors.ToLower().Contains(txtMoviesSearchBox.Text.ToLower()) | data.Year == txtMoviesSearchBox.Text && data.Genre.ToLower().Contains(selectedGenre.ToLower()))
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
                        catch (Exception ex) { MessageBox.Show("Unable to read Json database. The app will be restarted.\n\n" + ex.Message); Directory.Delete(pathRoot, true); Application.Restart(); }

                    }
                }
            }
            return MoviesPosters;
        }

        delegate void loadMoviesCallBack(int count);
        public void loadMovies(int count)
        {
            MoviesPosters = new List<ctrlMoviesPoster>();
            BackGroundWorker.RunWorkAsync<List<ctrlMoviesPoster>>(() => LoadMovies(count), (data) =>
             {
                 if (panelMovies.InvokeRequired)
                 {
                     loadMoviesCallBack b = new loadMoviesCallBack(loadMovies);
                     Invoke(b, new object[] { count });
                 }
                 else
                 {
                     try
                     {
                         foreach (ctrlMoviesPoster item in data)
                         {
                             panelMovies.Controls.Add(item);
                         }
                     }
                     catch { }
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
                MessageBox.Show("There is a new update available ready to be installed.", "OpenPlex - Update Available");

                try
                {
                    client.DownloadFile(getLatestInstaller(newVersion), pathDownloadInstaller);
                    Process.Start(pathDownloadInstaller);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to run installer." + Environment.NewLine + Environment.NewLine + ex.Message, "OpenPlex - Update Error");
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

        private void btnSearchFiles_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            if (!(txtFilesSearchBox.Text == "")) { searchDatabase(txtFilesSearchBox.Text); }
        }

        public void searchDatabase(string text)
        {
            try
            {
                dataGrid.Rows.Clear();
                string[] keyWords = Regex.Split(txtFilesSearchBox.Text, @"\s+");

                foreach (string file in dataFiles)
                {
                    if (GetWords(txtFilesSearchBox.Text.ToLower()).Any(x => Path.GetFileNameWithoutExtension(file.ToLower()).Contains(x)))
                    {
                        dataGrid.Rows.Add(Path.GetFileNameWithoutExtension(new Uri(file).LocalPath), Path.GetExtension(file).Replace(".", "").ToUpper(), new Uri(file).Host.Replace("www.", ""), file);
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
            Process.Start("https://github.com/invu/openplex-app/issues/new");
        }

        private void dataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showFileDetails(dataGrid.CurrentRow.Cells[3].Value.ToString());
        }

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
            else if(tab.SelectedTab == tabFiles)
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
    }
}
