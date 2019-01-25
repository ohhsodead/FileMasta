namespace FileMasta.Data
{
    internal abstract class Types
    {
        public static string[] All { get; } = { };
        public static string[] Audio { get; } = { "AAC", "AC3", "AIF", "AIFC", "AIFF", "AU", "CDA", "DTS", "FLA", "FLAC", "IT", "M1A", "M2A", "M3U", "M4A", "MID", "MIDI", "MKA", "MOD", "MP2", "MP3", "MPA", "OGG", "RA", "RMI", "SPC", "RMI", "SND", "UMX", "VOC", "WAV", "WMA", "XM" };
        public static string[] Compressed { get; } = { "7Z", "ACE", "ARJ", "BZ2", "CAB", "GZ", "GZIP", "JAR", "R00", "R01", "R02", "R03", "R04", "R05", "R06", "R07", "R08", "R09", "R10", "R11", "R12", "R13", "R14", "R15", "R16", "R17", "R18", "R19", "R20", "R21", "R22", "R23", "R24", "R25", "R26", "R27", "R28", "R29", "RAR", "TAR", "TGZ", "Z", "ZIP" };
        public static string[] Document { get; } = { "C", "CHM", "CPP", "CSV", "CXX", "DOC", "DOCM", "DOCX", "DOT", "DOTM", "DOTX", "H", "HPP", "HTM", "HTML", "HXX", "INI", "JAVA", "LUA", "MHT", "MHTML", "ODT", "PDF", "POTX", "POTM", "PPAM", "PPSM", "PPSX", "PPS", "PPT", "PPTM", "PPTX", "RTF", "SLDM", "SLDX", "THMX", "TXT", "VSD", "WPD", "WPS", "WRI", "XLAM", "XLS", "XLSB", "XLSM", "XLSX", "XLTM", "XLTX", "XML" };
        public static string[] Executable { get; } = { "BAT", "CMD", "EXE", "MSI", "MSP", "SCR" };
        public static string[] Picture { get; } = { "ANI", "BMP", "GIF", "ICO", "JPE", "JPEG", "JPG", "PCX", "PNG", "PSD", "TGA", "TIF", "TIFF", "WMF" };
        public static string[] Video { get; } = { "3G2", "3GP", "3GP2", "3GPP", "AMR", "AMV", "ASF", "AVI", "BDMV", "BIK", "D2V", "DIVX", "DRC", "DSA", "DSM", "DSS", "DSV", "EVO", "F4V", "FLC", "FLI", "FLIC", "FLV", "HDMOV", "IFO", "IVF", "M1V", "M2P", "M2T", "M2TS", "M2V", "M4B", "M4P", "M4V", "MKV", "MP2V", "MP4", "MP4V", "MPE", "MPEG", "MPG", "MPLS", "MPV2", "MPV4", "MOV", "MTS", "OGM", "OGV", "PSS", "PVA", "QT", "RAM", "RATDVD", "RM", "RMM", "RMVB", "ROQ", "RPM", "SMIL", "SMK", "SWF", "TP", "TPR", "TS", "VOB", "VP6", "WEBM", "WM", "WMP", "WMV" };
    }
}