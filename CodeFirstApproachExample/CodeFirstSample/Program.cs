using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
           Employee employee = new Employee() { EmpId = 1, Name = "Shiju", Address = "Cochin" };
          context.Employees.Add(employee);
          context.SaveChanges();
        }
    }
}
