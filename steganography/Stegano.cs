using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steganography
{
    public partial class Stegano : Form
    {
        private Image hostImage;
        private Image srcImage;
        private enum IMG
        {
            HOST,
            SRC
        };

        public Stegano()
        {
            InitializeComponent();
            openFileDialogImage.Filter = "*.png|*.jpeg|*.jpg|*.bmp|*.gif";
        }

        /// <summary>
        /// Select host image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHost_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Title = "Select the host image";

            DisplaySelectImage(IMG.HOST);
        }

        /// <summary>
        /// Select source image. This is the image that will be hidden into the host image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSrc_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Title = "Select the image to hide";

            DisplaySelectImage(IMG.SRC);
        }

        /// <summary>
        /// Apply steganography
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        private void DisplaySelectImage(IMG type)
        {
            DialogResult dialogResult = openFileDialogImage.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    if (type.Equals(IMG.HOST))
                    {
                        hostImage = Image.FromFile(openFileDialogImage.FileName);
                    } else
                    {
                        srcImage = Image.FromFile(openFileDialogImage.FileName);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("An error occured. Can not get image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
