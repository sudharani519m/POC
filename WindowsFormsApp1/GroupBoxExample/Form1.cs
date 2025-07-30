using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            txtMyTextBox.BackColor = Color.White;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            txtMyTextBox.BackColor = Color.Red;
        }

        private void rbYellow_CheckedChanged(object sender, EventArgs e)
        {
            txtMyTextBox.BackColor = Color.Yellow;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtMyTextBox.ForeColor = Color.Blue;
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtMyTextBox.ForeColor = Color.Green;
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            txtMyTextBox.ForeColor = Color.Orange;
        }
    }
}
