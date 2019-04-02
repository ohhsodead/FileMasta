using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FileMasta.Extensions;
using FileMasta.Models;

namespace FileMasta.Data
{
    public class DataCache
    {
        /// <summary>
        /// Contains the array of files in the database
        /// </summary>
        private readonly List<WebFile> _dbFiles = new List<WebFile>();
        
        /// <summary>
        /// Contains the users saved files
        /// </summary>
        private readonly List<string> _savedFiles = new List<string>();

        /// <summary>
        /// Contains the metadata of the database
        /// </summary>
        private readonly Metadata _metadata;

        /// <summary>
        /// Initialize the database instance
        /// </summary>
        public DataCache()
        {
            if (!HttpExtensions.IsFileSizeEqual(DataHelper.DatabaseFilePath, AppExtensions.DatabaseUrl))
                HttpExtensions.DownloadFile(AppExtensions.DatabaseUrl, DataHelper.DatabaseFilePath);

            if (File.Exists(DataHelper.SavedFilePath))
            {
                using (var fs = File.Open(DataHelper.SavedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var bs = new BufferedStream(fs))
                using (var sr = new StreamReader(bs))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        _savedFiles.Add(s);
                    }
                }
            }
            
            var totalNoFiles = 0;
            long totalFileSize = 0;
            using (var fs = File.Open(DataHelper.DatabaseFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var bs = new BufferedStream(fs))
            using (var sr = new StreamReader(bs))
            {
                var unused = sr.ReadLine();
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    // Messy way to split csv into a file object
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

        private static readonly object Searching = new object();

        /// <summary>
        /// Find the first file object that matches the specified url
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <returns></returns>
        public WebFile GetFile(string fileUrl)
        {
            lock (Searching)
            {
                return (from webFile in _dbFiles
                    where webFile.Url.Equals(fileUrl)
                    select webFile).First();
            }
        }

        public enum Sort
        {
            Name,
            Size,
            Date
        }

        /// <summary>
        /// Search files from the database
        /// </summary>
        /// <param name="sort">Sort results by property</param>
        /// <param name="name">File name to match words/terms</param>
        /// <param name="type">File type to filter</param>
        /// <param name="minSize">More than or equal to file size in bytes</param>
        /// <param name="minDateModified">Last modified minimum file date</param>
        /// <param name="maxDateModified">Last modified maximum file date</param>
        /// <returns>Returns a list of matching files with the specified parameters</returns>
        public List<WebFile> Search(Sort sort, string name, string[] type, long minSize, DateTime minDateModified, DateTime maxDateModified)
        {
            lock (Searching)
            {
                SortFiles(sort);
                return (from webFile in _dbFiles
                    where StringExtensions.ContainsAll(Uri.UnescapeDataString(webFile.Url.ToLower()),
                              StringExtensions.GetWords(name.ToLower())) &&
                          webFile.IsType(type) &&
                          webFile.Size >= minSize &&
                          webFile.LastModified > minDateModified &&
                          webFile.LastModified < maxDateModified
                        select webFile).ToList();
            }
        }

        /// <summary>
        /// Sort all files in list by Name, Date or Size
        /// </summary>
        /// <param name="sortBy">Sort Name, Date or Size</param>
        /// <param name="sortReverse">Reverse the sort order</param>
        private void SortFiles(Sort sortBy, bool sortReverse = false)
        {
            if (!sortReverse)
            {
                _dbFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    switch (sortBy)
                    {
                        case Sort.Name:
                            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
                        case Sort.Date:
                            return x.LastModified.CompareTo(y.LastModified);
                        case Sort.Size:
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
                        case Sort.Name:
                            return string.Compare(y.Name, x.Name, StringComparison.Ordinal);
                        case Sort.Date:
                            return y.LastModified.CompareTo(x.LastModified);
                        case Sort.Size:
                            return y.Size.CompareTo(x.Size);
                        default:
                            return string.Compare(y.Name, x.Name, StringComparison.Ordinal);
                    }
                });
            }
        }

        /// <summary>
        /// Search files from the database
        /// </summary>
        /// <returns>Returns a list of matching files with the specified parameters</returns>
        public List<WebFile> SavedFiles()
        {
            lock (Searching)
            {
                return (from webFile in _savedFiles
                    let file = GetFile(webFile)
                    select file).ToList();
            }
        }

        /// <summary>
        /// Save the specified file to users the saved list
        /// </summary>
        /// <param name="url">URL to add</param>
        public void SaveFile(string url)
        {
            _savedFiles.Add(url);
        }

        /// <summary>
        /// Remove the specified file from the users saved list
        /// </summary>
        /// <param name="url">URL to remove</param>
        public void UnsaveFile(string url)
        {
            _savedFiles.Remove(url);
        }

        /// <summary>
        /// Check if user has saved the specified file
        /// </summary>
        /// <param name="url">URL of the File</param>
        /// <returns>True if exists</returns>
        public bool IsFileSaved(string url)
        {
            foreach (var file in _savedFiles)
                if (file == url)
                    return true;
            return false;
        }

        /// <summary>
        /// Remove all saved file urls
        /// </summary>
        public void WipeSaved()
        {
            _savedFiles.Clear();
        }

        /// <summary>
        /// Save/update users saved files to a local file
        /// </summary>
        public void CreateSavedFile()
        {
            if (_savedFiles.Count == 0) { DeleteSavedFile(); return; }
            using (var fs = File.OpenWrite(DataHelper.SavedFilePath))
            using (var bs = new BufferedStream(fs))
            using (var sw = new StreamWriter(bs))
                foreach (var fileUrl in _savedFiles)
                    sw.WriteLine(fileUrl);
        }
        
        public void DeleteSavedFile()
        {
            if (File.Exists(DataHelper.SavedFilePath)) File.Delete(DataHelper.SavedFilePath);
        }
    }
}