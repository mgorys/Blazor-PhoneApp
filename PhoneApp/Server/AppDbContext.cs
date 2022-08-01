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
               },
               new Product
               {
                   Id = 6,
                   Title = "Microsoft 1850 Wireless Mobile Mouse",
                   Description = "Mysz Wireless Mobile Mouse 1850 zaprojektowano do mobilnego trybu życia — zapewnia bezprzewodową swobodę oraz komfort dla Twojej dłoni. Możliwość obsługi w lewej i prawej dłoni oraz kółko przewijania ułatwiające poruszanie się sprawiają, że ta mysz jest idealnym urządzeniem dostosowanym do nowoczesnego, mobilnego trybu życia.",
                   ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/4/pr_2022_4_8_13_17_41_779_00.jpg",
                   CategoryId = 3,
                   Recommended = false
               },
               new Product
               {
                   Id = 7,
                   Title = "NuPhy Air75 Red, Gateron",
                   Description = "NuPhy Air75 Red to wyjątkowa klawiatura pod względem prostoty, jak i wygody użytkowania. Zapewnij sobie odpowiedni komfort pracy w biurze lub w domowym zaciszu. Kompaktowa konstrukcja w formacie 75% świetnie wpasuje się w przestrzeń na Twoim biurku. Zadbaj o odpowiednią ergonomię podczas spędzania długich godzin przed komputerem. Wybierz NuPhy Air75 Red i zwiększ swoją produktywność.",
                   ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/7/pr_2022_7_14_6_49_22_600_00.jpg",
                   CategoryId = 3,
                   Recommended = false
               },
               new Product
               {
                   Id = 8,
                   Title = "Xiaomi Pad 5 6/128GB Cosmic Gray 120Hz",
                   Description = "Wykorzystaj możliwości Xiaomi Pad 5 128 GB Cosmic Gray do nauki, pracy lub rozrywki. Bez względu na to, czy jesteś w domu, biurze, czy na świeżym powietrzu – tablet jest zawsze gotowy do pracy. Pad 5 wyposażono w funkcję redukującą emisje szkodliwego światła niebieskiego oraz technologie Sunlight Display i True Display. Dzięki nim możesz bezpiecznie i komfortowo korzystać z urządzenia przez długo. A z baterią o pojemności 8720 mAh jest to jak najbardziej możliwe.",
                   ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_27_12_13_38_693_00.jpg",
                   CategoryId = 2,
                   Recommended = false
               },
               new Product
               {
                   Id = 9,
                   Title = "Samsung Galaxy Tab A8 X200 WiFi 4/64GB srebrny",
                   Description = "Korzystaj z Samsung Galaxy Tab A8 X200 WiFi 64 GB srebrny i nie obawiaj się o brak energii. Tablet ma baterię o pojemności 7040 mAh. Dodatkowo w tej eleganckiej konstrukcji znalazło się miejsce na duży ekran. Jest on o przekątnej 10,5 cala. Dzięki niemu obejrzysz różne treści. Czy to prezentacja na zajęcia, czy kolejny odcinek ulubionego serialu. Całość będzie w naprawdę dobrej jakości. Co ważne z Tab A8 X200 uzyskasz również dobre ujęcia. To przez przedni, lub tylny aparat. Wybierz tylko odpowiedni.",
                   ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_11_30_59_499_00.jpg",
                   CategoryId = 2,
                   Recommended = false
               },
               new Product
               {
                   Id = 10,
                   Title = "Huawei MatePad Paper 4/64GB WiFi ",
                   Description = "Oto Huawei MatePad Paper 64 GB WiFi czarny, czyli pierwszy tablet od Huawei z wyświetlaczem E Ink. Korzystaj z urządzenia jak z notatnika, szkicownika lub po prostu czytnika e-book. Od teraz robienie notatek wejdzie na zupełnie nowy poziom, a Ty już nigdy nie pomyślisz o tradycyjnej kartce papieru. Z rysikiem HUAWEI M-Pencil szybkie zapisywanie ważnych spotkań i informacji będzie jeszcze przyjemniejsze. Duży ekran i pojemna bateria przełożą się na komfort pracy, jakiego nigdy nie doświadczyłeś.",
                   ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/6/pr_2022_6_14_7_49_15_78_07.jpg",
                   CategoryId = 2,
                   Recommended = false
               },
               new Product
               {
                   Id = 11,
                   Title = "ASUS RT-AC51 (750Mb/s a/b/g/n/ac)",
                   Description = "Router model RT-AC51 firmy ASUS posiada przepustowość na poziomie do 733 Mb/s, przy jednoczesnym nadawaniu na paśmie 2,4 GHz i 5 GHz odpowiednio 300 Mb/s i 433 Mb/s. Urządzenie cechuje szeroki zasięg i wydajność, dzięki czterem wbudowanym antenom zewnętrznym. Możesz swobodnie przeglądać strony internetowe na jednym paśmie i jednocześnie strumieniować wymagające treści na drugim, co znacznie ułatwia korzystanie z sieci przez kilku użytkowników.",
                   ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_12_10_26_7_40_00.jpg",
                   CategoryId = 3,
                   Recommended = false
               }
                        );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 5,
                    Price = 99m,
                    OriginalPrice = 99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 4,
                    Price = 2299m,
                    OriginalPrice = 2299m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 4,
                    Price = 999m,
                    OriginalPrice = 1199m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 4,
                    Price = 1899m,
                    OriginalPrice = 1899m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 5,
                    Price = 599m,
                    OriginalPrice = 599m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 49m,
                    OriginalPrice = 58.99m
                },
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
        public DbSet<User> Users { get; set; }


    }

}
