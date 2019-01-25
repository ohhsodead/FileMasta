using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FileMasta.Extensions
{
    internal abstract class StringExtensions
    {
        /// <summary>
        /// Returns all sub strings in string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Sub strings in string</returns>
        public static string[] GetWords(string input)
        {
            var matches = Regex.Matches(input, @"\b[\w']*\b");

            var words = from m in matches.Cast<Match>()
                        where !string.IsNullOrEmpty(m.Value)
                        select TrimSuffix(m.Value);

            return words.ToArray();
        }

        private static string TrimSuffix(string word)
        {
            var apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
                word = word.Substring(0, apostropheLocation);            

            return word;
        }

        /// <summary>
        /// If string contains all sub strings
        /// </summary>
        /// <param name="source"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool ContainsAll(string source, params string[] values)
        {
            return values.All(x => source.ToLower().Contains(x));
        }

        /// <summary>
        /// Return number represented as string with comma's for thousands
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatNumber(long value)
        {
            return $"{Convert.ToInt32(value):n0}";
        }

        /// <summary>
        /// Size suffixes
        /// </summary>
        private static readonly string[] SizeSuffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        /// <summary>
        /// Return file size with suffix e.g. Bytes, MB, GB
        /// </summary>
        /// <param name="byteCount"></param>
        /// <returns>Bytes in string format</returns>
        public static string BytesToPrefix(long byteCount)
        {
            if (byteCount == 0)
                return "0" + " " + SizeSuffixes[0];
            var bytes = Math.Abs(byteCount);
            var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            var num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num) + " " + SizeSuffixes[place];
        }

        /// <summary>
        /// Returns the total number of bytes from parsing the size prefix
        /// </summary>
        /// <param name="prefixSize"></param>
        /// <returns></returns>
        public static long ParseFileSize(string prefixSize)
        {
            // Remove leading and trailing spaces.
            prefixSize = prefixSize.Trim();

            try
            {
                // Find the last non-alphabetic character.
                var extStart = 0;
                for (var i = prefixSize.Length - 1; i >= 0; i--)
                {
                    // Stop if we find something other than a letter.
                    if (char.IsLetter(prefixSize, i)) continue;
                    extStart = i + 1;
                    break;
                }

                // Get the numeric part.
                var number = double.Parse(prefixSize.Substring(0, extStart));

                // Get the extension.
                string suffix;
                if (extStart < prefixSize.Length)
                {
                    suffix = prefixSize.Substring(extStart).Trim();
                    if (suffix == "BYTES") suffix = "Bytes";
                }
                else
                {
                    suffix = "Bytes";
                }

                // Find the extension in the list.
                var suffixIndex = -1;
                for (var i = 0; i < SizeSuffixes.Length; i++)
                {
                    if (SizeSuffixes[i] != suffix) continue;
                    suffixIndex = i;
                    break;
                }
                if (suffixIndex < 0)
                    throw new FormatException(
                        "Unknown file size prefix " + suffix + ".");

                // Return the result.
                return (long)Math.Round(number * Math.Pow(1024, suffixIndex));
            }
            catch (Exception ex)
            {
                throw new FormatException("Invalid file size format", ex);
            }
        }

        /// <summary>
        /// Get age from DateTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string TimeSpanAge(DateTime date)
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;

            var ts = new TimeSpan(DateTime.UtcNow.Ticks - date.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * minute)
                return ts.Seconds == 1 ? "1 second" : ts.Seconds + " seconds";

            if (delta < 2 * minute)
                return "1 minute";

            if (delta < 45 * minute)
                return ts.Minutes + " minutes";

            if (delta < 90 * minute)
                return "1 hour";

            if (delta < 24 * hour)
                return ts.Hours + " hours";

            if (delta < 48 * hour)
                return "1 day";

            if (delta < 30 * day)
                return ts.Days + " days";

            if (delta < 12 * month) {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "1 month" : months + " months";
            }

            var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
            return years <= 1 ? "1 year" : years + " years";
        }
    }
}