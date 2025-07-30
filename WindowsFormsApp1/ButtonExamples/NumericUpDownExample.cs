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
    public partial class NumericUpDownExample : Form
    {
        public NumericUpDownExample()
        {
            InitializeComponent();
        }

         private void ChangeFont()
        {
            string font =Convert.ToString(domFont.SelectedItem);
            int size = Convert.ToInt32(numSize.Value);
            txtMyText.Font = new Font(font, size);
        }

        private void domFont_SelectedItemChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}
