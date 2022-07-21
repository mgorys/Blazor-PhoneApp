using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneApp.Server.Migrations
{
    public partial class ItemsUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/7/pr_2022_7_8_9_15_52_561_00.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.x-kom.pl/p/681200-smartfon-telefon-apple-iphone-13-pro-max-1tb-graphite.html");
        }
    }
}
