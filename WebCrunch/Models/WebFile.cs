using System;

namespace Models
{
    /// <summary>
    /// Represents a Web File
    /// </summary>
    public partial class WebFile
    {
        public string URL { get; set; }
        public string Type { get; set; }
        public long Size { get; set; } = 0;
        public DateTime DateUploaded { get; set; } = default(DateTime);
        public string Host { get; set; }
        public string Name { get; set; }
    }
}
