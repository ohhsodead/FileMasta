using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using Utilities;

namespace AutoUpdater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        WebClient client = new WebClient(); // public reusable web client
        public static string linkLatestVersion = "https://raw.githubusercontent.com/ekkash/WebCrunch/master/Zipped/LatestVersion.zip";

        private void MainForm_Load(object sender, EventArgs e)
        {
            client.DownloadFile(linkLatestVersion, KnownFolders.GetPath(KnownFolder.Downloads) + "LatestVersion.zip");
            ZipFile.ExtractToDirectory(KnownFolders.GetPath(KnownFolder.Downloads) + "LatestVersion.zip", Application.StartupPath);
            Process.Start(Application.StartupPath + @"\WebCrunch.exe");
        }
    }
}
