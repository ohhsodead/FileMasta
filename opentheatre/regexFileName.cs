using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regexFileName
{
    public class fileNames
    {
        public static string[] getTVShowName(string input)
        {
            string Standard = @"^((?<series_name>.+?)[. _-]+)?s(?<season_num>\d+)[. _-]*e(?<ep_num>\d+)(([. _-]*e|-)(?<extra_ep_num>(?!(1080|720)[pi])\d+))*[. _-]*((?<extra_info>.+?)((?<![. _-])-(?<release_group>[^-]+))?)?$";
            var regexStandard = new Regex(Standard, RegexOptions.IgnoreCase);
            Match episode = regexStandard.Match(input);
            var Showname = episode.Groups["series_name"].Value;
            var Season = episode.Groups["season_num"].Value;
            var Episode = episode.Groups["ep_num"].Value;

            string[] tvshow = { Showname, Season, Episode };
            return tvshow;
        }

        public static string[] getMovieAndYear(string input)
        {
            string pattern = @"(?'title'.*)\.(?'year'[^\.]+)\.(?'pixelsize'[^\.]+)\.(?'format'[^\.]+)\.(?'formatsize'[^\.]+)\.(?'filename'[^\.]+)\.(?'extension'[^\.]+)";
            Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            string extension = match.Groups["extension"].Value;
            string fileName = match.Groups["filename"].Value;
            string formatSize = match.Groups["formatsize"].Value;
            string format = match.Groups["format"].Value;
            string pixelSize = match.Groups["pixelsize"].Value;
            string year = match.Groups["year"].Value;
            string title = match.Groups["title"].Value;
            title = title.Replace(".", " ");

            string[] movie = { title, year };
            return movie;
        }
    }
}
