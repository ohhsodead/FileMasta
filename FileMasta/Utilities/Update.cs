using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FileMasta.Extensions;

namespace FileMasta.Utilities
{
    class Update
    {
        /// <summary>
        /// Update URLs
        /// </summary>
        public static string URL_VERSION { get; } = "https://dl.dropbox.com/s/ioiu8vwxxc9r430/app-version.txt?raw=true";

        /// <summary>
        /// Check application for update. Installs the latest installer and runs the file before closing this instance
        /// </summary>
        public static void CheckUpdate()
        {
            try
            {
                Program.Log.Info("Checking for update");
                var newVersion = new Version();
                var request = WebExt.GetRequest(URL_VERSION);
                using (var response = request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    newVersion = new Version(reader.ReadToEnd());
                    Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    if (curVersion.CompareTo(newVersion) < 0)
                        RunLatestInstaller(newVersion);
                    else
                        Program.Log.InfoFormat("Using latest version: {0}", newVersion.ToString());
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
                Program.Log.Info(@"New update available - Downloading the installer");
                MessageBox.Show(MainForm.Form, $"FileMasta v{newVersion.ToString()} is now available. Click OK to run the installer.", "FileMasta - Update Available");
                Program._webClient.DownloadFile($"{GitHub.URL_PROJECT}releases/download/{newVersion.ToString()}/FileMasta.Installer.Windows.exe", $@"{LocalExt.PathDownloadsDirectory}\FileMasta.Installer.Windows.exe.exe");
                Process.Start($@"{LocalExt.PathDownloadsDirectory}\FileMasta.Installer.Windows.exe.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                Program.Log.Error("Update failed: ", ex);
                MessageBox.Show("There was an issue running installer. You will need to manually install the latest available update from GitHub.");
                Process.Start($"{GitHub.URL_PROJECT}releases/latest");
                Application.Exit();
            }
        }
    }
}