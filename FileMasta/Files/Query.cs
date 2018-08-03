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
        /// <param name="phrase">Query phrase</param>
        /// <param name="sort">Sort files by name, size or date before searching</param>
        /// <param name="type">Filter by type</param>
        /// <param name="host">Filter by FTP host</param>
        /// <returns>Returns list of files matching selected preferences</returns>
        static readonly object LoadSearchListLock = new object();
        public static List<FtpFile> Search(List<FtpFile> dataFiles, string phrase, Sort sort, string[] type, string host)
        {
            lock (LoadSearchListLock)
            {
                bool reverseSort = sort == MainForm.Form.SelectedFilesSort;
                SortFiles(dataFiles, sort, reverseSort);

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
                        && HasFileExtension(type, val.ToString())
                        && HasFileHost(host, val.ToString())
                        && StringExtensions.ContainsAll(Uri.UnescapeDataString(val.ToString()), StringExtensions.GetWords(phrase.ToLower()));
                }))
                .Select(item => item.i)
                .ToList();
            }
        }

        public static bool HasFileExtension(string[] type, string fileUrl)
        {
            if (type == Types.Everything)
                return true;
            else
                return type.Any(x => Path.GetExtension(fileUrl).Replace(".", "").ToLower().Contains(x.ToLower()));
        }

        public static bool HasFileHost(string host, string fileUrl)
        {
            if (host == "")
                return true;
            else
                return host.ToLower() == new Uri(fileUrl).Host.ToLower();
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