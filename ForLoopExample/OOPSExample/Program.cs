using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    internal class Program
    {

        int i;  //Declaration 

        int j = 100; // intialization 

        public void CaliculateEMI()  // Group of statemments which executes some logic 
        {
            //logic 
            //100 line code 
        }
        public void SayHello()
        {
            Console.WriteLine("Hi Welocme to Conosle Apps");
        }

        static void Main(string[] args)
        {
            //main method is the enetry point of execution

            Program program = new Program();    // classname objectname = new classname();
            program.SayHello();
            Console.Read();
        }
    }
}
