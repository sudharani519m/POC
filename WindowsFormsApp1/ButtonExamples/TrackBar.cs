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
    public partial class TrackBar : Form
    {
        public TrackBar()
        {
            InitializeComponent();
        }

        private void trkFontSize_Scroll(object sender, EventArgs e)
        {
            int n = trkFontSize.Value;
            lblMyText.Font = new Font("Tahoma", n);
        }
    }
}
