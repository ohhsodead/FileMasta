using System.Collections.Generic;

namespace FileMasta.Files
{
    class Types
    {
        /// <summary>
        /// Supported file extensions by type/category, matches the ones used in the crawler
        /// </summary>
        public static List<string> All { get; set; } = new List<string>();
        public static List<string> Video { get; } = new List<string>() { "MXG", "M2TS", "MP4", "MKV", "AVI", "MPEG", "MPG", "MOV", "M4V", "WMV", "FLV" };
        public static List<string> Audio { get; } = new List<string>() { "MP3", "WMA", "WAV", "M3U", "APE", "AIF", "MPA", "CDA", "AC3", "OGG", "FLAC", "M4A" };
        public static List<string> Image { get; } = new List<string>() { "ICO", "TIFF", "TIF", "JPEG", "JPG", "BMP", "GIF", "PNG", "EPS", "RAW", "SVG" };
        public static List<string> Book { get; } = new List<string>() { "MOBI", "CBZ", "CBR", "CBC", "CHM", "EPUB", "FB2", "LIT", "LRF", "ODT", "PDF", "PRC", "PDB", "PML", "RB", "RTF", "TCR", "DOC", "DOCX" };
        public static List<string> Software { get; } = new List<string>() { "BAT", "DAT", "MSP", "MSI", "EXE", "VOB", "ZIP", "TAR", "RAR", "7Z", "ISO", "PKG", "TAR.GZ", "APK", "IPA", "APPX", "XAP", "JAR" };
        public static List<string> Torrent { get; } = new List<string>() { "TORRENT" };
        public static List<string> Subtitle { get; } = new List<string>() { "SRT", "SUB", "VTT" };
        public static List<string> Other { get; } = new List<string>() { "README", "CFG", "RPM", "ASC", "INI", "ASM", "MD", "DLL", "SFV", "CPK", "RPT", "CAB", "URL", "CF1", "CF2", "INF", "NFO", "MQ4", "NDS", "JSP", "GG", "SWF", "PS", "RTF", "BAS", "CC", "C", "CPP", "CXX", "H", "HPP", "CS", "JAVA", "PY", "PL", "PHP", "DB", "HTM", "HTML", "ASPX", "XML", "TXT", "SQL", "CSV", "PSD", "GZ", "BIN", "LOG", "CUE", "PAR", "PAR2", "PYK", "PK3", "PK4", "SKB", "IMG", "HGZ", "AI", "OTF", "TTF", "CSS", "PLS", "Z64" };
    }
}