using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10019838_DamianDare_PROG7311_POE.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedProductClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ProductionDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductionDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Products");
        }
    }
}
