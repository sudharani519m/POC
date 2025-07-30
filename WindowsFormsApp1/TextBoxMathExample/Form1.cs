using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxMathExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirstValue.Text);
            int b = Convert.ToInt32(txtSecondValue.Text);
            int c = a + b;
            txtResult.Text = Convert.ToString(c);

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirstValue.Text);
            int b = Convert.ToInt32(txtSecondValue.Text);
            int c = a - b;
            txtResult.Text = Convert.ToString(c);

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirstValue.Text);
            int b = Convert.ToInt32(txtSecondValue.Text);
            int c = a * b;
            txtResult.Text = Convert.ToString(c);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirstValue.Text);
            int b = Convert.ToInt32(txtSecondValue.Text);
            int c = a / b;
            txtResult.Text = Convert.ToString(c);
        }
    }
}
