using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiCrud.Data.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                defaultValue: new DateTime(2023, 6, 16, 13, 11, 11, 127, DateTimeKind.Utc).AddTicks(1842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 9, 8, 2, 45, 356, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10e32c63-c914-4c86-afba-a356dcfeb33c", null, "Admin", "ADMIN" },
                    { "237e3321-fa9e-4dae-a66f-6a46b59c946b", null, "Member", "MEMBER" },
                    { "d5e9ab22-d951-48a9-b95b-567a17232eab", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9b319782-8285-48b8-869e-18d100cc71ef", 0, "402b01d9-c830-4ae3-8f41-560bef9f1de3", "A.Asgar@gmail.com", true, false, null, "A.ASGAR@GMAIL.COM", "A.ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAENzL7ZCr4RrxPNIX32tvVPbwKDxajHeKY9Ry8B5HGv/2q5zJEVdMsOaF2IbOkiDDxA==", null, false, "6b32e116-effc-4e76-aed0-ccf5016ae0a1", false, "A.Asgar@gmail.com" },
                    { "a92d7201-7249-4ba1-b3cf-56676d745ec4", 0, "d1475a13-ce9c-4ba5-b710-594928c28df0", "A.Asgar@gmail.com", true, false, null, "A.ASGAR@GMAIL.COM", "A.ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEK+tFdjrcGAXbI5iMBrhbmqU+3dcj772joJhUBxpArQGpl6N7QTHVvoGCQJGoT8uUQ==", null, false, "4cb4af57-7479-4337-b578-71cfdf9ef7ce", false, "A.Asgar@gmail.com" },
                    { "c9d295b7-a6bd-4bf6-a40b-e0c2f14f17b4", 0, "f0b72a83-4a3f-449e-8bf2-614d24d316bd", "Asgar@gmail.com", true, false, null, "ASGAR@GMAIL.COM", "ASGAR@GMAIL.COM", "AQAAAAIAAYagAAAAEA0DgXyddyDYRpH8qC7fkqUZ6QCQyRObgVeYN8cY2Wz05Yzu9+Jtwikkm8TMUMri9w==", null, false, "e79e1f4c-474a-4b98-9de4-9203cf33a08b", false, "Asgar@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e32c63-c914-4c86-afba-a356dcfeb33c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "237e3321-fa9e-4dae-a66f-6a46b59c946b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5e9ab22-d951-48a9-b95b-567a17232eab");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "9b319782-8285-48b8-869e-18d100cc71ef");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "a92d7201-7249-4ba1-b3cf-56676d745ec4");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "c9d295b7-a6bd-4bf6-a40b-e0c2f14f17b4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 9, 8, 2, 45, 356, DateTimeKind.Utc).AddTicks(5542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 16, 13, 11, 11, 127, DateTimeKind.Utc).AddTicks(1842));

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
        }
    }
}
