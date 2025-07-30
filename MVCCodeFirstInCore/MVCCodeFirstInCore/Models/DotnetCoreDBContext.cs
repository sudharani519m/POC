using Microsoft.EntityFrameworkCore;

namespace MVCCodeFirstInCore.Models
{
    public class DotnetCoreDBContext:DbContext
    {
        public DotnetCoreDBContext(DbContextOptions<DotnetCoreDBContext>options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public  DbSet<Product> Products { get; set; }


    }
}
