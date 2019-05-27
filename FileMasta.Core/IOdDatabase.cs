using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FileMasta.Core.Models;

namespace FileMasta.Core
{
    internal interface IOdDatabase
    {
        Task<IEnumerable<DataItem>> SearchRecords(string name, string[] type, long minSize, DateTime minMTime, DateTime maxMTime);

        Task<IEnumerable<DataItem>> SearchBookmarked(string name, string[] type, long minSize, DateTime minMTime, DateTime maxMTime);

        long TotalFileCount { get; }

        long SizeTotal { get; }
        
        long DatabaseSize { get; }

        IList<FileItem> Bookmarked { get; }

        IEnumerable<string> SearchKeywords { get; }

        void AddBookmark(FileItem file);

        void RemoveBookmark(FileItem file);

        bool IsBookmarked(FileItem file);

        void RemoveAll();

        void UpdateBookmarks();
    }
}