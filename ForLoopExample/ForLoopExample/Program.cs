using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
           int n = int.Parse(Console.ReadLine());

            for(int i=0; i<=n; i++)
            {
                Console.Write("i = " + i + " ");
            }
            Console.WriteLine();
            for (int j = 0; j <= n; j++)
            {
                Console.Write("j = " + j + " ");
            }

            Console.ReadLine();

        }
    }
}
