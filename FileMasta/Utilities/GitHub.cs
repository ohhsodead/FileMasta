using System;
using System.Diagnostics;
using FileMasta.Models;

namespace FileMasta.Utilities
{
    class GitHub
    {
        /// <summary>
        /// Project URL
        /// </summary>
        public const string URL_PROJECT                 = "https://github.com/herbl27/filemasta/";

        /// <summary>
        /// List of servers
        /// </summary>
        public const string URL_SERVERS                 = "https://github.com/herbl27/filemasta/tree/master/Public";

        /// <summary>
        /// Project changelog file
        /// </summary>
        public const string URL_CHANGELOG               = "https://raw.githubusercontent.com/herbl27/filemasta/master/CHANGELOG.md";

        /// <summary>
        /// Project terms of use file
        /// </summary>
        public const string URL_TERMSOFUSE              = "https://raw.githubusercontent.com/herbl27/filemasta/master/TERMSOFUSE.md";

        /// <summary>
        /// Open a new issue template for requesting a server to the project
        /// </summary>
        /// <param name="url">Server link to request</param>
        public static void RequestServer(Uri url)
        {
            Process.Start(URL_PROJECT + $"issues/new?title=[Server Request] {url.Host}&body=Web Server URL: {url.AbsoluteUri}%0A----------------------- %0A" +
                "*Please include some information about this site e.g. What type of content is there? Are you the administrator?*");
        }

        /// <summary>
        /// Opens a new issue template for reporting a file with the information included
        /// </summary>
        /// <param name="file">File to report</param>
        public static void ReportFile(FtpFile file)
        {
            Process.Start(URL_PROJECT + $"issues/new?title=[File Error] {file.Name}&body=Host: {new Uri(file.URL).Host}%0AURL: {file.URL}%0A----------------------- %0A" +
                "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server permissions.*");
        }
    }
}