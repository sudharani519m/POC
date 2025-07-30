using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cherry", "apple", "blueberry" };

           int longestLength = words.Max(w => w.Length);

            Console.WriteLine($"The longest word is {longestLength} characters long.");
            Console.ReadLine();
        }
    }
}
