using Extensions;
using Models;
using System;
using System.IO;
using WebCrunch;

namespace Utilities
{
    class Database
    {
        /// <summary>
        /// Get file info from local database
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static WebFile FileInfoFromURL(string URL)
        {
            foreach (var file in MainForm.dataOpenFiles)
            {
                if (file.URL == URL)
                {
                    return file;
                }
            }

            /* Return a new Web File object, as this URL doesn't exist in the database anymore */
            return new WebFile(Path.GetExtension(URL).Replace(".", "").ToUpper(), Path.GetFileNameWithoutExtension(new Uri(URL).LocalPath), FileExtensions.GetFileSize(URL), FileExtensions.GetFileLastModified(URL), new Uri(URL).Host.Replace("www.", ""), new Uri(URL).AbsoluteUri);
        }
    }
}
