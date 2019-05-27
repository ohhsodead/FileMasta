using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using FileMasta.Core.Extensions;
using FileMasta.Extensions;

namespace FileMasta.Utilities
{
    internal abstract class Update
    {
        /// <summary>
        /// Check application for update. Installs the latest installer and runs the file before closing this instance
        /// </summary>
        public static void CheckVersion()
        {
            try
            {
                Program.Log.Info("Checking for update");
                using (StreamReader sr = new StreamReader(HttpExtensions.GetStream(Configuration.VersionUrl)))
                {
                    Version newVersion = new Version(sr.ReadToEnd());
                    Version curVersion = Assembly.GetExecutingAssembly().GetName().Version;
                    if (curVersion.CompareTo(newVersion) < 0)
                        RunInstaller(newVersion);
                    else
                        Program.Log.InfoFormat("Up to date. Version: {0}", newVersion);
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
        private static void RunInstaller(Version newVersion)
        {
            try
            {
                Program.Log.Info(@"New update available - Beginning to download the installer");
                MessageBox.Show($@"FileMasta v{newVersion} is now available. Click OK to run the installer.", @"FileMasta - Update Available");
                Program.WebClient.DownloadFile($"{Configuration.ProjectUrl}releases/download/{newVersion}/FileMasta.Installer.Windows.exe", $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\FileMasta.Installer.Windows.exe.exe");
                Process.Start($@"{KnownFolders.GetPath(KnownFolder.Downloads)}\FileMasta.Installer.Windows.exe.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                Program.Log.Error("Update failed: ", ex);
                MessageBox.Show(@"There was an issue. You will need to manually install the latest available update from GitHub.");
                Process.Start($"{Configuration.ProjectUrl}releases/latest");
                Application.Exit();
            }
        }
    }
}