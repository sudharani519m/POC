using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedAcessExample
{
    internal class student
    {
        protected string name = "sudha";
        }

       // class program
        class Program : student
    {
        static void Main(string[] args)
        {
            //student student1 = new student();
            Program program = new Program();
            //Console.WriteLine("Name:" + student1.name);
            Console.WriteLine("Name:" + program.name);
            Console.ReadLine();
        }
    }
}
