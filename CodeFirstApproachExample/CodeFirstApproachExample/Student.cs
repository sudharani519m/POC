using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachExample
{
    public  class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string Email { get; set; }

        public int marks { get; set; }
    }
}
