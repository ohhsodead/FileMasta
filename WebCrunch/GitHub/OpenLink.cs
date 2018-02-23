using System;
using System.Diagnostics;
using System.IO;
using WebCrunch;
using WebCrunch.Models;

namespace WebCrunch.GitHub
{
    class OpenLink
    {
        /// <summary>
        /// GitHub Project URL
        /// </summary>
        public static string urlGitHub = "https://github.com/HerbL27/WebCrunch/";

        /// <summary>
        /// Open GitHub submit web server template with the specified URL
        /// </summary>
        /// <param name="URL"></param>
        public static void SubmitLink(string URL)
        {
            Process.Start(OpenLink.urlGitHub + "issues/new?title=" + "[Indexer Request] " + new Uri(URL).Host + "&body=" +
                "Website: " + new Uri(URL).AbsoluteUri + "%0A" +
                "----------------------- %0A" +
                "*Please include some information about this site e.g. What type of content is there? Are you the administrator?*");
        }

        /// <summary>
        /// Open GitHub broken file issue template with the specified URL
        /// </summary>
        /// <param name="file"></param>
        public static void BrokenFileIssue(WebFile file)
        {
            Process.Start(OpenLink.urlGitHub + "issues/new?title=" + "[Broken File] " + file.Name + "&body=" +
                "Host: " + file.Host + "%0A" +
                "URL: " + file.URL + "%0A" +
                "----------------------- %0A" +
                "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server permissions.*");
        }

        /// <summary>
        /// Open GitHub poor quality issue template with the specified URL
        /// </summary>
        /// <param name="file"></param>
        public static void PoorQualityFileIssue(WebFile file)
        {
            Process.Start(OpenLink.urlGitHub + "issues/new?title=" + "[Poor Quality File] " + file.Name + "&body=" +
                "Host: " + file.Host + "%0A" +
                "URL: " + file.URL + "%0A" +
                "----------------------- %0A" +
                "*Please explain the problem with the file, be clear and not vague.*");
        }
    }
}
