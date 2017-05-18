using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using steganography.Exceptions;

namespace steganography
{
    public class Steganolizer
    {
        private Bitmap hostImage;
        private Bitmap srcImage;
        private int shift;

        public Steganolizer()
        {
            shift = 4; // default value
        }

        public Bitmap HostImage
        {
            get
            {
                return hostImage;
            }

            set
            {
                hostImage = value;
            }
        }

        public Bitmap SrcImage
        {
            get
            {
                return srcImage;
            }

            set
            {
                srcImage = value;
            }
        }

        public int Shift
        {
            get
            {
                return shift;
            }

            set
            {
                shift = value;
            }
        }

        /// <summary>
        /// Check if host and source images are not null
        /// </summary>
        /// <returns></returns>
        public bool AreImagesReady()
        {
            return hostImage != null && srcImage != null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Bitmap Execute()
        {
            CheckBeforeExecute();

            Bitmap bmp = new Bitmap(hostImage);

            for (int x = 0; x < srcImage.Width; x++)
            {
                for (int y = 0; y < srcImage.Height; y++)
                {
                    // Calculate RGB
                    Color pixelHost = hostImage.GetPixel(x, y);
                    Color pixelSrc = srcImage.GetPixel(x, y);

                    int r = CombineBits(pixelHost.R, pixelSrc.R);
                    int g = CombineBits(pixelHost.G, pixelSrc.G);
                    int b = CombineBits(pixelHost.B, pixelSrc.B);

                    // Set new color for this pixel
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return bmp;
        }

        /// <summary>
        /// Check if the width and height of the source image isn't greater than host image.
        /// </summary>
        private void CheckBeforeExecute()
        {
            if (srcImage.Width > hostImage.Width)
            {
                throw new SourceImageWidthGreaterThanHost();
            }

            if (srcImage.Height > hostImage.Height)
            {
                throw new SourceImageHeightGreaterThanHost();
            }
        }

        /// <summary>
        /// Get the Most Significant Bit depending on shift value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int GetMSB(int value)
        {
            return value >> shift;
        }

        private int To8Bits(int value)
        {
            return value << shift;
        }

        private int CombineBits(int hostValue, int srcValue)
        {
            return To8Bits(GetMSB(hostValue)) + GetMSB(srcValue);
        }
    }
}
