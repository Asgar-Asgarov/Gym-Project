using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCrud.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategoryEntityConf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 7, 51, 1, 163, DateTimeKind.Utc).AddTicks(2965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 10, 11, 56, 8, 280, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetUtcDate()"),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetUtcDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 10, 11, 56, 8, 280, DateTimeKind.Utc).AddTicks(1141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 7, 51, 1, 163, DateTimeKind.Utc).AddTicks(2965));
        }
    }
}
