using FileHelpers;
using FileMasta.Core.Extensions;
using FileMasta.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileMasta.Core.Data
{
    internal class Bookmarks
    {
        private readonly List<FileItem> files = new List<FileItem>();

        /// <summary>
        /// Location of bookmarked files containing records
        /// </summary>
        public string FileLocation { get; private set; }

        /// <summary>
        /// Create a new users bookmarks instance
        /// </summary>
        public Bookmarks(string fileLocation)
        {
            if (File.Exists(fileLocation))
            {
                FileHelperAsyncEngine<DataItem> engine = new FileHelperAsyncEngine<DataItem>();
                engine.ErrorManager.ErrorMode = ErrorMode.IgnoreAndContinue;

                using (engine.BeginReadFile(fileLocation))
                {
                    foreach (DataItem file in engine)
                    {
                        files.Add(FileExtensions.DataItemToFile(file));
                    }
                }
            }

            FileLocation = fileLocation;
        }

        /// <summary>
        /// Get the list of bookmarked files
        /// </summary>
        public IList<FileItem> GetFiles => files;

        /// <summary>
        /// Search and retrieve a collection of files from the database with the specified properties
        /// </summary>
        /// <param name="name">String that contains the file name</param>
        /// <param name="type">Type of file to return</param>
        /// <param name="minSize">Minimum file size</param>
        /// <param name="minMTime">Minimum file modified time</param>
        /// <param name="maxMTime">Maximum file modified time</param>
        /// <returns>An enumerable collection of results with the specified parameters</returns>
        public IEnumerable<DataItem> Search(string name, string[] type, long minSize, DateTime minMTime, DateTime maxMTime)
        {
            FileHelperAsyncEngine<DataItem> engine = new FileHelperAsyncEngine<DataItem>();
            engine.ErrorManager.ErrorMode = ErrorMode.IgnoreAndContinue;
            List<DataItem> results = new List<DataItem>();

            using (engine.BeginReadFile(FileLocation))
            {
                foreach (DataItem file in engine)
                {
                    _ = double.TryParse(file.Mtime, out double fileTStampDbl);
                    DateTime fileTimeStamp = DateTimeExtensions.ParseTimeStamp(fileTStampDbl);

                    if (StringExtensions.ContainsAll(file.Name.ToLower(), StringExtensions.GetWords(name.ToLower())) &&
                              file.IsType(type) &&
                              long.Parse(file.Size) >= minSize &&
                              fileTimeStamp > minMTime &&
                              fileTimeStamp < maxMTime)
                        results.Add(file);
                }
            }

            return results;
        }

        /// <summary>
        /// Add a file to users bookmarks
        /// </summary>
        /// <param name="file">URL to add</param>
        public void Add(FileItem file)
        {
            files.Add(file);
        }

        /// <summary>
        /// Remove a file from users bookmarks
        /// </summary>
        /// <param name="file">URL to remove</param>
        public void Remove(FileItem file)
        {
            files.Remove(file);
        }

        /// <summary>
        /// Check if file exists in the bookmarks
        /// </summary>
        /// <param name="file">URL of the File</param>
        /// <returns>True if exists</returns>
        public bool IsBookmarked(FileItem file)
        {
            foreach (FileItem bookmark in files)
                if (bookmark.Url == file.Url)
                    return true;
            return false;
        }

        /// <summary>
        /// Remove all items from users bookmarks
        /// </summary>
        public void RemoveAll()
        {
            files.Clear();
        }

        /// <summary>
        /// Store and update users bookmarks file
        /// </summary>
        public void UpdateCache()
        {
            if (files.Count == 0)
            {
                DeleteCache();
                return;
            }

            FileHelperAsyncEngine<DataItem> engine = new FileHelperAsyncEngine<DataItem>();
            engine.ErrorManager.ErrorMode = ErrorMode.IgnoreAndContinue;

            using (engine.BeginWriteFile(FileLocation))
            {
                foreach (FileItem file in files)
                {
                    engine.WriteNext(FileExtensions.FileItemToData(file));
                }
            }
        }

        /// <summary>
        /// Delete the bookmarks file
        /// </summary>
        public void DeleteCache()
        {
            if (File.Exists(FileLocation))
                File.Delete(FileLocation);
        }
    }
}