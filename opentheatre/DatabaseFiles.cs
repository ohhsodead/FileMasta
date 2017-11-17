namespace DatabaseFilesAPI
{
    using Newtonsoft.Json;

    public partial class DatabaseFiles
    {
        [JsonProperty("URL")]
        public string URL { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Host")]
        public string Host { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }
    }

    public partial class DatabaseFiles
    {
        public static DatabaseFiles FromJson(string json) => JsonConvert.DeserializeObject<DatabaseFiles>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DatabaseFiles self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
