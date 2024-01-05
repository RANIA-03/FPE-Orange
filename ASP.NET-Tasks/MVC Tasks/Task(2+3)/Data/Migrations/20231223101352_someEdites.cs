using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_2_3_.Data.Migrations
{
    public partial class someEdites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "products",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "categories",
                newName: "Photo");

            migrationBuilder.AddColumn<string>(
                name: "PhotoName",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contentType",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhotoName",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contentType",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoName",
                table: "products");

            migrationBuilder.DropColumn(
                name: "contentType",
                table: "products");

            migrationBuilder.DropColumn(
                name: "PhotoName",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "contentType",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "products",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "categories",
                newName: "Image");
        }
    }
}
