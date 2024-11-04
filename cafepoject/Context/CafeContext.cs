using Microsoft.EntityFrameworkCore;
using cafepoject.Models;

namespace cafepoject.Context
{
    public class CafeContext: DbContext
    {
        public CafeContext(DbContextOptions<CafeContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
