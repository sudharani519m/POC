using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachExample
{
    public class StudentContext : DbContext
    {
       public StudentContext() :base("name=DbConn")
      {

      }

      public DbSet<Student> Students { get; set; }
    }

   
}
