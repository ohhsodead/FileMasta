using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using FileMasta.Extensions;
using FileMasta.GitHub;

namespace FileMasta.Utilities
{
    class Updates
    {
        /// <summary>
        /// Update URLs
        /// </summary>
        public static string UrlLatestVersion { get; } = "https://www.dropbox.com/s/ioiu8vwxxc9r430/app-version.txt?raw=true";
        public static string GetUrlLatestUpdater(Version newVersion) { return OpenLink.UrlGitHub + $"releases/download/{newVersion.ToString()}/Updater.exe"; }

        /// <summary>
        /// Check application for update. Installs latest installer to users downloads folder and opens the file before closing this instance
        /// </summary>
        public static void CheckForUpdate()
        {
            try
            {
                Program.Log.Info("Checking for update");
                var newVersion = new Version();

                ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
                var request = WebExtensions.GetRequest(UrlLatestVersion);
                using (WebResponse webResponse = request.GetResponse())
                using (var reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    newVersion = new Version(reader.ReadToEnd());
                    Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    if (curVersion.CompareTo(newVersion) < 0)
                    {
                        Program.Log.Info(@"Update found, starting Updater.exe");
                        MessageBox.Show(MainForm.Form, $"FileMasta {newVersion.ToString()} update is ready to be installed. Click OK to download and run the updater.", "FileMasta - Update Available");
                        MainForm._webClient.DownloadFile(GetUrlLatestUpdater(newVersion), $@"{LocalExtensions.PathDownloadsDirectory}\Updater.exe");
                        Process.Start($@"{LocalExtensions.PathDownloadsDirectory}\Updater.exe");
                        Application.Exit();
                    }
                    else
                        Program.Log.InfoFormat("Already running the latest version ({0})", newVersion.ToString());
                }
            } 
            catch (Exception ex)
            {
                Program.Log.Error("Unable to update", ex);
                MessageBox.Show("There was an error checking for update. You will be redirected to the latest available version download page.");
                Process.Start($"{OpenLink.UrlGitHub}releases/latest");
                Application.Exit();
            }
        }
    }
}