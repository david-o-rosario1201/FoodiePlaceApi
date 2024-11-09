using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiePlaceApi.Migrations
{
    /// <inheritdoc />
    public partial class Tarjetas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "FechaExpiracion",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "NumeroTarjeta",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "TipoTarjeta",
                table: "Pagos");

            migrationBuilder.AddColumn<int>(
                name: "TarjetaId",
                table: "Pagos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ofertas",
                columns: table => new
                {
                    OfertasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    Descuento = table.Column<decimal>(type: "TEXT", nullable: false),
                    PrecioOferta = table.Column<decimal>(type: "TEXT", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Imagen = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ofertas", x => x.OfertasId);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    TarjetaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoTarjeta = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroTarjeta = table.Column<string>(type: "TEXT", maxLength: 16, nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CVV = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.TarjetaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ofertas");

            migrationBuilder.DropTable(
                name: "Tarjetas");

            migrationBuilder.DropColumn(
                name: "TarjetaId",
                table: "Pagos");

            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "Pagos",
                type: "TEXT",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaExpiracion",
                table: "Pagos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NumeroTarjeta",
                table: "Pagos",
                type: "TEXT",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoTarjeta",
                table: "Pagos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
