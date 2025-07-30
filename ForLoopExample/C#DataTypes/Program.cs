using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100; // value Type 
            string name = "dasharad";
            object y = x;  // Reference type   ==>Boxing 

            int? z = null;

            Console.WriteLine("Hi Welcome to c#" + x);
            Console.WriteLine($"Hi Welcome to c# {name} ");
        }
    }
}
