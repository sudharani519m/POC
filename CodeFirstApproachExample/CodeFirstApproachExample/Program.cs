using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentContext db = new StudentContext();
            var StudentList = db.Students.ToList();

            //Student obj = new Student()
            //{
            //    StudentName = "sarah" ,
            //    Email="sarah@gmail.com" ,
            //    marks=99
            //};
            //db.Students.Add(obj);
            //db.SaveChanges();

           //var Student = db.Students.FirstOrDefault(x => x.StudentName == "sarah");
           // if (Student != null)
           // {
           //     Student.marks = 100;
           //     Student.Email = "sarahupdated@gmail.com";
           //     db.SaveChanges();
           // }
           // else
           // {
           //     Console.WriteLine("student not found");
           // }



                Console.Read();
        }
        }
    }
    
