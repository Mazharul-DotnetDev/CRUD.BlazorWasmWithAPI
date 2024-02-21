using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BlazorAppWASM.Models
{
    public class ProductCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryID { get; set; }

        [Required, NotNull]

        [StringLength(50, MinimumLength = 4)]
        public string Name { get; set; }

        //public string? ImagePath { get; set; }
        //public IBrowserFile? ImageFile { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
