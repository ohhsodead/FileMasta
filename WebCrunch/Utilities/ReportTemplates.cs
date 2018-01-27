using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrunch.Utilities
{
    class ReportTemplates
    {
        // Submit link (open directory/indexer)
        public static void submitLink(string webUrl)
        {
            Process.Start(MainForm.linkGitHubIssues + "new?title=" + "[Indexer Request] " + new Uri(webUrl).Host + "&body=" +
                "Website: " + new Uri(webUrl).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Please include some information about this site e.g. What is the type of site? What's the content?*");
        }

        // Report Broken File issue
        public static void openBrokenFileIssue(string webFile)
        {
            Process.Start(MainForm.linkGitHubIssues + "new?title=" + "[Broken File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "URL: " + new Uri(webFile).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server's permissions.*");
        }

        // Poor Quality File issue
        public static void openPoorQualityFileIssue(string webFile)
        {
            Process.Start(MainForm.linkGitHubIssues + "new?title=" + "[Poor Quality File] " + Path.GetFileName(webFile) + "&body=" +
                "Host: " + new Uri(webFile).Host.Replace("www.", "") + "%0A" +
                "Name: " + Path.GetFileName(webFile) + "%0A" +
                "URL: " + new Uri(webFile).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Please explain the problem with the file, be clear and not vague.*");
        }
    }
}
