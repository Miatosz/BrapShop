using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrapShop.Migrations
{
    public partial class addedproductsoldcounter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlreadySold",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlreadySold",
                table: "Products");
        }
    }
}
