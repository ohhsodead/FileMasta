namespace DatabaseFileAPI
{
    using Newtonsoft.Json;

    public partial class DatabaseFilesEntity
    {
        [JsonProperty("URL")]
        public string URL { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
        
        [JsonProperty("Size")]
        public string Size { get; set; }

        [JsonProperty("DateAdded")]
        public string DateAdded { get; set; }

        [JsonProperty("Host")]
        public string Host { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }
    }

    public partial class DatabaseFilesEntity
    {
        public static DatabaseFilesEntity FromJson(string json) => JsonConvert.DeserializeObject<DatabaseFilesEntity>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DatabaseFilesEntity self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
