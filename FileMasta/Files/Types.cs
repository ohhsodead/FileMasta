using System.Collections.Generic;

namespace FileMasta.Files
{
    class Types
    {
        /// <summary>
        /// Supported file extensions, matches the ones in the crawler
        /// </summary>
        public static List<string> All { get; set; } = new List<string>();
        public static List<string> Video { get; } = new List<string>() { "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV" };
        public static List<string> Books { get; } = new List<string>() { "MOBI", "CBZ", "CBR", "CBC", "CHM", "EPUB", "FB2", "LIT", "LRF", "ODT", "PDF", "PRC", "PDB", "PML", "RB", "RTF", "TCR", "DOC", "DOCX" };
        public static List<string> Audio { get; } = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA", "AC3", "OGG", "FLAC", "M4A" };
        public static List<string> Software { get; } = new List<string>() { "EXE", "VOB", "ZIP", "TAR", "RAR", "7Z", "ISO", "PKG", "TAR.GZ", "APK", "IPA", "APPX", "XAP" };
        public static List<string> Torrent { get; } = new List<string>() { "TORRENT" };
        public static List<string> Subtitle { get; } = new List<string>() { "SRT", "SUB", "VTT" };
        public static List<string> Other { get; } = new List<string>() { "JSP", "PL", "PHP", "HTML", "ASPX", "XML", "TXT", "SQL", "CSV" };
    }
}
