using System.Configuration;

namespace FileMasta.Extensions
{
    internal abstract class AppExtensions
    {
        /// <summary>
        /// Retrieve the url of the project hosted on GitHub
        /// </summary>
        public static readonly string ProjectUrl = ConfigurationManager.AppSettings["url.project"];

        /// <summary>
        /// Retrieve the url of the project's change log file
        /// </summary>
        public static readonly string ChangelogUrl = ConfigurationManager.AppSettings["fileUrl.changelog"];

        /// <summary>
        /// Retrieve the url containing the latest project version
        /// </summary>
        public static readonly string VersionUrl = ConfigurationManager.AppSettings["fileUrl.version"];

        /// <summary>
        /// Retrieve the url pointing to the database location
        /// </summary>
        public static readonly string DatabaseUrl = ConfigurationManager.AppSettings["fileUrl.database"];

        /// <summary>
        /// Retrieve the file name of the database
        /// </summary>
        public static readonly string DatabaseFilename = ConfigurationManager.AppSettings["fileName.database"];

        /// <summary>
        /// Retrieve the file name of the users bookmarked data
        /// </summary>
        public static readonly string SavedFilename = ConfigurationManager.AppSettings["fileName.saved"];
    }
}