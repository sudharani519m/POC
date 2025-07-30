using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MydbConn")
        {
            //Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
            //Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
