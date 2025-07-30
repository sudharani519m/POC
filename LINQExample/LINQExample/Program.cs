using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 7, 9, 11, 13, 14 };

            double result = numbers.Average();
            Console.WriteLine("Average is " + result);
            Console.ReadLine();
        }
    }
}
