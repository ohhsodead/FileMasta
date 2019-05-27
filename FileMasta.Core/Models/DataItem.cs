using FileHelpers;
using System.Linq;

namespace FileMasta.Core.Models
{
    [DelimitedRecord(",")]
    public class DataItem
    {
        public string WebsiteId { get; set; }
        public string WebsiteUrl { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Ext { get; set; }
        public string Size { get; set; }
        public string Mtime { get; set; }

        public bool IsType(string[] type) => type == FileType.All || type.Any(x => Ext.Contains(x.ToUpper()));
    }
}