using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab8_Part2_MVC.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base()
        {
        }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ProductShopDB_ITP;Integrated Security=true;TrustServerCertificate=true;");
            }
            
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}