using System.Linq;

namespace FileMasta.Utilities
{
    internal abstract class ExternalEngine
    {
        public enum Engine
        {
            Google,
            Googol,
            StartPage,
            Searx
        }

        public static string Google { get; set; } = "https://google.com/search?q=";
        public static string Googol { get; set; } = "https://googol.warriordudimanche.net/?q=";
        public static string StartPage { get; set; } = "https://startpage.com/do/dsearch?query=";
        public static string Searx { get; set; } = "https://searx.me/?q=";

        public static string CreateUrl(Engine engine, string name, string[] types)
        {
            string rootUrl = Google;

            if (engine == Engine.Google)
            {
                rootUrl = Google;
            }
            else if (engine == Engine.Googol)
            {
                rootUrl = Googol;
            }
            else if (engine == Engine.StartPage)
            {
                rootUrl = StartPage;
            }
            else if (engine == Engine.Searx)
            {
                rootUrl = Searx;
            }

            return $"{rootUrl}{name} %2B({string.Join("|", types.ToArray()).ToLower()}) %2Dinurl:(jsp|pl|php|html|aspx|htm|cf|shtml) intitle:index.of %2Dinurl:(listen77|mp3raid|mp3toss|mp3drug|index_of|index-of|wallywashis|downloadmana)";
        }
    }
}