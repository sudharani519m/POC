using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonExamples
{
    public partial class ButtonImage : Form
    {
        public ButtonImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("C:\\Users\\Mahender\\Pictures\\lotus-978659_1920-e1465583193321.webp");
            this.BackgroundImage = Image.FromFile("C:\\Users\\Mahender\\Pictures\\123.png");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnClearBackgroundImage_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }
    }
}
