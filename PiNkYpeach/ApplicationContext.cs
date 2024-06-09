using Microsoft.EntityFrameworkCore;
using PiNkYpeach.Data.Entities;

namespace PiNkYpeach.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }  
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User


            

            //Products
            //Yarn Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Scarf",
                Description = "Knitted scarf with gothic pattern",
                ImageURL = "/Downloads/Zim.jpg",
                Price = 300,
                Qty = 2,
                CategoryId = 1

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Yarn"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
