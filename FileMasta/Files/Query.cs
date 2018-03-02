using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public static List<WebFile> Search(List<WebFile> dataFiles, string SearchQuery, SortBy SortBy)
        {
            lock (loadSearchListLock)
            {
                SortFiles(dataFiles, SortBy);

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
                        && (p.Name.ToLower() == "URL".ToLower() || string.IsNullOrEmpty("URL"))
                        && (TextExtensions.ContainsAll(Uri.UnescapeDataString(val.ToString().ToLower()), TextExtensions.GetWords(SearchQuery.ToLower())) || string.IsNullOrEmpty(SearchQuery));
                }))
                .Select(item => item.i)
                .ToList();
            }
        }

        static int switchName = 0;
        public static void SortFiles(List<WebFile> dataFiles, SortBy Property = SortBy.Name)
        {
            if (switchName == 0)
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
                switchName = 1;
            }
            else if (switchName == 1)
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
                switchName = 0;
            }
        }
    }
}