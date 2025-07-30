using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonExamples
{
    public partial class Validations : Form
    {
        public Validations()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && ! char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

       

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            string mobile = textBox2.Text;
            if (!(mobile.StartsWith("7") || mobile.StartsWith("8") || mobile.StartsWith("9")))
            {
                MessageBox.Show("please enter a valid 10 digit mobile number starting with 7,8,9", "Invalid Mobile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            if (mobile.Length > 10)
            {
                MessageBox.Show("please enter the 10 digits only");
            }
           
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            string email = textBox3.Text.Trim();
            if(email.Contains("@") && email.Contains(".") && email.EndsWith(".com"))
            {
                MessageBox.Show("Email is valid");
            }
            else
            {
                MessageBox.Show("Invalid email.please enter a valid email adress.");
               // textBox3.Focus();
            }
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            string url = textBox4.Text.Trim();
            if (url.StartsWith("http://") || url.StartsWith("https://"))
            {
                url = "https://" + url;
            }
            else
            {
                MessageBox.Show("Invalid url.please enter a valid url");
            }
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            string address = textBox5.Text.Trim();

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is required.");
            }
        }
    }
}
