using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using FileMasta.Extensions;

namespace FileMasta.Utilities
{
    class Updates
    {
        /// <summary>
        /// Update URLs
        /// </summary>
        public static string UrlLatestVersion { get; } = "https://dl.dropbox.com/s/ioiu8vwxxc9r430/app-version.txt?raw=true";

        /// <summary>
        /// Check application for update. Installs the latest installer and runs the file before closing this instance
        /// </summary>
        public static void CheckForUpdate()
        {
            try
            {
                Program.Log.Info("Checking for update");
                var newVersion = new Version();
                var request = WebExtensions.GetRequest(UrlLatestVersion);
                using (WebResponse webResponse = request.GetResponse())
                using (var reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    newVersion = new Version(reader.ReadToEnd());
                    Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    if (curVersion.CompareTo(newVersion) < 0)
                        RunLatestInstaller(newVersion);
                    else
                        Program.Log.InfoFormat("Using the latest version: {0}", newVersion.ToString());
                }
            } 
            catch (Exception ex)
            {
                Program.Log.Error("Failed: ", ex);
                Application.Exit();
            }
        }

        /// <summary>
        /// Downloads the newest update installer from GitHub and runs it for the user
        /// </summary>
        /// <param name="newVersion">Newest version installer to run</param>
        public static void RunLatestInstaller(Version newVersion)
        {
            try
            {
                Program.Log.Info(@"New update available - Downloading and starting the Installer");
                MessageBox.Show(MainForm.Form, $"FileMasta v{newVersion.ToString()} is now available. Click OK to run the installer.", "FileMasta - Update Available");
                Program._webClient.DownloadFile($"{GitHub.URL_PROJECT}releases/download/{newVersion.ToString()}/FileMasta.Installer.Windows.exe", $@"{LocalExtensions.PathDownloadsDirectory}\FileMasta.Installer.Windows.exe.exe");
                Process.Start($@"{LocalExtensions.PathDownloadsDirectory}\FileMasta.Installer.Windows.exe.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                Program.Log.Error("Failed: ", ex);
                MessageBox.Show("There was an issue downloading and running the installer. You will need to manually install the latest available update from GitHub.");
                Process.Start($"{GitHub.URL_PROJECT}releases/latest");
                Application.Exit();
            }
        }
    }
}