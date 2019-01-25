using System;
using System.IO;
using System.Linq;
using FileMasta.Data;

namespace FileMasta.Models
{
    /// <summary>
    /// Represents a web file object
    /// </summary>
    public class WebFile
    {
        public readonly string Name;
        public readonly long Size;
        public readonly DateTime LastModified;
        public readonly string Url;

        public WebFile(string name, long size, DateTime lastModified, string url)
        {
            Name = name;
            Size = size;
            LastModified = lastModified;
            Url = url;
        }

        public string GetExtension()
        {
            return Path.GetExtension(Url)?.Replace(".", "").ToUpper();
        }

        public bool IsType(string[] type)
        {
            return type == Types.All || type.Any(x => GetExtension().Contains(x.ToUpper()));
        }
    }
}