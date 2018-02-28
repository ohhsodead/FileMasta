using System.Drawing;

namespace FileMasta.Extensions
{
    public class Colors
    {
        /// <summary>
        /// Get UI Colors
        /// </summary>
        public static Color SelectedTitleRGB { get; } = Color.FromArgb(40, 40, 40);
        public static Color NonSelectedTitleRGB { get; } = Color.FromArgb(10, 10, 10);
        public static Color ColorOrange { get; } = Color.FromArgb(223, 105, 26);
        public static Color ColorGray { get; } = Color.FromArgb(190, 193, 190);
        public static Color SelectedRGB { get; } = ColorOrange;
        public static Color NonSelectedRGB { get; } = Color.Transparent;
        public static Color SelectedForeRGB { get; } = Color.White;
        public static Color NonSelectedForeRGB { get; } = Color.Silver;
    }
}