using System.ComponentModel.DataAnnotations;

namespace MVCCodeFirstInCore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Studentname { get; set; }

        public int Marks { get; set; }

        public string ClassTeacher {  get; set; }

        public int TotalPercentage {  get; set; }
    }
}
