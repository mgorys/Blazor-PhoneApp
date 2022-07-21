using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneApp.Server.Migrations
{
    public partial class ChangeFeaturedIntoRecommended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Featured",
                table: "Products",
                newName: "Recommended");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recommended",
                table: "Products",
                newName: "Featured");
        }
    }
}
