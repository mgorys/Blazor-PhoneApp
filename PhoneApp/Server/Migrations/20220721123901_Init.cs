using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneApp.Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Recommended = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Phones", "phones" },
                    { 2, "Devices", "devices" },
                    { 3, "Accesories", "accesories" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "128GB" },
                    { 2, "512GB" },
                    { 3, "1024GB" },
                    { 4, "Devices" },
                    { 5, "Accesories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Recommended", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Zachwycający płynnością i responsywnością wyświetlacz Super Retina XDR z technologią ProMotion. Potężne udoskonalenia systemu aparatów dające spektakularne nowe możliwości. Bezkonkurencyjna trwałość. Ultraszybki czip A15 Bionic. I przełomowa wydajność baterii. Oto propozycja.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/7/pr_2022_7_8_9_15_52_561_00.jpg", true, "Apple iPhone 13 Pro Max Graphite" },
                    { 2, 1, "Daj się ponieść z nowym smartfonem OnePlus 9 5G 8/128 GB Astral Black. Smukła konstrukcja, świetne podzespoły, przestronny, olśniewający ekran i oszałamiająca wydajność to klucz do sukcesu. A do tego system aparatów, które jakością zdjęć są w stanie przyćmić niejednego konkurenta. OnePlus 9 5G to zdecydowanie smartfon, który dotrzyma Ci kroku każdego dnia.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/11/pr_2021_11_26_15_21_10_123_02.jpg", true, "OnePlus 9 5G Astral Black 120Hz" },
                    { 3, 1, "Popatrz jak wygląda nowy Samsung Galaxy S21 FE 128 GB 5G Fan Edition szary, Jego konstrukcja nawiązuje do rodziny S21. Obudowa jest elegancka, a zarazem minimalistyczna. Dzięki temu jest po prostu piękna. W jej konstrukcji znalazło się miejsce na trzy aparaty, które zagwarantują doskonałe ujęcia. Potem możesz je wyświetlić na ekran o wielkości 6,4 cala. Ma on rozdzielczość Full HD+, więc każde treści już stale będą pełne detali i szczegółów. To wszystko dopełnia procesor z ośmioma rdzeniami. Jest to Snapdragon 888. Korzystaj o resztę zadba S21 FE 5G Fan Edition.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_23_8_39_30_82_01.jpg", true, "Samsung Galaxy S21 FE 5G Fan Edition Grey" },
                    { 4, 2, "Turbodopalany czipem Apple M1.Najdoskonalszy iPad.Czip M1 wynosi go na nowy poziom wydajności, wyświetlacz Liquid Retina XDR olśniewa jakością obrazu, a interfejs bezprzewodowy 5G śmiga z zawrotną prędkością◊. Zapnij pasy.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/4/pr_2021_4_20_21_38_10_357_00.jpg", true, "Apple iPad Pro 12,9\" M1 Wi - Fi Space Gray" },
                    { 5, 3, "Postaw na szybkość i wybierz kabel Silver Monkey z symetrycznym wtykiem USB-C i portem USB 3.0. jest kompatybilny z każdym urządzeniem posiadającym port USB-C, jak i złącze w Thunderbolt, obecny w komputerach Apple. Z jego pomocą błyskawicznie prześlesz dane albo naładujesz urządzenie mobilne. Co więcej, dzięki długości 1,2 metra kabel bez trudu mieści się w torbie, plecaku, damskiej torebce, a nawet w kieszeni kurtki.", "https://allegro.stati.pl/AllegroIMG/PRODUCENCI/Silver-Monkey/Kabel-Type-C-USB-3.0/1%2C2m/kabel_type-C_1-2m_2m_zlacza.jpg?", false, "Silver Monkey Kabel USB 3.0 - USB-C 1,2m" },
                    { 6, 3, "Mysz Wireless Mobile Mouse 1850 zaprojektowano do mobilnego trybu życia — zapewnia bezprzewodową swobodę oraz komfort dla Twojej dłoni. Możliwość obsługi w lewej i prawej dłoni oraz kółko przewijania ułatwiające poruszanie się sprawiają, że ta mysz jest idealnym urządzeniem dostosowanym do nowoczesnego, mobilnego trybu życia.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/4/pr_2022_4_8_13_17_41_779_00.jpg", false, "Microsoft 1850 Wireless Mobile Mouse" },
                    { 7, 3, "NuPhy Air75 Red to wyjątkowa klawiatura pod względem prostoty, jak i wygody użytkowania. Zapewnij sobie odpowiedni komfort pracy w biurze lub w domowym zaciszu. Kompaktowa konstrukcja w formacie 75% świetnie wpasuje się w przestrzeń na Twoim biurku. Zadbaj o odpowiednią ergonomię podczas spędzania długich godzin przed komputerem. Wybierz NuPhy Air75 Red i zwiększ swoją produktywność.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/7/pr_2022_7_14_6_49_22_600_00.jpg", false, "NuPhy Air75 Red, Gateron" },
                    { 8, 2, "Wykorzystaj możliwości Xiaomi Pad 5 128 GB Cosmic Gray do nauki, pracy lub rozrywki. Bez względu na to, czy jesteś w domu, biurze, czy na świeżym powietrzu – tablet jest zawsze gotowy do pracy. Pad 5 wyposażono w funkcję redukującą emisje szkodliwego światła niebieskiego oraz technologie Sunlight Display i True Display. Dzięki nim możesz bezpiecznie i komfortowo korzystać z urządzenia przez długo. A z baterią o pojemności 8720 mAh jest to jak najbardziej możliwe.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/5/pr_2022_5_27_12_13_38_693_00.jpg", false, "Xiaomi Pad 5 6/128GB Cosmic Gray 120Hz" },
                    { 9, 2, "Korzystaj z Samsung Galaxy Tab A8 X200 WiFi 64 GB srebrny i nie obawiaj się o brak energii. Tablet ma baterię o pojemności 7040 mAh. Dodatkowo w tej eleganckiej konstrukcji znalazło się miejsce na duży ekran. Jest on o przekątnej 10,5 cala. Dzięki niemu obejrzysz różne treści. Czy to prezentacja na zajęcia, czy kolejny odcinek ulubionego serialu. Całość będzie w naprawdę dobrej jakości. Co ważne z Tab A8 X200 uzyskasz również dobre ujęcia. To przez przedni, lub tylny aparat. Wybierz tylko odpowiedni.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_11_30_59_499_00.jpg", false, "Samsung Galaxy Tab A8 X200 WiFi 4/64GB srebrny" },
                    { 10, 2, "Oto Huawei MatePad Paper 64 GB WiFi czarny, czyli pierwszy tablet od Huawei z wyświetlaczem E Ink. Korzystaj z urządzenia jak z notatnika, szkicownika lub po prostu czytnika e-book. Od teraz robienie notatek wejdzie na zupełnie nowy poziom, a Ty już nigdy nie pomyślisz o tradycyjnej kartce papieru. Z rysikiem HUAWEI M-Pencil szybkie zapisywanie ważnych spotkań i informacji będzie jeszcze przyjemniejsze. Duży ekran i pojemna bateria przełożą się na komfort pracy, jakiego nigdy nie doświadczyłeś.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/6/pr_2022_6_14_7_49_15_78_07.jpg", false, "Huawei MatePad Paper 4/64GB WiFi " },
                    { 11, 3, "Router model RT-AC51 firmy ASUS posiada przepustowość na poziomie do 733 Mb/s, przy jednoczesnym nadawaniu na paśmie 2,4 GHz i 5 GHz odpowiednio 300 Mb/s i 433 Mb/s. Urządzenie cechuje szeroki zasięg i wydajność, dzięki czterem wbudowanym antenom zewnętrznym. Możesz swobodnie przeglądać strony internetowe na jednym paśmie i jednocześnie strumieniować wymagające treści na drugim, co znacznie ułatwia korzystanie z sieci przez kilku użytkowników.", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/9/pr_2019_9_12_10_26_7_40_00.jpg", false, "ASUS RT-AC51 (750Mb/s a/b/g/n/ac)" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 5699m, 5699m },
                    { 1, 2, 7199m, 7199m },
                    { 1, 3, 8199m, 7599m },
                    { 2, 1, 3349m, 3349m },
                    { 2, 2, 5599m, 5599m },
                    { 2, 3, 6499m, 5999m },
                    { 3, 1, 3499m, 3499m },
                    { 3, 2, 5999m, 5999m },
                    { 3, 3, 6999m, 6499m },
                    { 4, 4, 8699m, 8199m },
                    { 5, 5, 24.99m, 24.99m },
                    { 6, 5, 58.99m, 49m },
                    { 7, 5, 599m, 599m },
                    { 8, 4, 1899m, 1899m },
                    { 9, 4, 1199m, 999m },
                    { 10, 4, 2299m, 2299m },
                    { 11, 5, 99m, 99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
