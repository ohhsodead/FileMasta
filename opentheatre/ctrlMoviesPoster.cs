using Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using UnhandledExceptions;

namespace OpenTheatre
{

    public partial class ctrlMoviesPoster : UserControl
    {
        public ctrlMoviesPoster()
        {
            InitializeComponent();
        }

        public string infoGenres;
        public string infoSynopsis;
        public string infoRuntime;
        public string infoRated;
        public string infoDirector;
        public string infoCast;
        public string infoImdbId;
        public string infoImdbRating;
        public string infoImagePoster;
        public string infoImageFanart;
        public string infoTrailer;

        public string[] infoMovieFiles;
        public string infoMovieTorrent480p;
        public string infoMovieTorrent720p;
        public string infoMovieTorrent1080p;

        private void ctrlPosterTitle_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            if (infoPoster.BackgroundImage == null) { infoPoster.BackgroundImage = Properties.Resources.poster_default; }
        }

        private void InfoPoster_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            frmOpenTheatre.form.tabBlank.Controls.Clear();

            ctrlDetails MovieDetails = new ctrlDetails();

            MovieDetails.infoTitle.Text = infoTitle.Text;
            MovieDetails.infoYear.Text = infoYear.Text;
            MovieDetails.infoGenre.Text = infoGenres;
            MovieDetails.infoSynopsis.Text = infoSynopsis;
            MovieDetails.infoRuntime.Text = infoRuntime;
            MovieDetails.infoRated.Text = infoRated;
            MovieDetails.infoDirector.Text = infoDirector;
            MovieDetails.infoCast.Text = infoCast;
            MovieDetails.infoRatingIMDb.Text = infoImdbRating;
            MovieDetails.infoImdbId = infoImdbId;
            MovieDetails.infoTrailerUrl = infoTrailer;


            try
            {
                MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(infoImagePoster), 1);
                MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(UtilityTools.LoadPicture(infoImageFanart), 0.2F);
            }
            catch { }

            if (infoImagePoster == "") { MovieDetails.imgPoster.Image = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 1); }
            if (infoImageFanart == "") { MovieDetails.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.background_original, 0.5F); }
            if (infoTrailer == "") { MovieDetails.btnWatchTrailer.Visible = false; }

            foreach (string movieLink in infoMovieFiles)
            {
                ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                ctrlInfo.infoFileURL = new Uri(movieLink).AbsoluteUri;
                ctrlInfo.infoFileHost.Text = new Uri(movieLink).Host.Replace("www.", "");
                ctrlInfo.infoFileName.Text = Path.GetFileNameWithoutExtension(new Uri(movieLink).LocalPath);
                MovieDetails.panelFiles.Controls.Add(ctrlInfo);
            }


            //  Magnet : magnet:?xt=urn:btih:TORRENT_HASH&dn=Url+Encoded+Movie+Name&tr=http://track.one:1234/announce&tr=udp://track.two:80
            string trackers = "&tr=" + "udp://open.demonii.com:1337/announce" + " &tr=" + "udp://tracker.openbittorrent.com:80" + "&tr=" + "udp://tracker.coppersurfer.tk:6969" + "&tr=" + "udp://glotorrents.pw:6969/announce" + "&tr=" + "udp://tracker.opentrackr.org:1337/announce" + "&tr=" + "udp://torrent.gresille.org:80/announce" + "&tr=" + "udp://p4p.arenabg.com:1337" + "&tr=" + "udp://tracker.leechers-paradise.org:6969";

            if (infoMovieTorrent480p == "" && infoMovieTorrent720p == "" && infoMovieTorrent1080p == "")
            {
                MovieDetails.panelTitleTorrents.Visible = false;
                MovieDetails.panelTorrents.Visible = false;
            }
            else
            {
                if (infoMovieTorrent480p != "")
                {
                    ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                    ctrlInfo.isTorrent = true;
                    ctrlInfo.infoFileURL = new Uri(infoMovieTorrent480p).AbsoluteUri;
                    ctrlInfo.infoFileHost.Text = new Uri(infoMovieTorrent480p).Host.Replace("www.", "");
                    ctrlInfo.infoFileName.Text = infoTitle.Text + " (" + infoYear.Text + ") [" + "480p" + "] [" + "YTS.AG" + "]";
                    ctrlInfo.infoMagnet = "magnet:?xt=urn:btih:" + Path.GetFileName(infoMovieTorrent1080p) + "&dn=" + infoTitle.Text.Replace(" ", "+") + "%28" + infoYear.Text + "%29+%5B" + "720p" + "%5D+%5B" + "YTS.AG" + "%5D" + trackers;
                    MovieDetails.panelTorrents.Controls.Add(ctrlInfo);
                }

                if (infoMovieTorrent720p != "")
                {
                    ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                    ctrlInfo.isTorrent = true;
                    ctrlInfo.infoFileURL = new Uri(infoMovieTorrent720p).AbsoluteUri;
                    ctrlInfo.infoFileHost.Text = new Uri(infoMovieTorrent720p).Host.Replace("www.", "");
                    ctrlInfo.infoFileName.Text = infoTitle.Text + " (" + infoYear.Text + ") [" + "720p" + "] [" + "YTS.AG" + "]";
                    ctrlInfo.infoMagnet = "magnet:?xt=urn:btih:" + Path.GetFileName(infoMovieTorrent1080p) + "&dn=" + infoTitle.Text.Replace(" ", "+") + "%28" + infoYear.Text + "%29+%5B" + "720p" + "%5D+%5B" + "YTS.AG" + "%5D" + trackers;
                    MovieDetails.panelTorrents.Controls.Add(ctrlInfo);
                }

                if (infoMovieTorrent1080p != "")
                {
                    ctrlStreamInfo ctrlInfo = new ctrlStreamInfo();
                    ctrlInfo.isTorrent = true;
                    ctrlInfo.infoFileURL = new Uri(infoMovieTorrent1080p).AbsoluteUri;
                    ctrlInfo.infoFileHost.Text = new Uri(infoMovieTorrent1080p).Host.Replace("www.", "");
                    ctrlInfo.infoFileName.Text = infoTitle.Text + " (" + infoYear.Text + ") [" + "1080p" + "] [" + "YTS.AG" + "]";
                    ctrlInfo.infoMagnet = "magnet:?xt=urn:btih:" + Path.GetFileName(infoMovieTorrent1080p) + "&dn=" + infoTitle.Text.Replace(" ", "+") + "%28" + infoYear.Text + "%29+%5B" + "720p" + "%5D+%5B" + "YTS.AG" + "%5D" + trackers;
                    MovieDetails.panelTorrents.Controls.Add(ctrlInfo);
                }
            }
            

            MovieDetails.Dock = DockStyle.Fill;
            frmOpenTheatre.form.tabBlank.Controls.Clear();
            frmOpenTheatre.form.tabBlank.Controls.Add(MovieDetails);
            frmOpenTheatre.form.tab.SelectedTab = frmOpenTheatre.form.tabBlank;
        }

        private void InfoPoster_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (!(infoPoster2.Image == null))
                {
                    infoPoster2.Image.Dispose();
                }

                infoPoster2.Image = new Bitmap(infoPoster.BackgroundImage);
                infoPoster.BorderShow = true;
                infoPoster.BackgroundImage.Dispose();
                infoPoster.BackgroundImage = UtilityTools.ChangeOpacity(infoPoster2.Image, 0.4F);
                Update();
            }
            catch
            {
                infoPoster.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 0.4F); 
            }
        }

        private void InfoPoster_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                infoPoster.BackgroundImage.Dispose();
                infoPoster.BorderShow = false;
                infoPoster.BackgroundImage = UtilityTools.ChangeOpacity(infoPoster2.Image, 1);
            }
            catch
            {
                infoPoster.BackgroundImage = UtilityTools.ChangeOpacity(Properties.Resources.poster_default, 1);
            }
        }

    }
}