using System;

namespace WebCrunch.Models
{
    /// <summary>
    /// Represents the database information
    /// </summary>
    public partial class DatabaseInfo
    {
        public DateTime LastUpdated { get; set; } = DateTime.MinValue;
    }
}
