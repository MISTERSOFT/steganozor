using steganography.Exceptions;
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

        private static string DEFAULT_SAVE_FILENAME = "stegano";

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
            try
            {
                Bitmap result = steganolizer.Execute();

                string filename = (!string.IsNullOrEmpty(tbFilename.Text)) ? tbFilename.Text : DEFAULT_SAVE_FILENAME;
                result.Save(saveDestPath + "\\" + filename + ".jpg");

                Alerter.Info("Work done !" + Environment.NewLine + "Image saved at : " + saveDestPath, "Info");
            }
            catch (SourceImageWidthGreaterThanHost ex)
            {
                Alerter.Error(ex.Message, "Info");
            }
            catch (SourceImageHeightGreaterThanHost ex)
            {
                Alerter.Error(ex.Message, "Info");
            }
        }

        /// <summary>
        /// Select save destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogDst.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (folderBrowserDialogDst.SelectedPath != string.Empty)
                {
                    saveDestPath = folderBrowserDialogDst.SelectedPath;

                    tbSaveDst.Text = saveDestPath;
                }
            }

            EnableApplySteganography();
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

                        steganolizer.HostImage = Image.FromFile(openFileDialogImage.FileName) as Bitmap;
                        tbHost.Text = openFileDialogImage.FileName;

                    } else
                    {

                        steganolizer.SrcImage = Image.FromFile(openFileDialogImage.FileName) as Bitmap;
                        tbSrc.Text = openFileDialogImage.FileName;

                    }
                } catch (Exception ex) {

                    Alerter.Error("An error occured. Can not get image.", "Error");

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
