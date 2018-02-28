using System;

namespace FileMasta.Models
{
    /// <summary>
    /// Represents the database information
    /// </summary>
    public partial class DatabaseInfo
    {
        public DateTime LastUpdated { get; set; } = DateTime.MinValue;
    }
}
