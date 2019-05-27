using FileMasta.Core.Data;
using System;
using System.IO;
using System.Linq;

namespace FileMasta.Core.Models
{
    public partial class FileItem
    {
        public readonly string Name;
        public readonly long Size;
        public readonly DateTime Mtime;
        public readonly string Url;

        /// <summary>
        /// Create a web file object with specified properties
        /// </summary>
        /// <param name="name"></param>
        /// <param name="size"></param>
        /// <param name="mTime"></param>
        /// <param name="url"></param>
        public FileItem(string name, long size, DateTime mTime, string url)
        {
            Name = name;
            Size = size;
            Mtime = mTime;
            Url = url;
        }

        public string GetExtension()
        {
            return Path.GetExtension(Url)?.Replace(".", "").ToUpper();
        }

        public bool IsType(string[] type)
        {
            return type == FileType.All || type.Any(x => GetExtension().Contains(x.ToUpper()));
        }
    }
}