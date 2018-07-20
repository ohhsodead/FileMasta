using System;
using System.Collections.Generic;
using System.IO;
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
        /// Sort File by Property
        /// </summary>
        public enum Sort { Name, Size, Date }

        /// <summary>
        /// Search Files using selected params
        /// </summary>
        /// <param name="dataFiles">Files to search through</param>
        /// <param name="search">Query search, supports exact phrases</param>
        /// <param name="sort">Sort files by name, size or date before searching</param>
        /// <param name="type">Filter by type</param>
        /// <param name="host">Filter by FTP host</param>
        /// <returns>Returns list of files matching selected preferences</returns>
        static readonly object LoadSearchListLock = new object();
        public static List<FtpFile> Search(List<FtpFile> dataFiles, string search, Sort sort, string[] type, string host)
        {
            lock (LoadSearchListLock)
            {
                bool reverseSort = sort == MainForm.Form.SelectedFilesSort;
                SortFiles(dataFiles, sort, reverseSort);

                var queryExactStrings = new Regex("\"(.*?)\"").Matches(search.ToLower()); // Get strings wrapped in double quotes
                var queryListExactStrings = new List<string>();
                foreach (Match match in queryExactStrings) queryListExactStrings.Add(match.Groups[1].Value.ToLower()); // Adds exacts phrases
                var result = search.ToLower(); // Store exact phrases
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
                        && HasFileExtension(type, val.ToString()) && HasFileHost(host, val.ToString()) && (StringExtensions.ContainsAll(Uri.UnescapeDataString(val.ToString().ToLower()), queryWords) && (StringExtensions.ContainsAll(Uri.UnescapeDataString(val.ToString().ToLower()), queryListExactStrings.ToArray())) || string.IsNullOrEmpty(search));
                }))
                .Select(item => item.i)
                .ToList();
            }
        }

        public static bool HasFileExtension(string[] type, string webFile)
        {
            if (type == Types.Everything)
                return true;
            else
                return type.Contains(Path.GetExtension(webFile.ToUpper()).Replace(".", ""));
        }

        public static bool HasFileHost(string host, string webFile)
        {
            if (host == "")
                return true;
            else
                return host.Contains(new Uri(webFile.ToUpper()).Host);
        }

        /// <summary>
        /// Sorts the list of files by Name, Date or Size - used before searching the list
        /// </summary>
        /// <param name="dataFiles">List of WebFile to sort</param>
        /// <param name="sortProperty">Sort Name, Date or Size</param>
        /// <param name="sortReverse">Reverse the sort order</param>
        public static void SortFiles(List<FtpFile> dataFiles, Sort sortProperty = Sort.Name, bool sortReverse = false)
        {
            if (!sortReverse)
            {
                dataFiles.Sort(delegate (FtpFile x, FtpFile y)
                {
                    if (sortProperty == Sort.Name)
                        return x.Name.CompareTo(y.Name);
                    else if (sortProperty == Sort.Date)
                        return x.DateModified.CompareTo(y.DateModified);
                    else if (sortProperty == Sort.Size)
                        return x.Size.CompareTo(y.Size);
                    else
                        return x.Name.CompareTo(y.Name);
                });
            }
            else if (sortReverse)
            {
                dataFiles.Sort(delegate (FtpFile x, FtpFile y)
                {
                    if (sortProperty == Sort.Name)
                        return y.Name.CompareTo(x.Name);
                    else if (sortProperty == Sort.Date)
                        return y.DateModified.CompareTo(x.DateModified);
                    else if (sortProperty == Sort.Size)
                        return y.Size.CompareTo(x.Size);
                    else
                        return y.Name.CompareTo(x.Name);
                });
            }
        }
    }
}