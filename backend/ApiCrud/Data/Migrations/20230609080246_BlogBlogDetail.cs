using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiCrud.Data.Migrations
{
    /// <inheritdoc />
    public partial class BlogBlogDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "82429cf0-1711-4af5-981c-56d4f81933c9");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "940c009f-5d24-4b69-a7f4-35d92e65b7a7");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "b1faff97-73d2-4aea-8761-2897760a488d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 9, 8, 2, 45, 356, DateTimeKind.Utc).AddTicks(5542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 13, 11, 44, 13, 942, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogDetails_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59da378a-5215-4979-a35e-a8c7fcf90a43", null, "Admin", "ADMIN" },
                    { "aef9f680-e7ba-4b2e-a342-f3b1a49083e0", null, "SuperAdmin", "SUPERADMIN" },
                    { "c3e36817-dc20-4a9c-8432-93a96aeb03b2", null, "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "185216af-70fa-4ded-ac77-19edf0c58f4e", 0, "66bf8fef-ef04-4785-8ea7-9ad4def6cfee", "A.Asgar@gmail.com", true, false, null, "A.ASGAR@GMAIL.COM", "A.ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEF0z4HkUfpjbiPP2NgnDdi/X4L9e+OKEeau2gbHLa7dV8ePMJ6C1WRoOnk5afhdcpg==", null, false, "f811f121-a6e9-4f78-827b-b72edd41bf17", false, "A.Asgar@gmail.com" },
                    { "8ccf84a5-bf51-458a-b649-6e421549e3da", 0, "84de90af-6b92-4c05-b9fd-6093fd051193", "A.Asgar@gmail.com", true, false, null, "A.ASGAR@GMAIL.COM", "A.ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEJEW9P7KE6rE7rBYXOAkBllLZuZCl/GfRAgp8MWBb9ODAb8DLmtXWrmCktpu77S7WA==", null, false, "43d22ed3-69fa-4a46-8db8-426dc4fe93dc", false, "A.Asgar@gmail.com" },
                    { "f1fb11dc-04d6-4884-a0ea-b12f23dc8b1f", 0, "3e11c637-a83e-4f5b-b8cb-551c73864379", "Asgar@gmail.com", true, false, null, "ASGAR@GMAIL.COM", "ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEHiB7ygAEjH+wmwgbbu5JAOvvaY1WGOTqshYoR279hDpS2QLxbWV7pOwEPzQIc4epg==", null, false, "cc527b5a-c768-4333-afc5-fc11cc65d0b2", false, "Asgar@gmail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogId",
                table: "BlogDetails",
                column: "BlogId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogDetails");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59da378a-5215-4979-a35e-a8c7fcf90a43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aef9f680-e7ba-4b2e-a342-f3b1a49083e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e36817-dc20-4a9c-8432-93a96aeb03b2");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "185216af-70fa-4ded-ac77-19edf0c58f4e");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "8ccf84a5-bf51-458a-b649-6e421549e3da");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "f1fb11dc-04d6-4884-a0ea-b12f23dc8b1f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 13, 11, 44, 13, 942, DateTimeKind.Utc).AddTicks(3885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 9, 8, 2, 45, 356, DateTimeKind.Utc).AddTicks(5542));

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
    }
}
