using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOWwithMudBlazor.Data.Migrations
{
    public partial class addingProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HardDisk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsTable_ComapniesTable_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "ComapniesTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTable_CompanyId",
                table: "ProductsTable",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsTable");
        }
    }
}
