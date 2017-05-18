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
    public partial class Steganozor : Form
    {
        private enum IMG
        {
            HOST,
            SRC
        };

        private Steganolizer steganolizer;
        private string saveDestPath;

        public Steganozor()
        {
            InitializeComponent();

            // Config variables
            steganolizer = new Steganolizer();
            saveDestPath = string.Empty;

            // Config components
            openFileDialogImage.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            btnRun.Enabled = false;
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

            EnableApplySteganography();
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

            EnableApplySteganography();
        }

        /// <summary>
        /// Apply steganography
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Select save destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogDst.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (saveFileDialogDst.FileName != string.Empty)
                {
                    saveDestPath = saveFileDialogDst.FileName;
                }
            }
        }

        /// <summary>
        /// Display a file dialog to get image.
        /// </summary>
        /// <param name="type"></param>
        private void DisplaySelectImage(IMG type)
        {
            DialogResult dialogResult = openFileDialogImage.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    if (type.Equals(IMG.HOST))
                    {

                        steganolizer.HostImage = Image.FromFile(openFileDialogImage.FileName);

                    } else
                    {

                        steganolizer.SrcImage = Image.FromFile(openFileDialogImage.FileName);

                    }
                } catch (Exception ex) {

                    MessageBox.Show("An error occured. Can not get image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void EnableApplySteganography()
        {
            if (steganolizer.AreImagesReady() && saveDestPath != string.Empty)
            {
                btnRun.Enabled = true;
            }
        }

    }
}
