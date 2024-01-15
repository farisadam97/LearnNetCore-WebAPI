using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learn1.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Learn1Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "products");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "products",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "products");

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "products",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
