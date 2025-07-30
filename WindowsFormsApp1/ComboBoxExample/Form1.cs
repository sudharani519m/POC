using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedIndex == 0)
            
                txtFee.Text = "Rs.3,500/-";
                else if (cmbCourse.SelectedIndex == 2)
                    txtFee.Text = "Rs.6,200/-";
                else if (cmbCourse.SelectedIndex == 3)
                    txtFee.Text = "Rs. 1,200/-";
                else if (cmbCourse.SelectedIndex == 4)
                    txtFee.Text = "Rs. 1,500/-";
             
        }
                
    }
}
