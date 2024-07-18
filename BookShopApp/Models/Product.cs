using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApp.Models
{
    public class Product
    {
        public long? ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a book name")]
        public string Name { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter an author")]
        public string Author { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; } = String.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; } = String.Empty;

        public string ImageUrl { get; set; } = String.Empty;
    }
}
