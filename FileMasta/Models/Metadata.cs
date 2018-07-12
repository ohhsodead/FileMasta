using System;

namespace FileMasta.Models
{
    /// <summary>
    /// Represents the database information
    /// </summary>
    public partial class Metadata
    {
        public DateTime Updated { get; set; } = DateTime.MinValue;
        public long Files { get; set; } = 0;
    }
}