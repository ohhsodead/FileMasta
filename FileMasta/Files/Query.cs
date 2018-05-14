using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using FileMasta.Extensions;
using FileMasta.Models;

namespace FileMasta.Files
{
    public class Query
    {
        /// <summary>
        /// Sort By Web File Properties
        /// </summary>
        public enum SortBy { Name, Size, Date }

        /// <summary>
        /// Search Files by using these methods
        /// </summary>
        /// <param name="dataFiles"></param>
        /// <param name="SearchQuery"></param>
        /// <param name="SortBy"></param>        
        /// <returns></returns>
        static object loadSearchListLock = new object();
        public static List<WebFile> Search(List<WebFile> dataFiles, string SearchQuery, SortBy SortBy = SortBy.Name)
        {
            lock (loadSearchListLock)
            {
                SortFiles(dataFiles, SortBy);

                var queryExactStrings = new Regex("\"(.*?)\"").Matches(SearchQuery.ToLower()); // Get strings wrapped in double quotes
                var queryListExactStrings = new List<string>();
                foreach (Match match in queryExactStrings) queryListExactStrings.Add(match.Groups[1].Value.ToLower()); // Adds exacts phrases
                var result = SearchQuery.ToLower(); // Store exact phrases
                queryListExactStrings.ToList().ForEach(o => result = result.Replace("\"" + o + "\"", string.Empty)); // Removes all occurrences of exact phrases wrapped with double quotes
                var queryWords = StringExtensions.GetWords(result);

                return dataFiles.Select(item =>
                new
                {
                    i = item,
                    Props = item.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                })
                .Where(item => item.Props.Any(p =>
                {
                    var val = p.GetValue(item.i, null);
                    return val != null
                        && (p.Name == "URL" || string.IsNullOrEmpty("URL"))
                        && (StringExtensions.ContainsAll(Uri.UnescapeDataString(val.ToString().ToLower()), queryWords) && (StringExtensions.ContainsAll(Uri.UnescapeDataString(val.ToString().ToLower()), queryListExactStrings.ToArray())) || string.IsNullOrEmpty(SearchQuery));
                }))
                .Select(item => item.i)
                .ToList();
            }
        }

        /// <summary>
        /// Search Files by Web URL
        /// </summary>
        /// <param name="WebURL"></param>     
        /// <returns>a list of files that contains the <paramref name="WebURL"/></returns>
        static object loadSpecialSearchListLock = new object();
        public static List<WebFile> SpecialSearch(string WebURL)
        {
            lock (loadSpecialSearchListLock)
            {
                return MainForm.FilesOpenDatabase.Select(item =>
                new
                {
                    i = item,
                    Props = item.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                })
                .Where(item => item.Props.Any(p =>
                {
                    var val = p.GetValue(item.i, null);
                    return val != null
                        && (p.Name == "URL" || string.IsNullOrEmpty("URL"))
                        && (val.ToString().ToLower().StartsWith(WebURL.ToLower()) || string.IsNullOrEmpty(WebURL));
                }))
                .Select(item => item.i)
                .ToList();
            }
        }

        static int switchSort = 0;
        public static void SortFiles(List<WebFile> dataFiles, SortBy Property = SortBy.Name)
        {
            if (switchSort == 0)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    if (Property == SortBy.Name)
                        return x.Name.CompareTo(y.Name);
                    else if (Property == SortBy.Date)
                        return x.DateUploaded.CompareTo(y.DateUploaded);
                    else if (Property == SortBy.Size)
                        return x.Size.CompareTo(y.Size);
                    else
                        return x.Name.CompareTo(y.Name);
                });
                switchSort = 1;
            }
            else if (switchSort == 1)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    if (Property == SortBy.Name)
                        return y.Name.CompareTo(x.Name);
                    else if (Property == SortBy.Date)
                        return y.DateUploaded.CompareTo(x.DateUploaded);
                    else if (Property == SortBy.Size)
                        return y.Size.CompareTo(x.Size);
                    else
                        return y.Name.CompareTo(x.Name);
                });
                switchSort = 0;
            }
        }
    }
}