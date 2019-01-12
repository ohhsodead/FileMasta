using System;
using System.Linq;

namespace FileMasta.Models
{
    /// <summary>
    /// Represents a FTP File class object
    /// </summary>
    public partial class FtpFile
    {
        public string Name { get; set; } = "";
        public long Size { get; set; } = 0;
        public DateTime DateModified { get; set; } = DateTime.MinValue;
        public string URL { get; set; } = "";

        public FtpFile(string name, long size, DateTime datemodified, string url)
        {
            Name = name;
            Size = size;
            DateModified = datemodified;
            URL = url;
        }

        public string GetExtension()
        {
            return System.IO.Path.GetExtension(URL).Replace(".", "").ToLower();
        }

        public bool IsType(string[] type)
        {
            if (type == Files.Type.Everything)
                return true;
            else
                return type.Any(x => GetExtension().ToLower().Contains(x.ToLower()));
        }
    }
}