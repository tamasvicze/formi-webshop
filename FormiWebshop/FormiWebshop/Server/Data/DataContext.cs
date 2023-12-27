using Stripe;
using Address = FormiWebshop.Shared.Address;
using Product = FormiWebshop.Shared.Product;

namespace FormiWebshop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "9 x 13 cm" },
                new ProductType { Id = 2, Name = "10 x 15 cm" },
                new ProductType { Id = 3, Name = "30 x 40 cm" },
                new ProductType { Id = 4, Name = "5 x 10 dkg" },
                new ProductType { Id = 5, Name = "5 x 5 dkg" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Pictures",
                    Url = "pictures"
                },
                new Category
                {
                    Id = 2,
                    Name = "Modeling clay",
                    Url = "modeling-clay"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Mária a kisdeddel",
                    Description = "Mária a kisdeddel leírás",
                    ImageUrl = "",
                    Featured = true
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Életfa",
                    Description = "Életfa leírás",
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "A szerencse lovai",
                    Description = "A szerencse lovai leírás",
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Harcsa",
                    Description = "Harcsa leírás",
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 1,
                    Title = "Margaréta",
                    Description = "Margaréta leírás",
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 1. szín",
                    Description = "Dobozos gyurma 1. szín leírás",
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 2. szín",
                    Description = "Dobozos gyurma 2. szín leírás",
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 3. szín",
                    Description = "Dobozos gyurma 3. szín leírás",
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 4. szín",
                    Description = "Dobozos gyurma 4. szín leírás",
                    ImageUrl = "",
                }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 900.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 2000.00m,
                    OriginalPrice = 2500.00m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 6000.00m,
                    OriginalPrice = 7500.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 1,
                    Price = 900.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 2000.00m,
                    OriginalPrice = 2500.00m
                }, new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 6000.00m,
                    OriginalPrice = 7500.00m
                }, new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 1,
                    Price = 900.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 2000.00m,
                    OriginalPrice = 2500.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 3,
                    Price = 6000.00m,
                    OriginalPrice = 7500.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 1,
                    Price = 900.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 2,
                    Price = 2000.00m,
                    OriginalPrice = 2500.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 3,
                    Price = 6000.00m,
                    OriginalPrice = 7500.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 1,
                    Price = 900.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 2000.00m,
                    OriginalPrice = 2500.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 3,
                    Price = 6000.00m,
                    OriginalPrice = 7500.00m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 4,
                    Price = 1000.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 900.00m,
                    OriginalPrice = 1000.00m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 4,
                    Price = 1000.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 5,
                    Price = 900.00m,
                    OriginalPrice = 1000.00m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 4,
                    Price = 1000.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 5,
                    Price = 900.00m,
                    OriginalPrice = 1000.00m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 4,
                    Price = 1000.00m,
                    OriginalPrice = 1200.00m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 5,
                    Price = 900.00m,
                    OriginalPrice = 1000.00m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}