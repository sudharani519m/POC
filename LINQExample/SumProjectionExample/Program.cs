using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumProjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cherry", "apple", "blueberry" };

          //  int  totalchars = words.Sum(w => w.Length);
            double totalchars = words.Sum(w => w.Length);




            Console.WriteLine($"There are a total of {totalchars} characters in these words.");
            Console.ReadLine();
        }

    }
}
