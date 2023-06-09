using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiCrud.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 13, 11, 44, 13, 942, DateTimeKind.Utc).AddTicks(3885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 13, 10, 16, 18, 528, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b1a7383-b6b5-490b-9bb7-bc6c24596e82", null, "Member", "MEMBER" },
                    { "99abdae2-f9e8-41a4-970a-2c1548f377f3", null, "SuperAdmin", "SUPERADMIN" },
                    { "e1afaa88-22b5-40c1-8a3e-b395c5f8d074", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82429cf0-1711-4af5-981c-56d4f81933c9", 0, "d0685452-8036-40ce-ac6b-51d964eff370", "Asgar@gmail.com", true, false, null, "ASGAR@GMAIL.COM", "ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEIm9mODLdLYBJbTQhIz56PitTY+OyapFNMPpGhkk2mCyjBk0iF2i19QYuQNjHvQByA==", null, false, "f1df476d-946f-4623-8b27-c3e6c55bf4e4", false, "Asgar@gmail.com" },
                    { "940c009f-5d24-4b69-a7f4-35d92e65b7a7", 0, "090ca361-9d75-4aba-89b3-fa029eb6506f", "A.Asgar@gmail.com", true, false, null, "A.ASGAR@GMAIL.COM", "A.ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEMuhHMXM2EgYCPkKXbFEZUJTjP3YHo19fdpnf8BwSxIeOBYG7xQpF3TOuUAjssriCw==", null, false, "ec5c9a67-0fb7-47a1-b0a6-e691eee40a36", false, "A.Asgar@gmail.com" },
                    { "b1faff97-73d2-4aea-8761-2897760a488d", 0, "1c8ad8e9-8c02-4284-8328-1ec27fd199c7", "A.Asgar@gmail.com", true, false, null, "A.ASGAR@GMAIL.COM", "A.ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEBNSAS3DVC1flExP9F4N0Lg3eB86B5SMhpkVT9cSj+NN4NGU+VBFLRVkZV8bPzoKhA==", null, false, "9c76324b-9c53-42aa-bc0e-f9e23e7dc362", false, "A.Asgar@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b1a7383-b6b5-490b-9bb7-bc6c24596e82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99abdae2-f9e8-41a4-970a-2c1548f377f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1afaa88-22b5-40c1-8a3e-b395c5f8d074");

            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 13, 10, 16, 18, 528, DateTimeKind.Utc).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 13, 11, 44, 13, 942, DateTimeKind.Utc).AddTicks(3885));
        }
    }
}
