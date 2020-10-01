using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Data.Entities;

namespace ProductsApi.Data.Models
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=TestDb.db");
    }
}