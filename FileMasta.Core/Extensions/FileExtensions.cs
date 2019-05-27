using FileMasta.Core.Models;
using System;
using System.IO;

namespace FileMasta.Core.Extensions
{
    public abstract class FileExtensions
    {
        /// <summary>
        /// Converts a data record item to a file object with properties
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static FileItem DataItemToFile(DataItem data)
        {
            if (data == null) return null;

            _ = double.TryParse(
                (data.Mtime ?? string.Empty).ToString(),
                out double unixTimestamp);
            _ = long.TryParse(
                (data.Size ?? string.Empty).ToString(),
                out long fileSize);

            return new FileItem(
                        string.IsNullOrEmpty(data.Ext)
                        ? data.Name
                        : data.Name + "." + data.Ext,
                        fileSize,
                        DateTimeExtensions.ParseTimeStamp(unixTimestamp),
                        string.IsNullOrEmpty(data.Ext)
                ? data.WebsiteUrl.Substring(0, data.WebsiteUrl.IndexOf('/', data.WebsiteUrl.IndexOf('/') + 2)) + "/" + data.Path + "/" + data.Name
                : data.WebsiteUrl.Substring(0, data.WebsiteUrl.IndexOf('/', data.WebsiteUrl.IndexOf('/') + 2)) + "/" + data.Path + "/" + data.Name + "." + data.Ext);

        }

        public static DataItem FileItemToData(FileItem file)
        {
            Uri fileUri = new Uri(file.Url);
            return new DataItem()
            {
                WebsiteId = "0",
                WebsiteUrl = fileUri.GetLeftPart(UriPartial.Authority) + "/",
                Path = Path.GetDirectoryName(fileUri.LocalPath).Replace(@"\", "/").TrimStart('/'),
                Name = Path.GetFileNameWithoutExtension(file.Name),
                Ext = file.GetExtension(),
                Size = file.Size.ToString(),
                Mtime = ((DateTimeOffset)file.Mtime).ToUnixTimeSeconds().ToString()
            };
        }

        /// <summary>
        /// Creates a file object from the given link
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static FileItem CreateFile(string url)
        {
            return new FileItem(
                Path.GetFileName(url),
                HttpExtensions.GetFileSize(new Uri(url)),
                HttpExtensions.GetFileLastModified(new Uri(url)),
                url);
        }

        public static FileItem CreateFile(long size, string url)
        {
            return new FileItem(
                Path.GetFileName(url),
                size,
                HttpExtensions.GetFileLastModified(new Uri(url)),
                url);
        }

        public static FileItem CreateFile(DateTime mTime, string url)
        {
            return new FileItem(
                Path.GetFileName(url),
                HttpExtensions.GetFileSize(new Uri(url)),
                mTime,
                url);
        }

        public static FileItem CreateFile(DateTime mTime, long size, string url)
        {
            return new FileItem(
                Path.GetFileName(url),
                size,
                mTime,
                url);
        }

        public static long CountLines(string fileName)
        {
            long count = -1;
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}