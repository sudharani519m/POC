using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeResusability
{
    internal class Program
    {
        public void GetSimpleInterest()
        {
            int p = 1000000;
            int r = 3;
            int t = 2;
            int si = p * t * r;
            Console.WriteLine("simple interest:" + si);
        }



        class program2 : Program 
        {
            static void Main(string[] args)
            {
                Program program = new Program();
                program.GetSimpleInterest();
                Console.Read();

                Program program2 = new program2();
                program2.GetSimpleInterest();
                Console.Read();
            }
        }
    }
}
