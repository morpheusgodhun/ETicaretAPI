using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Contexts {
    public class ETicaretAPIDbContext : DbContext {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options) { }

        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Customer> Customers { get; set; }
    }
}