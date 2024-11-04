using System.ComponentModel.DataAnnotations;

namespace cafepoject.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [MaxLength(100, ErrorMessage = "Product name cannot exceed 100 characters")]
        public string? ProductName { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive amount")]
        public double Price { get; set; }

        public List<Order>? Orders { get; set; } = new List<Order>();
    }
}
