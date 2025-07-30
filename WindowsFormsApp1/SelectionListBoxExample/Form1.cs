using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNewCity.Text !="")
            {
                lstCities.Items.Add(txtNewCity.Text);
                txtNewCity.Clear();
            }
            else
            {
                MessageBox.Show("enter new city Name");
                txtNewCity.Focus();
            }
        }

        private void btnRemoveCity_Click(object sender, EventArgs e)
        {
            if(lstCities.SelectedIndex >= 0)
                lstCities.Items.RemoveAt(lstCities.SelectedIndex);
            else
                MessageBox.Show("Select any city");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstCities.Items.Clear();
            MessageBox.Show("All Cities cleared");
        }

        private void btnShowCount_Click(object sender, EventArgs e)
        {
            int count = lstCities.Items.Count;
            MessageBox.Show(count + "cities found");
        }
    }
}
