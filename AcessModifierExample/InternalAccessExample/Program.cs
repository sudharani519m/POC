using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
     class student
    {
        internal string name = "sudha";
        }
        class program
    {   
static void Main(string[] args)
        {
            student thestudent = new student();
            Console.WriteLine("Name:" + thestudent.name);
            Console.ReadLine();
        }
    }
}
