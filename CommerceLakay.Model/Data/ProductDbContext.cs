using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceLakay.Model.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id=1, Name="Shirt", Category="Outfits", Price=40, Quantity=20, Description="Formal outfit for Men" });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id=2, Name="Pant", Category="Outfits", Price=50, Quantity=100, Description="Formal pant for dress up occasion" });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id=3, Name="Shoes", Category="Footwear", Price=120, Quantity=50, Description="Nice Fancy shoes for any style" });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id=4, Name="Polo", Category="Summer", Price=20, Quantity=500, Description="Summer outfit for youngster" });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProductModel> Products { get; set; }

    }
}
