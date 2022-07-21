using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneApp.Server.Migrations
{
    public partial class AddFirstUnits : Migration
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
                    Featured = table.Column<bool>(type: "bit", nullable: false)
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
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Zachwycający płynnością i responsywnością wyświetlacz Super Retina XDR z technologią ProMotion. Potężne udoskonalenia systemu aparatów dające spektakularne nowe możliwości. Bezkonkurencyjna trwałość. Ultraszybki czip A15 Bionic. I przełomowa wydajność baterii. Oto propozycja.", true, "https://www.x-kom.pl/p/681200-smartfon-telefon-apple-iphone-13-pro-max-1tb-graphite.html", "Apple iPhone 13 Pro Max Graphite" },
                    { 2, 1, "Daj się ponieść z nowym smartfonem OnePlus 9 5G 8/128 GB Astral Black. Smukła konstrukcja, świetne podzespoły, przestronny, olśniewający ekran i oszałamiająca wydajność to klucz do sukcesu. A do tego system aparatów, które jakością zdjęć są w stanie przyćmić niejednego konkurenta. OnePlus 9 5G to zdecydowanie smartfon, który dotrzyma Ci kroku każdego dnia.", true, "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/11/pr_2021_11_26_15_21_10_123_02.jpg", "OnePlus 9 5G Astral Black 120Hz" },
                    { 3, 1, "Popatrz jak wygląda nowy Samsung Galaxy S21 FE 128 GB 5G Fan Edition szary, Jego konstrukcja nawiązuje do rodziny S21. Obudowa jest elegancka, a zarazem minimalistyczna. Dzięki temu jest po prostu piękna. W jej konstrukcji znalazło się miejsce na trzy aparaty, które zagwarantują doskonałe ujęcia. Potem możesz je wyświetlić na ekran o wielkości 6,4 cala. Ma on rozdzielczość Full HD+, więc każde treści już stale będą pełne detali i szczegółów. To wszystko dopełnia procesor z ośmioma rdzeniami. Jest to Snapdragon 888. Korzystaj o resztę zadba S21 FE 5G Fan Edition.", true, "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_23_8_39_30_82_01.jpg", "Samsung Galaxy S21 FE 5G Fan Edition Grey" },
                    { 4, 2, "Turbodopalany czipem Apple M1.Najdoskonalszy iPad.Czip M1 wynosi go na nowy poziom wydajności, wyświetlacz Liquid Retina XDR olśniewa jakością obrazu, a interfejs bezprzewodowy 5G śmiga z zawrotną prędkością◊. Zapnij pasy.", false, "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/4/pr_2021_4_20_21_38_10_357_00.jpg", "Apple iPad Pro 12,9\" M1 Wi - Fi Space Gray" },
                    { 5, 3, "Postaw na szybkość i wybierz kabel Silver Monkey z symetrycznym wtykiem USB-C i portem USB 3.0. jest kompatybilny z każdym urządzeniem posiadającym port USB-C, jak i złącze w Thunderbolt, obecny w komputerach Apple. Z jego pomocą błyskawicznie prześlesz dane albo naładujesz urządzenie mobilne. Co więcej, dzięki długości 1,2 metra kabel bez trudu mieści się w torbie, plecaku, damskiej torebce, a nawet w kieszeni kurtki.", false, "https://allegro.stati.pl/AllegroIMG/PRODUCENCI/Silver-Monkey/Kabel-Type-C-USB-3.0/1%2C2m/kabel_type-C_1-2m_2m_zlacza.jpg?", "Silver Monkey Kabel USB 3.0 - USB-C 1,2m" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 19.99m, 9.99m },
                    { 1, 2, 19.99m, 9.99m },
                    { 1, 3, 19.99m, 9.99m },
                    { 2, 1, 19.99m, 9.99m },
                    { 2, 2, 19.99m, 9.99m },
                    { 2, 3, 19.99m, 9.99m },
                    { 3, 1, 19.99m, 9.99m },
                    { 3, 2, 19.99m, 9.99m },
                    { 3, 3, 19.99m, 9.99m },
                    { 4, 4, 19.99m, 9.99m },
                    { 5, 5, 19.99m, 9.99m }
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
