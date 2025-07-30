using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ButtonExamples
{
    public partial class GetHobbies : Form
    {
        public GetHobbies()
        {
            InitializeComponent();
        }

        private void btnGetHobbies_Click(object sender, EventArgs e)
        {

            int chkCount = 0;
            string selectedHobbies = "";
            List<string> mystringList = new List<string>();

            lblPopup.Text = " ";
            if (chkHockey.Checked == true)
            {
                chkCount++;
                selectedHobbies += chkHockey.Text;
                mystringList.Add(chkHockey.Text);
            }
            if (chkCricket.Checked == true)
            {
                chkCount++;
                selectedHobbies += chkCricket.Text;
                mystringList.Add(chkCricket.Text);
            }
            if (chkDriving.Checked == true)
            {
                chkCount++;
                selectedHobbies += chkDriving.Text;
                mystringList.Add(chkDriving.Text);
            }
            if (chkDancing.Checked == true)
            {
                chkCount++;
                selectedHobbies += chkDancing.Text;
                mystringList.Add(chkDancing.Text);
            }
            if (chkMovies.Checked == true)
            {
                chkCount++;
                selectedHobbies += chkMovies.Text;
                mystringList.Add(chkMovies.Text);
            }
            if (chkCount == 0)
            {

                MessageBox.Show("please select atleast one");

            }
            else
            {
                lblPopup.Text = string.Join(",", mystringList);
                MessageBox.Show(string.Join(",", mystringList));

            }

        }

    }
}
