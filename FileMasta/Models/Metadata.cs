namespace FileMasta.Models
{
    /// <summary>
    /// Represents the database information
    /// </summary>
    public class Metadata
    {
        public readonly long TotalNoFiles;
        public readonly long TotalFilesSize;

        public Metadata(long totalNoFiles, long totalFilesSize)
        {
            TotalNoFiles = totalNoFiles;
            TotalFilesSize = totalFilesSize;
        }
    }
}