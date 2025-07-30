using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonExamples
{
    public partial class Progressbar : Form
    {
        public Progressbar()
        {
            InitializeComponent();
        }
        private void OpenFile()
        {
            string filename = txtFileName.Text;
            FileInfo fobj = new FileInfo(filename);
            if (fobj.Exists)
            {
                StreamReader sr = new StreamReader(filename);
                string content = sr.ReadToEnd();
                txtFileName.Text = content;
                sr.Close();
            }
            else
                MessageBox.Show("File not found");

        }

        private void txtopen_Click(object sender, EventArgs e)
        {
           
            prgFile.Value = 0;
            tmrFileOpen.Enabled = true;
               lblLoading.Visible = true;
             prgFile.Visible = true;
             

        }

        private void tmrFileOpen_Tick(object sender, EventArgs e)
        {
            prgFile.Value++;
             if (prgFile.Value == 100)
            {
              tmrFileOpen.Enabled = false;
              lblLoading.Visible = false;
             prgFile.Visible = false;
              OpenFile();
        }
    }
    }
}

