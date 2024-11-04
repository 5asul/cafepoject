using System.ComponentModel.DataAnnotations;

namespace cafepoject.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        public List<Order>? Orders { get; set; } = new List<Order>();
    }
}
