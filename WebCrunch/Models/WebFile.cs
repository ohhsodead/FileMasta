namespace Models
{
    /// <summary>
    /// Represents a Web File
    /// </summary>
    public partial class WebFile
    {
        public string URL { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string DateAdded { get; set; }
        public string Host { get; set; }
        public string Title { get; set; }
    }
}
