using System;
using System.Configuration;
using System.IO;

namespace FileMasta
{
    public abstract class Configuration
    {
        /// <summary>
        /// Application cache data directory, used for storing database and bookmarks
        /// </summary>
        public static string AppWorkingDirectory { get; } = Environment.CurrentDirectory;

        /// <summary>
        /// Url to project hosted on GitHub
        /// </summary>
        public static string ProjectUrl { get; } = ConfigurationManager.AppSettings["url.project"];

        /// <summary>
        /// Url to the projects changelog file
        /// </summary>
        public static string ChangelogUrl { get; } = ConfigurationManager.AppSettings["fileUrl.changelog"];

        /// <summary>
        /// Url to the latest application version
        /// </summary>
        public static string VersionUrl { get; } = ConfigurationManager.AppSettings["fileUrl.version"];

        /// <summary>
        /// Url to the core database file
        /// </summary>
        public static string DatabaseUrl { get; } = ConfigurationManager.AppSettings["fileUrl.database"];

        /// <summary>
        /// Database cache file path
        /// </summary>
        public static string DatabaseLocation { get; } = Path.Combine(AppWorkingDirectory, ConfigurationManager.AppSettings["fileName.database"]);
        /// <summary>
        /// Bookmarked file path
        /// </summary>
        public static string BookmarkedLocation { get; } = Path.Combine(AppWorkingDirectory, ConfigurationManager.AppSettings["fileName.bookmarked"]);
    }
}