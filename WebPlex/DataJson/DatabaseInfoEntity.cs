namespace jsonDatabaseInfo
{
    using Newtonsoft.Json;

    public partial class DatabaseInfoEntity
    {
        [JsonProperty("LastUpdated")]
        public string LastUpdated { get; set; }
    }

    public partial class DatabaseInfoEntity
    {
        public static DatabaseInfoEntity FromJson(string json) => JsonConvert.DeserializeObject<DatabaseInfoEntity>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DatabaseInfoEntity self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
