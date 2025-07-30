using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array : collection of similar data types 

            int[] numbers = new int[6] { 10, 20, 30, 40, 50, 60 };

            //Modification to the array collection is allowed 
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);

            }

            //Modification to the array collection is not allowed 
            foreach (int i in numbers)
            {
                //i = i * 2;   // error
                Console.WriteLine(i);
            }

            Parallel.ForEach(numbers, x => Console.WriteLine(x));

            Console.Read();
        }
    }
}
