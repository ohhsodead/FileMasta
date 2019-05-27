using System;

namespace FileMasta.Extensions
{
    internal abstract class StringExtensions
    {
        /// <summary>
        /// Gets the file name from url
        /// </summary>
        /// <param name="url">File Url</param>
        /// <returns>File Name</returns>
        public static string GetFileName(string url)
        {
            return Uri.EscapeDataString(url.Substring(url.LastIndexOf('/') + 1));
        }

        /// <summary>
        /// Gets the file extension from url
        /// </summary>
        /// <param name="url">File Url</param>
        /// <returns>File Name</returns>
        public static string GetFileExtension(string url)
        {
            return url.Substring(url.LastIndexOf('.') + 1);
        }

        /// <summary>
        /// Return the value represented as string with commas
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
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num) + " " + SizeSuffixes[place];
        }

        /// <summary>
        /// Return the total number of bytes from parsing the size prefix
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
                int extStart = 0;
                for (int i = prefixSize.Length - 1; i >= 0; i--)
                {
                    // Stop if we find something other than a letter.
                    if (char.IsLetter(prefixSize, i)) continue;
                    extStart = i + 1;
                    break;
                }

                // Get the numeric part.
                double number = double.Parse(prefixSize.Substring(0, extStart));

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
                int suffixIndex = -1;
                for (int i = 0; i < SizeSuffixes.Length; i++)
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
    }
}