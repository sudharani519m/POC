﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstcourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedCourse.Text = Convert.ToString(lstcourses.SelectedItem);
            lblSelectedCourseIndex.Text = Convert.ToString(lstcourses.SelectedIndex);
        }
    }
}
