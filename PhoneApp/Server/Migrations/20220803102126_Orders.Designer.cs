﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneApp.Server;

#nullable disable

namespace PhoneApp.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220803102126_Orders")]
    partial class Orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PhoneApp.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("PhoneApp.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Phones",
                            Url = "phones"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Devices",
                            Url = "devices"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Accesories",
                            Url = "accesories"
                        });
                });

            modelBuilder.Entity("PhoneApp.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PhoneApp.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("PhoneApp.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Recommended")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Zachwycający płynnością i responsywnością wyświetlacz Super Retina XDR z technologią ProMotion. Potężne udoskonalenia systemu aparatów dające spektakularne nowe możliwości. Bezkonkurencyjna trwałość. Ultraszybki czip A15 Bionic. I przełomowa wydajność baterii. Oto propozycja.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/7/pr_2022_7_8_9_15_52_561_00.jpg",
                            Recommended = true,
                            Title = "Apple iPhone 13 Pro Max Graphite"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Daj się ponieść z nowym smartfonem OnePlus 9 5G 8/128 GB Astral Black. Smukła konstrukcja, świetne podzespoły, przestronny, olśniewający ekran i oszałamiająca wydajność to klucz do sukcesu. A do tego system aparatów, które jakością zdjęć są w stanie przyćmić niejednego konkurenta. OnePlus 9 5G to zdecydowanie smartfon, który dotrzyma Ci kroku każdego dnia.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/11/pr_2021_11_26_15_21_10_123_02.jpg",
                            Recommended = true,
                            Title = "OnePlus 9 5G Astral Black 120Hz"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Popatrz jak wygląda nowy Samsung Galaxy S21 FE 128 GB 5G Fan Edition szary, Jego konstrukcja nawiązuje do rodziny S21. Obudowa jest elegancka, a zarazem minimalistyczna. Dzięki temu jest po prostu piękna. W jej konstrukcji znalazło się miejsce na trzy aparaty, które zagwarantują doskonałe ujęcia. Potem możesz je wyświetlić na ekran o wielkości 6,4 cala. Ma on rozdzielczość Full HD+, więc każde treści już stale będą pełne detali i szczegółów. To wszystko dopełnia procesor z ośmioma rdzeniami. Jest to Snapdragon 888. Korzystaj o resztę zadba S21 FE 5G Fan Edition.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_23_8_39_30_82_01.jpg",
                            Recommended = true,
                            Title = "Samsung Galaxy S21 FE 5G Fan Edition Grey"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Turbodopalany czipem Apple M1.Najdoskonalszy iPad.Czip M1 wynosi go na nowy poziom wydajności, wyświetlacz Liquid Retina XDR olśniewa jakością obrazu, a interfejs bezprzewodowy 5G śmiga z zawrotną prędkością◊. Zapnij pasy.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/4/pr_2021_4_20_21_38_10_357_00.jpg",
                            Recommended = true,
                            Title = "Apple iPad Pro 12,9\" M1 Wi - Fi Space Gray"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Postaw na szybkość i wybierz kabel Silver Monkey z symetrycznym wtykiem USB-C i portem USB 3.0. jest kompatybilny z każdym urządzeniem posiadającym port USB-C, jak i złącze w Thunderbolt, obecny w komputerach Apple. Z jego pomocą błyskawicznie prześlesz dane albo naładujesz urządzenie mobilne. Co więcej, dzięki długości 1,2 metra kabel bez trudu mieści się w torbie, plecaku, damskiej torebce, a nawet w kieszeni kurtki.",
                            ImageUrl = "https://allegro.stati.pl/AllegroIMG/PRODUCENCI/Silver-Monkey/Kabel-Type-C-USB-3.0/1%2C2m/kabel_type-C_1-2m_2m_zlacza.jpg?",
                            Recommended = false,
                            Title = "Silver Monkey Kabel USB 3.0 - USB-C 1,2m"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Mysz Wireless Mobile Mouse 1850 zaprojektowano do mobilnego trybu życia — zapewnia bezprzewodową swobodę oraz komfort dla Twojej dłoni. Możliwość obsługi w lewej i prawej dłoni oraz kółko przewijania ułatwiające poruszanie się sprawiają, że ta mysz jest idealnym urządzeniem dostosowanym do nowoczesnego, mobilnego trybu życia.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/4/pr_2022_4_8_13_17_41_779_00.jpg",
                            Recommended = false,
                            Title = "Microsoft 1850 Wireless Mobile Mouse"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "NuPhy Air75 Red to wyjątkowa klawiatura pod względem prostoty, jak i wygody użytkowania. Zapewnij sobie odpowiedni komfort pracy w biurze lub w domowym zaciszu. Kompaktowa konstrukcja w formacie 75% świetnie wpasuje się w przestrzeń na Twoim biurku. Zadbaj o odpowiednią ergonomię podczas spędzania długich godzin przed komputerem. Wybierz NuPhy Air75 Red i zwiększ swoją produktywność.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/7/pr_2022_7_14_6_49_22_600_00.jpg",
                            Recommended = false,
                            Title = "NuPhy Air75 Red, Gateron"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Wykorzystaj możliwości Xiaomi Pad 5 128 GB Cosmic Gray do nauki, pracy lub rozrywki. Bez względu na to, czy jesteś w domu, biurze, czy na świeżym powietrzu – tablet jest zawsze gotowy do pracy. Pad 5 wyposażono w funkcję redukującą emisje szkodliwego światła niebieskiego oraz technologie Sunlight Display i True Display. Dzięki nim możesz bezpiecznie i komfortowo korzystać z urządzenia przez długo. A z baterią o pojemności 8720 mAh jest to jak najbardziej możliwe.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_27_12_13_38_693_00.jpg",
                            Recommended = false,
                            Title = "Xiaomi Pad 5 6/128GB Cosmic Gray 120Hz"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Korzystaj z Samsung Galaxy Tab A8 X200 WiFi 64 GB srebrny i nie obawiaj się o brak energii. Tablet ma baterię o pojemności 7040 mAh. Dodatkowo w tej eleganckiej konstrukcji znalazło się miejsce na duży ekran. Jest on o przekątnej 10,5 cala. Dzięki niemu obejrzysz różne treści. Czy to prezentacja na zajęcia, czy kolejny odcinek ulubionego serialu. Całość będzie w naprawdę dobrej jakości. Co ważne z Tab A8 X200 uzyskasz również dobre ujęcia. To przez przedni, lub tylny aparat. Wybierz tylko odpowiedni.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_11_30_59_499_00.jpg",
                            Recommended = false,
                            Title = "Samsung Galaxy Tab A8 X200 WiFi 4/64GB srebrny"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Oto Huawei MatePad Paper 64 GB WiFi czarny, czyli pierwszy tablet od Huawei z wyświetlaczem E Ink. Korzystaj z urządzenia jak z notatnika, szkicownika lub po prostu czytnika e-book. Od teraz robienie notatek wejdzie na zupełnie nowy poziom, a Ty już nigdy nie pomyślisz o tradycyjnej kartce papieru. Z rysikiem HUAWEI M-Pencil szybkie zapisywanie ważnych spotkań i informacji będzie jeszcze przyjemniejsze. Duży ekran i pojemna bateria przełożą się na komfort pracy, jakiego nigdy nie doświadczyłeś.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/6/pr_2022_6_14_7_49_15_78_07.jpg",
                            Recommended = false,
                            Title = "Huawei MatePad Paper 4/64GB WiFi "
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Router model RT-AC51 firmy ASUS posiada przepustowość na poziomie do 733 Mb/s, przy jednoczesnym nadawaniu na paśmie 2,4 GHz i 5 GHz odpowiednio 300 Mb/s i 433 Mb/s. Urządzenie cechuje szeroki zasięg i wydajność, dzięki czterem wbudowanym antenom zewnętrznym. Możesz swobodnie przeglądać strony internetowe na jednym paśmie i jednocześnie strumieniować wymagające treści na drugim, co znacznie ułatwia korzystanie z sieci przez kilku użytkowników.",
                            ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_12_10_26_7_40_00.jpg",
                            Recommended = false,
                            Title = "ASUS RT-AC51 (750Mb/s a/b/g/n/ac)"
                        });
                });

            modelBuilder.Entity("PhoneApp.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "128GB"
                        },
                        new
                        {
                            Id = 2,
                            Name = "512GB"
                        },
                        new
                        {
                            Id = 3,
                            Name = "1024GB"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Devices"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Accesories"
                        });
                });

            modelBuilder.Entity("PhoneApp.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 11,
                            ProductTypeId = 5,
                            OriginalPrice = 99m,
                            Price = 99m
                        },
                        new
                        {
                            ProductId = 10,
                            ProductTypeId = 4,
                            OriginalPrice = 2299m,
                            Price = 2299m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 4,
                            OriginalPrice = 1199m,
                            Price = 999m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 4,
                            OriginalPrice = 1899m,
                            Price = 1899m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 5,
                            OriginalPrice = 599m,
                            Price = 599m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 5,
                            OriginalPrice = 58.99m,
                            Price = 49m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 1,
                            OriginalPrice = 5699m,
                            Price = 5699m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 7199m,
                            Price = 7199m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 8199m,
                            Price = 7599m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 1,
                            OriginalPrice = 3349m,
                            Price = 3349m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            OriginalPrice = 5599m,
                            Price = 5599m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 3,
                            OriginalPrice = 6499m,
                            Price = 5999m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 1,
                            OriginalPrice = 3499m,
                            Price = 3499m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 5999m,
                            Price = 5999m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 3,
                            OriginalPrice = 6999m,
                            Price = 6499m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 4,
                            OriginalPrice = 8699m,
                            Price = 8199m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 5,
                            OriginalPrice = 24.99m,
                            Price = 24.99m
                        });
                });

            modelBuilder.Entity("PhoneApp.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PhoneApp.Shared.OrderItem", b =>
                {
                    b.HasOne("PhoneApp.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhoneApp.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhoneApp.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("PhoneApp.Shared.Product", b =>
                {
                    b.HasOne("PhoneApp.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PhoneApp.Shared.ProductVariant", b =>
                {
                    b.HasOne("PhoneApp.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhoneApp.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("PhoneApp.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("PhoneApp.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
