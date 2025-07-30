using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonExamples
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            //Application.Run(new ButtonImage());
            // Application.Run(new AgeCalculator());
            // Application.Run(new GetHobbies());
            // Application.Run(new Validations());
            //Application.Run(new NumericUpDownExample());

             Application.Run(new EmployeeAddress());
            //Application.Run(new TrackBar());
            //Application.Run(new Timer1());
            // Application.Run(new Timer3());
           // Application.Run(new Progressbar());
          // Application.Run(new ToolStripMenuItem());

        }
    }
}
