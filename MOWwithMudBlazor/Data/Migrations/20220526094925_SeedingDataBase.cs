using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOWwithMudBlazor.Data.Migrations
{
    public partial class SeedingDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344SA-Id", "669dd613-c5c3-42d5-a79b-1965edab144e", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-as123AU-Id", 0, "2de633b0-cc40-4d27-a6c9-6724ef0adc22", "Moh54@gmail.com", true, false, null, "MOH54@GMAIL.COM", "MOH54@GMAIL.COM", "AQAAAAEAACcQAAAAEPIpWTfMVolTw+7LmQ5iE28ODwxLm4j3q3ig7Eo9FtOkDImTVSbSrBf0Sa+D+8jtJA==", null, false, "78199396-02b2-48bc-9a6b-99a3413bdd4c", false, "Moh54@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344SA-Id", "a18be9c0-aa65-4af8-bd17-as123AU-Id" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344SA-Id", "a18be9c0-aa65-4af8-bd17-as123AU-Id" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344SA-Id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-as123AU-Id");
        }
    }
}
