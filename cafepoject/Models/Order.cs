using System.ComponentModel.DataAnnotations;

namespace cafepoject.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Order Date is required")]
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }

    }
}

