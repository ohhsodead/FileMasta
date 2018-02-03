using System;
using System.Diagnostics;
using System.IO;
using WebCrunch;

namespace Utilities
{
    class ReportTemplates
    {
        /// <summary>
        /// Open GitHub submit web server template with the specified URL
        /// </summary>
        /// <param name="webUrl"></param>
        public static void SubmitLink(string webUrl)
        {
            Process.Start(MainForm.urlGitHubIssues + "new?title=" + "[Indexer Request] " + new Uri(webUrl).Host + "&body=" +
                "Website: " + new Uri(webUrl).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Please include some information about this site e.g. What is the type of site? What's the content?*");
        }

        /// <summary>
        /// Open GitHub broken file issue template with the specified URL
        /// </summary>
        /// <param name="webFile"></param>
        public static void OpenBrokenFileIssue(string webFile)
        {
            Process.Start(MainForm.urlGitHubIssues + "new?title=" + "[Broken File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "URL: " + new Uri(webFile).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server's permissions.*");
        }

        /// <summary>
        /// Open GitHub poor quality issue template with the specified URL
        /// </summary>
        /// <param name="webFile"></param>
        public static void OpenPoorQualityFileIssue(string webFile)
        {
            Process.Start(MainForm.urlGitHubIssues + "new?title=" + "[Poor Quality File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "URL: " + new Uri(webFile).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Please explain the problem with the file, be clear and not vague.*");
        }
    }
}
