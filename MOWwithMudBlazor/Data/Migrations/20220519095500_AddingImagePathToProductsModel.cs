using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOWwithMudBlazor.Data.Migrations
{
    public partial class AddingImagePathToProductsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ProductsTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ProductsTable");
        }
    }
}
