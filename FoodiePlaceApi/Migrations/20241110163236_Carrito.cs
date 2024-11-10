using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiePlaceApi.Migrations
{
    /// <inheritdoc />
    public partial class Carrito : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Pagado",
                table: "CarritoDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pagado",
                table: "CarritoDetalle");
        }
    }
}
