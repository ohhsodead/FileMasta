using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FileMasta.Extensions;
using FileMasta.Models;
using Newtonsoft.Json;

namespace FileMasta.Files
{
    public class Database
    {
        /// <summary>
        /// URLs for database files
        /// </summary>
        const string URL_DATABASE                        = "https://www.dropbox.com/s/0dwmqk1pkj2ndkz/ftp-files.json?raw=true";
        const string URL_KEYWORDS                        = "https://www.dropbox.com/s/4x2nypfiyuoyxjj/searches.txt?raw=true";
        
        /// <summary>
        /// Database file name
        /// </summary>
        const string LocalFileName                       = "ftp-files.json";

        /// <summary>
        /// Contains the database information, date, version, etc.
        /// </summary>
        public Metadata MetaData = null;

        /// <summary>
        /// Stores a list of files retrieved from the database
        /// </summary>
        static List<FtpFile> Files { get; set; } = new List<FtpFile>();

        /// <summary>
        /// 
        /// </summary>
        static List<FtpFile> Bookmarks { get; set; } = new List<FtpFile>();
        
        /// <summary>
        /// Download latest database files for ftp file then load them into memory for usage
        /// </summary>
        public Database()
        {
            Directory.CreateDirectory(LocalExtensions.PathRoot);
            Directory.CreateDirectory(LocalExtensions.PathData);

            try
            {
                if (WebExtensions.IsLocalFileOld(URL_DATABASE, LocalFileName))
                    WebExtensions.DownloadFile(URL_DATABASE, $"{LocalExtensions.PathData}{LocalFileName}");
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to update file database.\n\n" + ex.Message);
            }
            finally
            {
                // Deserializes database first line containing meta info
                MetaData = JsonConvert.DeserializeObject<Metadata>(File.ReadLines($"{LocalExtensions.PathData}{LocalFileName}").First());

                using (FileStream fs = File.Open($"{LocalExtensions.PathData}{LocalFileName}", FileMode.Open, FileAccess.Read, FileShare.Read))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    MetaData = JsonConvert.DeserializeObject<Metadata>(sr.ReadLine());
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        if (StringExtensions.IsValidJSON(line))
                            Files.Add(JsonConvert.DeserializeObject<FtpFile>(line));
                }

                using (FileStream fs = File.Open(LocalExtensions.PathBookmarks, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        if (StringExtensions.IsValidJSON(line))
                            Bookmarks.Add(JsonConvert.DeserializeObject<FtpFile>(line));
                }
            }
        }

        /// <summary>
        /// Sort File by Property
        /// </summary>
        public enum Sort { Name, Size, Date }
        
        /// <summary>
        /// Total size of all files in database
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public long TotalFileSize()
        {
            long totalSize = 0;

            foreach (var jsonData in Files)
                totalSize += jsonData.Size;

            return totalSize;
        }

        /// <summary>
        /// Returns the total number of files
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public long NoOfFiles()
        {
            return Files.Count();
        }

        /// <summary>
        /// Get web file info from internal database, or creates a new object if it doesn't exist
        /// </summary>
        /// <param name="URL">Used to match with WebFile.URL to return class</param>
        /// <returns>WebFile object</returns>
        public FtpFile GetFile(string url)
        {
            // Checks loaded files for a matching URL and returns the Web File object
            foreach (var file in Files) 
                if (file.URL == url)
                    return file;
        
            // Create a new Web File object as this URL doesn't exist in the database there anymore
            var newWebFile = new FtpFile(Path.GetFileName(new Uri(url).LocalPath), WebExtensions.FtpFileSize(url), WebExtensions.FtpFileTimestamp(url), new Uri(url).AbsoluteUri);

            // Add the new Web File to this instance of application
            Files.Add(newWebFile);

            // Return the new Web File
            return newWebFile;
        }

        /// <summary>
        /// Search files and bookmarks from the database
        /// </summary>
        /// <param name="bookmarks">Search bookmarks</param>
        /// <param name="sort">Sort results by property</param>
        /// <param name="name">File name to match words/terms</param>
        /// <param name="type">File type to filter</param>
        /// <param name="moreThanSize">More than or equal to file size in bytes</param>
        /// <param name="lastModifiedMin">Last modified minimum file date</param>
        /// <param name="lastModifiedMax">Last modified maximum file date</param>
        /// <returns>Returns a list of matching files with the specified parameters</returns>
        static readonly object SearchFilesLock = new object();
        public IEnumerable<FtpFile> Search(bool bookmarks, Sort sort, string name, string[] type, long moreThanSize, DateTime lastModifiedMin, DateTime lastModifiedMax)
        {
            lock (SearchFilesLock)
            {
                var data = Files;
                if (bookmarks) data = Bookmarks;
                var searchTerms = StringExtensions.GetWords(name.ToLower());
                IEnumerable<FtpFile> search = from file in data
                                              where StringExtensions.ContainsAll(Uri.UnescapeDataString(file.URL.ToLower()), searchTerms)
                                              where file.IsType(type)
                                              where file.Size >= moreThanSize
                                              where file.DateModified > lastModifiedMin
                                              where file.DateModified < lastModifiedMax
                                              select file;
                return search;
            }
        }

        /// <summary>
        /// Retrieve keywords from database
        /// </summary>
        /// <returns>List containg all keywords returned</returns>
        public List<string> GetKeywords()
        {
            return WebExtensions.GetFileContents(URL_KEYWORDS);
        }

        /// <summary>
        /// Add File URL to Bookmarks
        /// </summary>
        /// <param name="url">URL to add</param>
        public void AddFile(FtpFile ftpFile)
        {
            Bookmarks.Add(ftpFile);
        }

        /// <summary>
        /// Remove File URL from Bookmarks
        /// </summary>
        /// <param name="url">URL to remove</param>
        public void RemoveFile(FtpFile ftpFile)
        {
            Bookmarks.Remove(ftpFile);
        }

        /// <summary>
        /// Checks if json string exists in Bookmarked Files
        /// </summary>
        /// <param name="url">URL of the File</param>
        /// <returns>Whether URL is bookmarked</returns>
        public bool IsBookmarked(FtpFile ftpFile)
        {
            foreach (var file in Bookmarks)
                if (file.URL == ftpFile.URL)
                    return true;
            return false;
        }

        /// <summary>
        /// Removes all items in bookmarks
        /// </summary>
        public void ClearBookmarks()
        {
            Bookmarks.Clear();
        }

        public void SaveBookmarks()
        {
            if (File.Exists($"{LocalExtensions.PathBookmarks}{LocalFileName}"))
                File.Delete($"{LocalExtensions.PathBookmarks}{LocalFileName}");
            using (FileStream fs = File.OpenWrite($"{LocalExtensions.PathBookmarks}{LocalFileName}"))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamWriter sw = new StreamWriter(bs))
                foreach (var file in Bookmarks)
                    sw.WriteLine(JsonConvert.SerializeObject(file));
        }

        /// <summary>
        /// Sort all files in list by Name, Date or Size
        /// </summary>
        /// <param name="sortProperty">Sort Name, Date or Size</param>
        /// <param name="sortReverse">Reverse the sort order</param>
        public void SortFiles(Sort sortProperty = Sort.Name, bool sortReverse = false)
        {
            if (!sortReverse)
            {
                Files.Sort(delegate (FtpFile x, FtpFile y)
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
                Files.Sort(delegate (FtpFile x, FtpFile y)
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