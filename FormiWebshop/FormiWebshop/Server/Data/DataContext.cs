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
                    Description = "A \"Mária a kisdeddel\" kép egy hagyományos keresztény ábrázolás, mely Máriát, Jézus Krisztus anyját mutatja, ahogy gyermekét, a kisded Jézust tartja. Ez a téma rendkívül népszerű a keresztény művészetben, különösen a középkorban és a reneszánsz korban.",
                    ImageUrl = "https://scontent.fosl3-1.fna.fbcdn.net/v/t1.18169-9/1926658_523142377794916_1845919539_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=4dc865&_nc_ohc=MhX_FG2GyskAX-XuLIN&_nc_ht=scontent.fosl3-1.fna&oh=00_AfDnqRsn_zr273ywekZ7VCxSCnilnHClcM9R5eFAEXUopQ&oe=65DBB0DD",
                    Featured = true
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Életfa",
                    Description = "Az \"Életfa\" című kép egy mélyen szimbolikus alkotás, amely az élet, a növekedés, és a természet örök ciklusát ábrázolja. Gyakran előfordul különböző kultúrák mítoszaiban és hiedelmeiben, az életfa a kapcsolatot szimbolizálja az ég és a föld között, gyökereivel a földbe mélyedve és ágaival az ég felé törve.",
                    ImageUrl = "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/1965663_523143624461458_1276340583_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=DyWTtiRlcl0AX8Nxzcu&_nc_ht=scontent.fosl3-1.fna&oh=00_AfAm6Aet5DjhthAUqdBv0qcNv5L8exN-bV7KvM1xuAVUQw&oe=65DB92E9",
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "A szerencse lovai",
                    Description = "A \"Szerencse lovai\" című kép egy dinamikus és élettel teli alkotás, amely a mozgás, erő és szerencse témáit ötvözi. A kompozíció középpontjában álló lovak, amelyeket gyakran vad, szabad szellemű lényekként ábrázolnak, ezen a képen a szerencse és a sors fordulatos útjait szimbolizálják. ",
                    ImageUrl = "https://scontent.fosl3-2.fna.fbcdn.net/v/t1.18169-9/1926668_523142884461532_1016400965_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=4dc865&_nc_ohc=fqFgPIYsG6UAX8qPKJa&_nc_ht=scontent.fosl3-2.fna&oh=00_AfBQwQA9PvCzcpgn3LBeOlzq59Yd4SwUgqUKSa5-BIeZCw&oe=65DB86F7",
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Harcsa",
                    Description = "A \"Harcsa\" című kép egy lenyűgöző vizuális alkotás, amely a víz alatti világ egyik legérdekesebb és legmisztikusabb lakóját, a harcsát állítja középpontba. A harcsa, mint téma, ritkábban fordul elő a művészetben, ami különlegessé és figyelemfelkeltővé teszi ezt a művet. A képen a harcsa általában hatalmas, izmos testével és jellegzetes, bajuszszerű úszóival tűnik ki, amelyek azonnal felismerhetővé teszik ezt a vízi ragadozót.",
                    ImageUrl = "https://scontent.fosl3-2.fna.fbcdn.net/v/t1.18169-9/1948202_523141641128323_1230882181_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=4dc865&_nc_ohc=ikaauvVmcSsAX_ZBz-n&_nc_ht=scontent.fosl3-2.fna&oh=00_AfC3dputgHv8qhnf9h5kpRvaiPTLhUzbekoU3vpFIa_FVQ&oe=65DB7D68",
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 1,
                    Title = "Margaréta",
                    Description = "A \"Margaréta\" című kép egy bájos és finom alkotás, amely a természet egyik legkedveltebb virágát, a margarétát ünnepli. A margaréta a tisztaság, ártatlanság és valódi szeretet szimbóluma. A képen ábrázolt virágok frissessége és egyszerű szépsége közvetlenül szólítja meg a nézőt, miközben a művész által választott kompozíció és színpaletta a természetes szépség és a harmónia érzetét kelti.",
                    ImageUrl = "https://scontent.fosl3-1.fna.fbcdn.net/v/t1.18169-9/1006045_523139247795229_57350582_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=4dc865&_nc_ohc=Ihbt_rqgbBUAX81bdPb&_nc_ht=scontent.fosl3-1.fna&oh=00_AfDjDqQpqQmHbrDZnaJjCVgfmi8drN6ufEv2EAzFgCI-cg&oe=65DB8E34",
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 1. szín",
                    Description = "Ez a szett egy dinamikus és élénk színkombinációt tartalmaz, beleértve a fehér, sárga, piros, kék és zöld árnyalatokat. A színek sokoldalúsága lehetővé teszi a felhasználók számára, hogy szabadon kísérletezzenek és színes alkotásokat hozzanak létre, legyen szó akár tájképekről, állatfigurákról vagy akár absztrakt művekről.",
                    ImageUrl = "https://scontent.fbud6-4.fna.fbcdn.net/v/t31.18172-8/1966061_523163521126135_466461706_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=m6U10Lds47AAX826HSM&_nc_ht=scontent.fbud6-4.fna&oh=00_AfBVG0DqcTV2lOFeezlbX_pfKYNuiquFosB8W-RUV1Rk0g&oe=65B425FC",
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 2. szín",
                    Description = " Ebben a szettben a fehér mellett a test szín, lila, barna és fekete árnyalatok dominálnak, amelyek tökéletesen alkalmasak emberi alakok és természeti elemek modellezésére. Ez a paletta különösen jól használható a realisztikusabb, részletgazdag alkotásokhoz, amelyek finom árnyalatokkal és átmenetekkel dolgoznak.",
                    ImageUrl = "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/10001106_523163627792791_943319837_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=GTfbWV9OrQUAX_csRP3&_nc_ht=scontent.fosl3-1.fna&oh=00_AfAWSDH-exYdoY24LBJ3A6vWwz2KGqzf9vVsIuHQS3MG4Q&oe=65DBADF1",
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 3. szín",
                    Description = "Fehér, narancs, türkiz, ciklámen és szürke színeket tartalmaz, amelyek egyedi és modern alkotások létrehozására inspirálnak. A friss és élénk színek, mint a türkiz és a ciklámen, mellett a narancs és a szürke árnyalatok kiegyensúlyozott kontrasztot nyújtanak, lehetővé téve a felhasználók számára, hogy élénk és figyelemfelkeltő műveket hozzanak létre.",
                    ImageUrl = "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/1529758_523163694459451_1282257657_o.jpg?_nc_cat=108&ccb=1-7&_nc_sid=4dc865&_nc_ohc=3c8hUGXM3cIAX-Hkmim&_nc_ht=scontent.fosl3-1.fna&oh=00_AfD4xQGGIH_oot7sTWpnjFPMphVBJtjvGo9aM-XLzki5vQ&oe=65DB93A0",
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 2,
                    Title = "Dobozos gyurma 4. szín",
                    Description = "Ez a készlet finomabb, pasztellszínű választékot kínál, beleértve a fehér, világos zöld, meggy piros, világos rózsaszín és világos kék árnyalatokat. A lágy és nyugtató színek ideálisak a békés és harmonikus jelenetek megalkotásához, kiválóan alkalmasak a gyengédebb érzelmek és hangulatok kifejezésére.",
                    ImageUrl = "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/1597214_523163817792772_1796134464_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=mBeu6SLPaloAX_P1Rwx&_nc_oc=AQmdzVaxVEDd6RtMoPtledUgkJ9bGN8v5hRnzcKoGmeUvHmdzfd-It84XqVq2MBnmW0&_nc_ht=scontent.fosl3-1.fna&oh=00_AfAf2KVOdX1aBNlGjtaftkrI4yjQJ4fi_YhcEIBvzzYDFg&oe=65DBB01A",
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