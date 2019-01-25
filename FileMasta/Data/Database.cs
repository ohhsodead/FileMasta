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
        /// Contains the users saved files url
        /// </summary>
        private readonly List<string> _savedFiles = new List<string>();

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
            lock (SearchLock)
            {
                Sort(sort);
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

        /// <summary>
        /// Search files from the database
        /// </summary>
        /// <returns>Returns a list of matching files with the specified parameters</returns>
        public List<WebFile> SavedFiles()
        {
            lock (SearchLock)
            {
                return (from webFile in _savedFiles
                    let file = GetFile(webFile)
                    select file).ToList();
            }
        }

        /// <summary>
        /// Save the specified file to users the saved list
        /// </summary>
        /// <param name="fileUrl">URL to add</param>
        public void AddToSaved(string fileUrl)
        {
            _savedFiles.Add(fileUrl);
        }

        /// <summary>
        /// Remove the specified file from the users saved list
        /// </summary>
        /// <param name="fileUrl">URL to remove</param>
        public void RemoveFromSaved(string fileUrl)
        {
            _savedFiles.Remove(fileUrl);
        }

        /// <summary>
        /// Check if user has saved the specified file
        /// </summary>
        /// <param name="fileUrl">URL of the File</param>
        /// <returns>True if exists</returns>
        public bool IsFileSaved(string fileUrl)
        {
            foreach (var file in _savedFiles)
                if (file == fileUrl)
                    return true;
            return false;
        }

        /// <summary>
        /// Remove all saved file urls
        /// </summary>
        public void ClearSaved()
        {
            _savedFiles.Clear();
        }

        /// <summary>
        /// Save/update saved files to a local file
        /// </summary>
        public void UpdateSavedFile()
        {
            if (_savedFiles.Count == 0) { DataHelper.RemoveSavedFile(); return; }
            using (var fs = File.OpenWrite(DataHelper.SavedFilePath))
            using (var bs = new BufferedStream(fs))
            using (var sw = new StreamWriter(bs))
                foreach (var fileUrl in _savedFiles)
                    sw.WriteLine(fileUrl);
        }
    }
}