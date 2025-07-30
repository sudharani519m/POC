using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDbFirstApproch.Models
{
    public class Dept
    {
        [Key]
        public int DeptID { get; set; }

        [Required]
        public string DeptName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Depthead { get; set; }
    }
}