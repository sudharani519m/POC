using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.BackColor = Color.Yellow;
            lblMessage.ForeColor = Color.Green;

        }
        private void lblMessage_MouseEnter(object sender, EventArgs e)
        {
            lblMessage.BackColor = Color.Green;
            lblMessage.ForeColor = Color.Yellow;
        }
        private void lblMessage_MouseLeave(object sender, EventArgs e)
        {
            lblMessage.BackColor = Color.Yellow;
            lblMessage.ForeColor = Color.Green;
        }

       
    }
}
