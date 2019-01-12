using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FileMasta.Extensions
{
    class StringExtensions
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

        public static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
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
        /// Get random string from a collection of strings
        /// </summary>
        /// <param name="Items"></param>
        /// <returns></returns>
        public static string Random(ICollection<string> items)
        {
            var Rndm = new Random();
            var StringList = new List<string>(items);
            return StringList[Rndm.Next(0, items.Count)];
        }

        /// <summary>
        /// Return number represented as string with comma's for thousands
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatNumber(string value)
        {
            return string.Format("{0:n0}", Convert.ToInt32(value));
        }

        private static string[] SizeSuffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        /// <summary>
        /// Return file size with suffix e.g. Bytes, MB, GB
        /// </summary>
        /// <param name="byteCount"></param>
        /// <returns>Bytes in string format</returns>
        public static string BytesToPrefix(long byteCount)
        {
            if (byteCount == 0)
                return "0" + " " + SizeSuffixes[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + " " + SizeSuffixes[place];
        }
        
        /// <summary>
        /// Returns the total number of bytes from parsing the size prefix
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ParseFileSize(string prefixSize)
        {
            // Remove leading and trailing spaces.
            prefixSize = prefixSize.Trim();

            try
            {
                // Find the last non-alphabetic character.
                int ext_start = 0;
                for (int i = prefixSize.Length - 1; i >= 0; i--)
                {
                    // Stop if we find something other than a letter.
                    if (!char.IsLetter(prefixSize, i))
                    {
                        ext_start = i + 1;
                        break;
                    }
                }

                // Get the numeric part.
                double number = double.Parse(prefixSize.Substring(0, ext_start));

                // Get the extension.
                string suffix;
                if (ext_start < prefixSize.Length)
                {
                    suffix = prefixSize.Substring(ext_start).Trim();
                    if (suffix == "BYTES") suffix = "Bytes";
                }
                else
                {
                    suffix = "Bytes";
                }

                // Find the extension in the list.
                int suffix_index = -1;
                for (int i = 0; i < SizeSuffixes.Length; i++)
                {
                    if (SizeSuffixes[i] == suffix)
                    {
                        suffix_index = i;
                        break;
                    }
                }
                if (suffix_index < 0)
                    throw new FormatException(
                        "Unknown file size prefix " + suffix + ".");

                // Return the result.
                return (long)Math.Round(number * Math.Pow(1024, suffix_index));
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
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = new TimeSpan(DateTime.UtcNow.Ticks - date.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return ts.Seconds == 1 ? "1 second" : ts.Seconds + " seconds";

            if (delta < 2 * MINUTE)
                return "1 minute";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " minutes";

            if (delta < 90 * MINUTE)
                return "1 hour";

            if (delta < 24 * HOUR)
                return ts.Hours + " hours";

            if (delta < 48 * HOUR)
                return "1 day";

            if (delta < 30 * DAY)
                return ts.Days + " days";

            if (delta < 12 * MONTH) {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "1 month" : months + " months";
            }
            else {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "1 year" : years + " years";
            }
        }

        /// <summary>
        /// Get parent folder path in the uri structure
        /// </summary>
        /// <param name="uri"></param>
        /// <returns>Parent folder url</returns>
        public static string ParentDirectory(Uri uri)
        {
            StringBuilder parentName = new StringBuilder();
            parentName.Append(uri.Scheme);
            parentName.Append("://");
            parentName.Append(uri.Host);
            for (int i = 0; i < uri.Segments.Length - 1; i++)
                parentName.Append(uri.Segments[i]);
            return parentName.ToString();
        }

        /// <summary>
        /// Checks if string is valid Json
        /// </summary>
        /// <param name="json"></param>
        /// <returns>If valid json</returns>
        public static bool IsValidJSON(string json)
        {
            try {
                JToken token = JObject.Parse(json);
                return true;
            }
            catch {
                return false;
            }
        }
    }
}