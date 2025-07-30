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

namespace PictureBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnShow_Click(object sender, EventArgs e)
        {
            string imagepath = txtimagePath.Text;
            FileInfo fobj = new FileInfo(imagepath);
            if(fobj.Exists)
            {
                picBoxImage.Image = Image.FromFile(imagepath);
            }
            else
            {
                MessageBox.Show("Image file not found:");
            }

        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            picBoxImage.Image = null;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rbAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void rbCenter_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void rbZoom_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }

}
