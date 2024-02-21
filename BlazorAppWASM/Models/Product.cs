using System.ComponentModel.DataAnnotations;

namespace BlazorAppWASM.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string ProductNumber { get; set; }

        public string Color { get; set; }

        [Required]
        public decimal StandardCost { get; set; }

        [Required]
        public decimal ListPrice { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public decimal Weight { get; set; }

        public int ProductCategoryID { get; set; }

        public ProductCategory? ProductCategory { get; set; }
    }
}
