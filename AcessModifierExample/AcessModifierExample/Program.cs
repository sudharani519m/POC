using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifierExample
{
    class student
    {
       // public string name = "sudha";
        private string name = "sudha";


       // public void print()
            private void print()
        {
        Console.WriteLine("Hello from student class");
            }
}
class program
{


    static void Main(string[] args)
    {
        student student1 = new student();

       // student1.print();
        Console.WriteLine("Name:" + student1.name);
            student1.print();
            Console.ReadLine();

        }
   
}
    }

