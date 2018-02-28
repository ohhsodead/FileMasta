namespace FileMasta.Models
{
    /// <summary>
    /// Represents a Bookmark class
    /// </summary>
    public partial class Bookmark
    {
        public string URL { get; set; }

        public Bookmark(string url)
        {
            URL = url;
        }
    }
}
