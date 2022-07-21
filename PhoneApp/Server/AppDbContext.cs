using Microsoft.EntityFrameworkCore;
using PhoneApp.Shared;

namespace PhoneApp.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "128GB" },
                    new ProductType { Id = 2, Name = "512GB" },
                    new ProductType { Id = 3, Name = "1024GB" },
                    new ProductType { Id = 4, Name = "Devices" },
                    new ProductType { Id = 5, Name = "Accesories" }

                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Phones",
                    Url = "phones"
                },
                new Category
                {
                    Id = 2,
                    Name = "Devices",
                    Url = "devices"
                },
                new Category
                {
                    Id = 3,
                    Name = "Accesories",
                    Url = "accesories"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Apple iPhone 13 Pro Max Graphite",
                        Description = "Zachwycający płynnością i responsywnością wyświetlacz Super Retina XDR z technologią ProMotion. Potężne udoskonalenia systemu aparatów dające spektakularne nowe możliwości. Bezkonkurencyjna trwałość. Ultraszybki czip A15 Bionic. I przełomowa wydajność baterii. Oto propozycja.",
                        ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/7/pr_2022_7_8_9_15_52_561_00.jpg",
                        CategoryId = 1,
                        Recommended = true
                    },
                       new Product
                       {
                           Id = 2,
                           Title = "OnePlus 9 5G Astral Black 120Hz",
                           Description = "Daj się ponieść z nowym smartfonem OnePlus 9 5G 8/128 GB Astral Black. Smukła konstrukcja, świetne podzespoły, przestronny, olśniewający ekran i oszałamiająca wydajność to klucz do sukcesu. A do tego system aparatów, które jakością zdjęć są w stanie przyćmić niejednego konkurenta. OnePlus 9 5G to zdecydowanie smartfon, który dotrzyma Ci kroku każdego dnia.",
                           ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/11/pr_2021_11_26_15_21_10_123_02.jpg",
                           CategoryId = 1,
                           Recommended = true
                       },
                         new Product
                         {
                             Id = 3,
                             Title = "Samsung Galaxy S21 FE 5G Fan Edition Grey",
                             Description = "Popatrz jak wygląda nowy Samsung Galaxy S21 FE 128 GB 5G Fan Edition szary, Jego konstrukcja nawiązuje do rodziny S21. Obudowa jest elegancka, a zarazem minimalistyczna. Dzięki temu jest po prostu piękna. W jej konstrukcji znalazło się miejsce na trzy aparaty, które zagwarantują doskonałe ujęcia. Potem możesz je wyświetlić na ekran o wielkości 6,4 cala. Ma on rozdzielczość Full HD+, więc każde treści już stale będą pełne detali i szczegółów. To wszystko dopełnia procesor z ośmioma rdzeniami. Jest to Snapdragon 888. Korzystaj o resztę zadba S21 FE 5G Fan Edition.",
                             ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_23_8_39_30_82_01.jpg",
                             CategoryId = 1,
                             Recommended = true
                         },

                       new Product
                       {
                           Id = 4,
                           Title = "Apple iPad Pro 12,9\" M1 Wi - Fi Space Gray",
                           Description = "Turbodopalany czipem Apple M1.Najdoskonalszy iPad.Czip M1 wynosi go na nowy poziom wydajności, wyświetlacz Liquid Retina XDR olśniewa jakością obrazu, a interfejs bezprzewodowy 5G śmiga z zawrotną prędkością◊. Zapnij pasy.",
                           ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/4/pr_2021_4_20_21_38_10_357_00.jpg",
                           CategoryId = 2,
                           Recommended = true
                       },
                        new Product
                        {
                            Id = 5,
                            Title = "Silver Monkey Kabel USB 3.0 - USB-C 1,2m",
                            Description = "Postaw na szybkość i wybierz kabel Silver Monkey z symetrycznym wtykiem USB-C i portem USB 3.0. jest kompatybilny z każdym urządzeniem posiadającym port USB-C, jak i złącze w Thunderbolt, obecny w komputerach Apple. Z jego pomocą błyskawicznie prześlesz dane albo naładujesz urządzenie mobilne. Co więcej, dzięki długości 1,2 metra kabel bez trudu mieści się w torbie, plecaku, damskiej torebce, a nawet w kieszeni kurtki.",
                            ImageUrl = "https://allegro.stati.pl/AllegroIMG/PRODUCENCI/Silver-Monkey/Kabel-Type-C-USB-3.0/1%2C2m/kabel_type-C_1-2m_2m_zlacza.jpg?",
                            CategoryId = 3,
                            Recommended = false
                        }
                        );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 5699m,
                    OriginalPrice = 5699m
                },
                  new ProductVariant
                  {
                      ProductId = 1,
                      ProductTypeId = 2,
                      Price = 7199m,
                      OriginalPrice = 7199m
                  },
                    new ProductVariant
                    {
                        ProductId = 1,
                        ProductTypeId = 3,
                        Price = 7599m,
                        OriginalPrice = 8199m
                    },

                     new ProductVariant
                     {
                         ProductId = 2,
                         ProductTypeId = 1,
                         Price = 3349m,
                         OriginalPrice = 3349m
                     },
                  new ProductVariant
                  {
                      ProductId = 2,
                      ProductTypeId = 2,
                      Price = 5599m,
                      OriginalPrice = 5599m
                  },
                    new ProductVariant
                    {
                        ProductId = 2,
                        ProductTypeId = 3,
                        Price = 5999m,
                        OriginalPrice = 6499m
                    },

                     new ProductVariant
                     {
                         ProductId = 3,
                         ProductTypeId = 1,
                         Price = 3499m,
                         OriginalPrice = 3499m
                     },
                  new ProductVariant
                  {
                      ProductId = 3,
                      ProductTypeId = 2,
                      Price = 5999m,
                      OriginalPrice = 5999m
                  },
                    new ProductVariant
                    {
                        ProductId = 3,
                        ProductTypeId = 3,
                        Price = 6499m,
                        OriginalPrice = 6999m
                    },

                    new ProductVariant
                    {
                        ProductId = 4,
                        ProductTypeId = 4,
                        Price = 8199m,
                        OriginalPrice = 8699m
                    },

                    new ProductVariant
                    {
                        ProductId = 5,
                        ProductTypeId = 5,
                        Price = 24.99m,
                        OriginalPrice = 24.99m
                    }
                    );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }


    }

}
