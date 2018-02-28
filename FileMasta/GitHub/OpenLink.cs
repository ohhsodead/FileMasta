using System;
using System.Diagnostics;
using FileMasta.Models;

namespace FileMasta.GitHub
{
    class OpenLink
    {
        /// <summary>
        /// GitHub Project URL
        /// </summary>
        public static string urlGitHub { get; } = "https://github.com/HerbL27/FileMasta/";

        /// <summary>
        /// Open GitHub submit web server template with the specified URL
        /// </summary>
        /// <param name="URL">URL to submit</param>
        public static void SubmitLink(Uri URL)
        {
            Process.Start(urlGitHub + $"issues/new?title=[Indexer Request] {URL.Host}&body=Web Server URL: {URL.AbsoluteUri}%0A----------------------- %0A" +
                "*Please include some information about this site e.g. What type of content is there? Are you the administrator?*");
        }

        /// <summary>
        /// Open GitHub broken file issue template with the specified URL
        /// </summary>
        /// <param name="file">WebFile</param>
        public static void BrokenFileIssue(WebFile file)
        {
            Process.Start(urlGitHub + $"issues/new?title=[Broken File] {file.Name}&body=Host: {file.Host}%0AURL: {file.URL}%0A----------------------- %0A" +
                "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server permissions.*");
        }

        /// <summary>
        /// Open GitHub poor quality issue template with the specified URL
        /// </summary>
        /// <param name="file">WebFile</param>
        public static void PoorQualityFileIssue(WebFile file)
        {
            Process.Start(urlGitHub + $"issues/new?title=[Poor Quality File] {file.Name}&body=Host: {file.Host}%0AURL: {file.URL}%0A----------------------- %0A" +
                "*Please explain the problem with the file, be clear and not vague.*");
        }
    }
}