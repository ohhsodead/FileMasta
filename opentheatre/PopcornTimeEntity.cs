namespace PopcornTimeAPI
{
    using Newtonsoft.Json;

    public partial class PopcornTimeEntity
    {
        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("runtime")]
        public string Runtime { get; set; }

        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("genres")]
        public string[] Genres { get; set; }

        [JsonProperty("rating")]
        public Rating Rating { get; set; }

        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        [JsonProperty("released")]
        public long Released { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("trailer")]
        public string Trailer { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("torrents")]
        public Torrents Torrents { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }
    }

    public partial class Images
    {
        [JsonProperty("fanart")]
        public string Fanart { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("poster")]
        public string Poster { get; set; }
    }

    public partial class Rating
    {
        [JsonProperty("loved")]
        public long Loved { get; set; }

        [JsonProperty("votes")]
        public long Votes { get; set; }

        [JsonProperty("hated")]
        public long Hated { get; set; }

        [JsonProperty("percentage")]
        public long Percentage { get; set; }

        [JsonProperty("watching")]
        public long Watching { get; set; }
    }

    public partial class Torrents
    {
        [JsonProperty("en")]
        public En En { get; set; }
    }

    public partial class En
    {
        [JsonProperty("1080p")]
        public The1080p The1080p { get; set; }

        [JsonProperty("720p")]
        public The1080p The720p { get; set; }
    }

    public partial class The1080p
    {
        [JsonProperty("peer")]
        public long Peer { get; set; }

        [JsonProperty("seed")]
        public long Seed { get; set; }

        [JsonProperty("filesize")]
        public string Filesize { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class The720p
    {
        [JsonProperty("peer")]
        public long Peer { get; set; }

        [JsonProperty("seed")]
        public long Seed { get; set; }

        [JsonProperty("filesize")]
        public string Filesize { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class PopcornTimeEntity
    {
        public static PopcornTimeEntity FromJson(string json) => JsonConvert.DeserializeObject<PopcornTimeEntity>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PopcornTimeEntity self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
