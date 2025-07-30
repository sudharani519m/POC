using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemoApplication.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpAddress { get; set; }
    }
}