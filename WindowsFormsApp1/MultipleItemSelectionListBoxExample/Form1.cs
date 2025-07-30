using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleItemSelectionListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int i;
            lstSelectedBooks.Items.Clear();
            for (i = 0; i < lstAvailableBooks.SelectedItems.Count; i++)
                lstSelectedBooks.Items.Add(lstAvailableBooks.SelectedItems[i]);
        }
    }
}
