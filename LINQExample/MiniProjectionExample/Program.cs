 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace MiniProjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestword = words.Min(w => w.Length);

            Console.WriteLine($"The shortest word is {shortestword} characterd long.");
            Console.ReadLine();
        }
    }
}
