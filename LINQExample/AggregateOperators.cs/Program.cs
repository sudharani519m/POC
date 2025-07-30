using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateOperators.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] factorsof300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsof300.Distinct().Count();
            Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
            Console.ReadLine();

        }
        //Console.ReadLine();
    }
}
