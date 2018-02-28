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
        public static string GetUrlLatestUpdater(Version newVersion) { return OpenLink.urlGitHub + $"releases/download/{newVersion.ToString()}/Update.exe"; }

        /// <summary>
        /// Check application for update. Installs latest installer to user downloads and open is folder before closing this instance
        /// </summary>
        public static void CheckForUpdate()
        {
            try
            {
                Program.log.Info("Checking for update");
                var newVersion = new Version();
                var client = new WebClient();
                var stream = client.OpenRead(UrlLatestVersion);
                stream.ReadTimeout = 60000;
                using (var reader = new StreamReader(stream))
                {
                    newVersion = new Version(reader.ReadToEnd());
                    Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    if (curVersion.CompareTo(newVersion) < 0)
                    {
                        Program.log.Info(@"Update found, starting Update.exe");
                        MessageBox.Show(MainForm.Form, $"FileMasta {newVersion.ToString()} is ready to be installed.", "FileMasta - Update Available");
                        client.DownloadFile(GetUrlLatestUpdater(newVersion), $@"{LocalExtensions.userDownloadsDirectory}\Update.exe");
                        Process.Start($@"{LocalExtensions.userDownloadsDirectory}\Update.exe");
                        Application.Exit();
                    }
                }                    
            } 
            catch (Exception ex)
            {
                Program.log.Error("Unable to update", ex);
                MessageBox.Show("There was an error checking for update. You will be redirected to the latest available version download page.");
                Process.Start($"{OpenLink.urlGitHub}releases/latest");
                Application.Exit();
            }
        }
    }
}
