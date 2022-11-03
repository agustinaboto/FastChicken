using FastChicken.Models;
using Microsoft.EntityFrameworkCore;

namespace FastChicken.Data
{
    public class FastChickenContext : DbContext
    {
        public FastChickenContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Combo> Combos { get; set; }

        public DbSet<Product> Products { get; set; } 

    }
}
