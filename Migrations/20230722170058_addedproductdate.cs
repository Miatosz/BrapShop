using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrapShop.Migrations
{
    public partial class addedproductdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Review",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Review_AuthorId",
                table: "Review",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_AuthorId",
                table: "Review",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_AuthorId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_AuthorId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Products");
        }
    }
}
