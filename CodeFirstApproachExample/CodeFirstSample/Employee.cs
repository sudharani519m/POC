﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample
{
    public class Employee
    {
        public Employee()
        {

        }
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
