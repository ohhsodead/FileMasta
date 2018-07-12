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
        public static string UrlLatestVersion { get; } = "https://raw.githubusercontent.com/HerbL27/FileMasta/master/FileMasta/current-version.txt";
        public static string GetUrlLatestUpdater(Version newVersion) { return OpenLink.UrlGitHub + $"releases/download/{newVersion.ToString()}/Updater.exe"; }

        /// <summary>
        /// Check application for update. Installs latest installer to user downloads and open is folder before closing this instance
        /// </summary>
        public static void CheckForUpdate()
        {
            try
            {
                Program.log.Info("Checking for update");
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
                        Program.log.Info(@"Update found, starting Updater.exe");
                        MessageBox.Show(MainForm.Form, $"FileMasta {newVersion.ToString()} update is ready to be installed. Click OK to download and run the updater.", "FileMasta - Update Available");
                        MainForm._webClient.DownloadFile(GetUrlLatestUpdater(newVersion), $@"{LocalExtensions.pathDownloadsDirectory}\Updater.exe");
                        Process.Start($@"{LocalExtensions.pathDownloadsDirectory}\Updater.exe");
                        Application.Exit();
                    }
                    else
                        Program.log.InfoFormat("Already running the latest version ({0})", newVersion.ToString());
                }
            } 
            catch (Exception ex)
            {
                Program.log.Error("Unable to update", ex);
                MessageBox.Show("There was an error checking for update. You will be redirected to the latest available version download page.");
                Process.Start($"{OpenLink.UrlGitHub}releases/latest");
                Application.Exit();
            }
        }
    }
}