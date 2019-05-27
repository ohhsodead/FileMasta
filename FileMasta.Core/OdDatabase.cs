using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FileHelpers;
using FileMasta.Core.Data;
using FileMasta.Core.Extensions;
using FileMasta.Core.Models;

namespace FileMasta.Core
{
    /// <summary>
    /// OD-Database Library
    /// </summary>
    public class OdDatabase : IOdDatabase
    {
        private string CacheLocation { get; set; }

        private Bookmarks Bookmarks { get; set; }

        /// <summary>
        /// Initialize the OD-Database instance
        /// </summary>
        /// <param name="databaseUrl"></param>
        /// <param name="cacheLocation"></param>
        /// <param name="bookmarksLocation"></param>
        public OdDatabase(string databaseUrl, string cacheLocation, string bookmarksLocation)
        {
            CacheLocation = cacheLocation;
            CacheDatabaseFile(databaseUrl, cacheLocation);
            Bookmarks = new Bookmarks(bookmarksLocation);
        }

        /// <summary>
        /// Cache the latest database file
        /// </summary>
        /// <param name="databaseUrl">Url of the database</param>
        /// <param name="cacheLocation">Cache storage location</param>
        private void CacheDatabaseFile(string databaseUrl, string cacheLocation)
        {
            long dbFileSize = HttpExtensions.GetFileSize(new Uri(databaseUrl));
            DatabaseSize = dbFileSize;

            if (File.Exists(cacheLocation))
            {
                if (dbFileSize != new FileInfo(cacheLocation).Length)
                {
                    HttpExtensions.DownloadFile(databaseUrl, cacheLocation);
                }
            }
            else
            {
                HttpExtensions.DownloadFile(databaseUrl, cacheLocation);
            }

            TotalFileCount = FileExtensions.CountLines(cacheLocation);
        }

        /// <summary>
        /// Search and retrieve a collection of files from the database with the specified properties
        /// </summary>
        /// <param name="name">String that contains the file name</param>
        /// <param name="type">Type of file to return</param>
        /// <param name="minSize">Minimum file size</param>
        /// <param name="minMTime">Minimum file modified time</param>
        /// <param name="maxMTime">Maximum file modified time</param>
        /// <returns>An enumerable collection of results with the specified parameters</returns>
        public async Task<IEnumerable<DataItem>> SearchRecords(string name, string[] type, long minSize, DateTime minMTime, DateTime maxMTime)
        {
            List<DataItem> results = new List<DataItem>();

            using (FileHelperAsyncEngine<DataItem> engine = new FileHelperAsyncEngine<DataItem>())
            {
                engine.ErrorManager.ErrorMode = ErrorMode.IgnoreAndContinue;

                using (engine.BeginReadFile(CacheLocation))
                {
                    await Task.Run(() => Parallel.ForEach(engine, file =>
                    {
                        _ = double.TryParse(file.Mtime, out double fileTStampDbl);
                        DateTime fileTimeStamp = DateTimeExtensions.ParseTimeStamp(fileTStampDbl);

                        if (StringExtensions.ContainsAll(file.Name.ToLower(), StringExtensions.GetWords(name.ToLower())) &&
                                  file.IsType(type) &&
                                  long.Parse(file.Size) >= minSize &&
                                  fileTimeStamp > minMTime &&
                                  fileTimeStamp < maxMTime)
                            results.Add(file);
                    }));
                }
            }

            return results;
        }

        public async Task<IEnumerable<DataItem>> SearchBookmarked(string name, string[] type, long minSize, DateTime minMTime, DateTime maxMTime)
        {
            List<DataItem> results = new List<DataItem>();

            using (FileHelperAsyncEngine<DataItem> engine = new FileHelperAsyncEngine<DataItem>())
            {
                engine.ErrorManager.ErrorMode = ErrorMode.IgnoreAndContinue;

                using (engine.BeginReadFile(Bookmarks.FileLocation))
                {
                    await Task.Run(() => Parallel.ForEach(engine, file =>
                    {
                        _ = double.TryParse(file.Mtime, out double fileTStampDbl);
                        DateTime fileTimeStamp = DateTimeExtensions.ParseTimeStamp(fileTStampDbl);

                        if (StringExtensions.ContainsAll(file.Name.ToLower(), StringExtensions.GetWords(name.ToLower())) &&
                                  file.IsType(type) &&
                                  long.Parse(file.Size) >= minSize &&
                                  fileTimeStamp > minMTime &&
                                  fileTimeStamp < maxMTime)
                            results.Add(file);
                    }));
                }
            }

            return results;
        }

        /// <summary>
        /// Get the total size of indexed files
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public long SizeTotal { get; private set; }

        /// <summary>
        /// Get the total number of files
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public long TotalFileCount { get; private set; }

        /// <summary>
        /// Get the database file size
        /// </summary>
        /// <returns>Total size in bytes</returns>
        public long DatabaseSize { get; private set; }

        /// <summary>
        /// Get the list of the users bookmark files
        /// </summary>
        public IList<FileItem> Bookmarked => Bookmarks.GetFiles;

        /// <summary>
        /// Determines whether the file is bookmarked
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public bool IsBookmarked(FileItem file) => Bookmarks.IsBookmarked(file);

        /// <summary>
        /// Adds a file to bookmarks
        /// </summary>
        /// <param name="url"></param>
        public void AddBookmark(FileItem file) => Bookmarks.Add(file);

        /// <summary>
        /// Removes a file from bookmarks
        /// </summary>
        /// <param name="url"></param>
        public void RemoveBookmark(FileItem file) => Bookmarks.Remove(file);

        /// <summary>
        /// Removes all the file bookmarks
        /// </summary>
        public void RemoveAll() => Bookmarks.RemoveAll();

        /// <summary>
        /// Updates the bookmarks collection to the users hard disk
        /// </summary>
        public void UpdateBookmarks() => Bookmarks.UpdateCache();

        /// <summary>
        /// Fetches and returns the list of popular search keywords
        /// </summary>
        /// <returns>A collection of popular keywords</returns>
        public IEnumerable<string> SearchKeywords => HttpExtensions.GetFileContents("https://dl.dropbox.com/s/4x2nypfiyuoyxjj/searches.txt?raw=true");
    }

    /// <summary>
    /// Properties of files for sorting
    /// </summary>
    public enum Sort
    {
        Name,
        Size,
        Date
    }

    /// <summary>
    /// Categories for different types of files by their extension
    /// </summary>
    public abstract class FileType
    {
        public static string[] All { get; } = { };
        public static string[] Audio { get; } = { "AAC", "AC3", "AIF", "AIFC", "AIFF", "AU", "CDA", "DTS", "FLA", "FLAC", "IT", "M1A", "M2A", "M3U", "M4A", "MID", "MIDI", "MKA", "MOD", "MP2", "MP3", "MPA", "OGG", "RA", "RMI", "SPC", "RMI", "SND", "UMX", "VOC", "WAV", "WMA", "XM" };
        public static string[] Compressed { get; } = { "7Z", "ACE", "ARJ", "BZ2", "CAB", "GZ", "GZIP", "JAR", "R00", "R01", "R02", "R03", "R04", "R05", "R06", "R07", "R08", "R09", "R10", "R11", "R12", "R13", "R14", "R15", "R16", "R17", "R18", "R19", "R20", "R21", "R22", "R23", "R24", "R25", "R26", "R27", "R28", "R29", "RAR", "TAR", "TGZ", "Z", "ZIP" };
        public static string[] Document { get; } = { "C", "CHM", "CPP", "CSV", "CXX", "DOC", "DOCM", "DOCX", "DOT", "DOTM", "DOTX", "H", "HPP", "HTM", "HTML", "HXX", "INI", "JAVA", "LUA", "MHT", "MHTML", "ODT", "PDF", "POTX", "POTM", "PPAM", "PPSM", "PPSX", "PPS", "PPT", "PPTM", "PPTX", "RTF", "SLDM", "SLDX", "THMX", "TXT", "VSD", "WPD", "WPS", "WRI", "XLAM", "XLS", "XLSB", "XLSM", "XLSX", "XLTM", "XLTX", "XML" };
        public static string[] Executable { get; } = { "BAT", "CMD", "EXE", "MSI", "MSP", "SCR" };
        public static string[] Picture { get; } = { "ANI", "BMP", "GIF", "ICO", "JPE", "JPEG", "JPG", "PCX", "PNG", "PSD", "TGA", "TIF", "TIFF", "WMF" };
        public static string[] Video { get; } = { "3G2", "3GP", "3GP2", "3GPP", "AMR", "AMV", "ASF", "AVI", "BDMV", "BIK", "D2V", "DIVX", "DRC", "DSA", "DSM", "DSS", "DSV", "EVO", "F4V", "FLC", "FLI", "FLIC", "FLV", "HDMOV", "IFO", "IVF", "M1V", "M2P", "M2T", "M2TS", "M2V", "M4B", "M4P", "M4V", "MKV", "MP2V", "MP4", "MP4V", "MPE", "MPEG", "MPG", "MPLS", "MPV2", "MPV4", "MOV", "MTS", "OGM", "OGV", "PSS", "PVA", "QT", "RAM", "RATDVD", "RM", "RMM", "RMVB", "ROQ", "RPM", "SMIL", "SMK", "SWF", "TP", "TPR", "TS", "VOB", "VP6", "WEBM", "WM", "WMP", "WMV" };
    }
}