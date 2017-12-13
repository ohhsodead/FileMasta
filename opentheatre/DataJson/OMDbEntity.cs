namespace OMDbAPI
{
    using Newtonsoft.Json;

    public partial class OMDbEntity
    {
        [JsonProperty("Sources")]
        public string[] Sources { get; set; }

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("Response")]
        public string Response { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Awards")]
        public string Awards { get; set; }

        [JsonProperty("Actors")]
        public string Actors { get; set; }

        [JsonProperty("BoxOffice")]
        public string BoxOffice { get; set; }

        [JsonProperty("Director")]
        public string Director { get; set; }

        [JsonProperty("DVD")]
        public string DVD { get; set; }

        [JsonProperty("Genre")]
        public string Genre { get; set; }

        [JsonProperty("Production")]
        public string Production { get; set; }

        [JsonProperty("Plot")]
        public string Plot { get; set; }

        [JsonProperty("Metascore")]
        public string Metascore { get; set; }

        [JsonProperty("Poster")]
        public string Poster { get; set; }

        [JsonProperty("Ratings")]
        public Rating[] Ratings { get; set; }

        [JsonProperty("Rated")]
        public string Rated { get; set; }

        [JsonProperty("Released")]
        public string Released { get; set; }

        [JsonProperty("Website")]
        public string Website { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Runtime")]
        public string Runtime { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("imdbRating")]
        public string ImdbRating { get; set; }

        [JsonProperty("Writer")]
        public string Writer { get; set; }

        [JsonProperty("imdbID")]
        public string ImdbID { get; set; }

        [JsonProperty("imdbVotes")]
        public string ImdbVotes { get; set; }

        // Popcorn Time
        [JsonProperty("imageFanart")]
        public string imageFanart { get; set; }

        [JsonProperty("trailerUrl")]
        public string trailerUrl { get; set; }

        // YIFY
        [JsonProperty("torrent480p")]
        public string torrent480p { get; set; }

        [JsonProperty("torrent720p")]
        public string torrent720p { get; set; }

        [JsonProperty("torrent1080p")]
        public string torrent1080p { get; set; }
    }

    public partial class Rating
    {
        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class OMDbEntity
    {
        public static OMDbEntity FromJson(string json) => JsonConvert.DeserializeObject<OMDbEntity>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OMDbEntity self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
