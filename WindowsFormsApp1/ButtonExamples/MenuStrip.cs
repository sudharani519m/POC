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
    public partial class ToolStripMenuItem : Form
    {
        public ToolStripMenuItem()
        {
            InitializeComponent();
        }

        

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Mahender\\Pictures\\123.png");
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }
    }
}
