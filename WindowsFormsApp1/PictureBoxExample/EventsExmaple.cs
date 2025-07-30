using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExample
{
    public partial class EventsExmaple : Form
    {
        public EventsExmaple()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //logic to validate the user input
            // Allow only letters and control keys (e.g., Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
                MessageBox.Show("Please Enter only Alphabets");
            }
        }
    }
}
