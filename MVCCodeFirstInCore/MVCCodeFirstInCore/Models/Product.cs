using System.ComponentModel.DataAnnotations;

namespace MVCCodeFirstInCore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

    }
}
