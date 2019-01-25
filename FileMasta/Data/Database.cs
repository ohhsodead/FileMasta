using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FileMasta.Extensions;
using FileMasta.Models;

namespace FileMasta.Data
{
    public class Database
    {
        /// <summary>
        /// Contains the web file elements in the database
        /// </summary>
        private readonly List<WebFile> _dbFiles = new List<WebFile>();
        
        /// <summary>
        /// Contains the users bookmarked files url
        /// </summary>
        private readonly List<string> _bookmarkedFiles = new List<string>();

        /// <summary>
        /// Contains the metadata of the database
        /// </summary>
        private readonly Metadata _metadata;

        /// <summary>
        /// Initialize the database instance
        /// </summary>
        public Database()
        {
            if (!HttpExtensions.IsFileSizeEqual(DataHelper.DatabaseFilePath, AppExtensions.DatabaseUrl))
                HttpExtensions.DownloadFile(AppExtensions.DatabaseUrl, DataHelper.DatabaseFilePath);

            var totalNoFiles = 0;
            long totalFileSize = 0;

            if (!File.Exists(DataHelper.BookmarkedFilePath))
                File.Create(DataHelper.BookmarkedFilePath);

            if (!string.IsNullOrEmpty(File.ReadAllText(DataHelper.BookmarkedFilePath)))
            {
                using (var fs = File.Open(DataHelper.BookmarkedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var bs = new BufferedStream(fs))
                using (var sr = new StreamReader(bs))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        _bookmarkedFiles.Add(s);
                    }
                }
            }

            using (var fs = File.Open(DataHelper.DatabaseFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var bs = new BufferedStream(fs))
            using (var sr = new StreamReader(bs))
            {
                var unused = sr.ReadLine();
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    var lineParts = s.Split(',');
                    var fileSize = long.Parse(lineParts[0]);
                    var fileLastModified = DateTime.Parse(lineParts[1]);
                    var fileUrl = lineParts[2];
                    var fileName = Path.GetFileName(Uri.UnescapeDataString(fileUrl));
                    _dbFiles.Add(
                        new WebFile(
                            fileName,
                            fileSize, 
                            fileLastModified,
                            fileUrl));
                    totalNoFiles++;
                    totalFileSize += fileSize;
                }
            }

            _metadata = new Metadata(
                totalNoFiles,
                totalFileSize);
        }

        /// <summary>
        /// Get the total size of all files contained in the database
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public long GetTotalFilesSize()
        {
            return _metadata.TotalFilesSize;
        }

        /// <summary>
        /// Get the total number of files in the database
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public long GetTotalNoFiles()
        {
            return _metadata.TotalNoFiles;
        }

        /// <summary>
        /// Get the first file object that equals to the specified url
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <returns></returns>
        public WebFile GetFile(string fileUrl)
        {
            lock (SearchLock)
            {
                return (from webFile in _dbFiles
                    where webFile.Url.Equals(fileUrl)
                    select webFile).First();
            }
        }

        private static readonly object SearchLock = new object();

        /// <summary>
        /// Search files and Bookmarked from the database
        /// </summary>
        /// <param name="sort">Sort results by property</param>
        /// <param name="name">File name to match words/terms</param>
        /// <param name="type">File type to filter</param>
        /// <param name="minimumSize">More than or equal to file size in bytes</param>
        /// <param name="lastModifiedMin">Last modified minimum file date</param>
        /// <param name="lastModifiedMax">Last modified maximum file date</param>
        /// <returns>Returns a list of matching files with the specified parameters</returns>
        public List<WebFile> Search(Sort sort, string name, string[] type, long minimumSize, DateTime lastModifiedMin, DateTime lastModifiedMax)
        {
            lock (SearchLock)
            {
                Sort(sort);
                return (from webFile in _dbFiles
                    where StringExtensions.ContainsAll(Uri.UnescapeDataString(webFile.Url.ToLower()),
                              StringExtensions.GetWords(name.ToLower())) &&
                          webFile.IsType(type) &&
                          webFile.Size >= minimumSize &&
                          webFile.LastModified > lastModifiedMin &&
                          webFile.LastModified < lastModifiedMax
                    select webFile).ToList();
            }
        }

        /// <summary>
        /// Sort all files in list by Name, Date or Size
        /// </summary>
        /// <param name="sortBy">Sort Name, Date or Size</param>
        /// <param name="sortReverse">Reverse the sort order</param>
        private void Sort(Sort sortBy, bool sortReverse = false)
        {
            if (!sortReverse)
            {
                _dbFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    switch (sortBy)
                    {
                        case Data.Sort.Name:
                            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
                        case Data.Sort.Date:
                            return x.LastModified.CompareTo(y.LastModified);
                        case Data.Sort.Size:
                            return x.Size.CompareTo(y.Size);
                        default:
                            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
                    }
                });
            }
            else
            {
                _dbFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    switch (sortBy)
                    {
                        case Data.Sort.Name:
                            return string.Compare(y.Name, x.Name, StringComparison.Ordinal);
                        case Data.Sort.Date:
                            return y.LastModified.CompareTo(x.LastModified);
                        case Data.Sort.Size:
                            return y.Size.CompareTo(x.Size);
                        default:
                            return string.Compare(y.Name, x.Name, StringComparison.Ordinal);
                    }
                });
            }
        }
    }
}