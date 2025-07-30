using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonExamples
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
        }

        private void btnGetMyAge_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            DateTime dob = dtpDOB.Value;
            DateTime today = DateTime.Today;

            int years = today.Year - dob.Year;
            int months = today.Month - dob.Month;
            int days = today.Day - dob.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(today.Year, (today.Month == 1) ? 12 : today.Month - 1);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            lblResult.Text = $"Age: {years} Years, {months} Months, {days} Days";


        }
    }

}
