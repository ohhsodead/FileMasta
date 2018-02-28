using System.Collections.Generic;
using FileMasta.Models;

namespace FileMasta.Files
{
    class SortFiles
    {
        /// <summary>
        /// Sort Files by Name, Size or Date using these methods
        /// </summary>

        static int switchName = 0;
        public static void ByName(List<WebFile> dataFiles)
        {
            if (switchName == 0)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    return x.Name.CompareTo(y.Name);
                });
                switchName = 1;
            }
            else if (switchName == 1)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    return y.Name.CompareTo(x.Name);
                });
                switchName = 0;
            }
        }

        static int switchSize = 0;
        public static void BySize(List<WebFile> dataFiles)
        {
            if (switchSize == 0)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    return x.Size.CompareTo(y.Size);
                });
                switchSize = 1;
            }
            else if (switchSize == 1)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    return y.Size.CompareTo(x.Size);
                });
                switchSize = 0;
            }
        }

        static int switchDate = 1;
        public static void ByDate(List<WebFile> dataFiles)
        {
            if (switchDate == 0)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    return y.DateUploaded.CompareTo(x.DateUploaded);
                });
                switchDate = 1;
            }
            else if (switchDate == 1)
            {
                dataFiles.Sort(delegate (WebFile x, WebFile y)
                {
                    return x.DateUploaded.CompareTo(y.DateUploaded);
                });
                switchDate = 0;
            }
        }
    }
}