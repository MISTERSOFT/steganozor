using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steganography
{
    public class Steganolizer
    {
        private Image hostImage;
        private Image srcImage;

        public Steganolizer() { }

        public Image HostImage
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

        public Image SrcImage
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

        /// <summary>
        /// Check if host and source images are not null
        /// </summary>
        /// <returns></returns>
        public bool AreImagesReady()
        {
            return hostImage != null && srcImage != null;
        }

        public Image Execute()
        {
            if (srcImage.Width > hostImage.Width)
            {
                // Throw exception
            }

            if (srcImage.Height > hostImage.Height)
            {
                // Throw exception
            }

            return hostImage;
        }
    }
}
