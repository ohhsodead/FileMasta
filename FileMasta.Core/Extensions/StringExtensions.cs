using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FileMasta.Core.Extensions
{
    internal abstract class StringExtensions
    {
        /// <summary>
        /// Gets the file name from a given url
        /// </summary>
        /// <param name="url">File Url</param>
        /// <returns>File Name</returns>
        public static string GetFileName(string url)
        {
            return Uri.EscapeDataString(url.Substring(url.LastIndexOf('/') + 1));
        }

        /// <summary>
        /// Determines whether the string contains all the given sub strings
        /// </summary>
        /// <param name="source"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool ContainsAll(string source, params string[] values)
        {
            return values.All(x => source.ToLower().Contains(x));
        }

        /// <summary>
        /// Get an array of words from the input
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Sub strings in string</returns>
        public static string[] GetWords(string value)
        {
            MatchCollection matches = Regex.Matches(value, @"\b[\w']*\b");

            System.Collections.Generic.IEnumerable<string> words = from m in matches.Cast<Match>()
                where !string.IsNullOrEmpty(m.Value)
                select TrimSuffix(m.Value);

            return words.ToArray();
        }

        /// <summary>
        /// Removes the last occurance of the backslash
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string TrimSuffix(string value)
        {
            int backslashIndex = value.IndexOf('\'');
            if (backslashIndex != -1)
                value = value.Substring(0, backslashIndex);

            return value;
        }
    }
}