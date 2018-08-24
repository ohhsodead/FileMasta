using System;
using System.Drawing;

namespace FileMasta.Extensions
{
    class ImageExtensions
    {
        /// <summary>
        /// Returns a Bitmap with the specified colour (Image must be one colour) https://stackoverflow.com/a/17209284
        /// </summary>
        /// <param name="scrBitmap"></param>
        /// <param name="newColor"></param>
        /// <returns></returns>
        public static Bitmap ChangeColor(Bitmap scrBitmap, Color newColor)
        {
            try
            {
                Color actualColor;
                //make an empty bitmap the same size as scrBitmap
                var newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
                for (int i = 0; i < scrBitmap.Width; i++)
                    for (int j = 0; j < scrBitmap.Height; j++)
                    {
                        //get the pixel from the scrBitmap image
                        actualColor = scrBitmap.GetPixel(i, j);
                        // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                        if (actualColor.A > 150)
                            newBitmap.SetPixel(i, j, newColor);
                        else
                            newBitmap.SetPixel(i, j, actualColor);
                    }
                return newBitmap;
            }
            catch (Exception ex) { Program.Log.Error("Error changing image colour", ex); return null; }
        }
    }
}