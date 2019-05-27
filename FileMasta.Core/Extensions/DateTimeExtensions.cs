using System;

namespace FileMasta.Core.Extensions
{
    internal abstract class DateTimeExtensions
    {
        /// <summary>
        /// Parse a Unix TimeStamp to DateTime
        /// </summary>
        /// <param name="timeStamp">TimeStamp in Seconds</param>
        /// <returns></returns>
        public static DateTime ParseTimeStamp(double timeStamp)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(timeStamp).ToLocalTime();
            return dt;
        }
    }
}