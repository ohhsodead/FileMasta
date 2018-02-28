using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace FileMasta.Extensions
{
    class ImageExtensions
    {
        /// <summary>
        /// Return a Bitmap from a Image Url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Bitmap LoadPictureFromURL(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp = null;
            Stream mystream = null ;
            Bitmap bmp = null;

            try {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;
                wresp = (HttpWebResponse)wreq.GetResponse();
                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            catch { }
            finally {
                if (mystream != null)
                    mystream.Close();
                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }

        /// <summary>
        /// Set Bitmap Alpha (255-Visible 0-Invisible)
        /// </summary>
        /// <param name="bmpIn"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            var bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            var r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, a, 0},
                new float[] {0, 0, 0, 0, 1}};

            var colorMatrix = new ColorMatrix(matrixItems);

            var imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (var g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

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
            } catch (Exception ex) { Program.log.Error("Error changing image colour", ex); return null; }
        }
    }
}