using System;

namespace FileMasta.Extensions
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

            TimeSpan ts = new TimeSpan(DateTime.UtcNow.Ticks - date.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

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
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "1 month" : months + " months";
            }

            int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
            return years <= 1 ? "1 year" : years + " years";
        }
    }
}