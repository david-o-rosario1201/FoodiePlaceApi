using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiePlaceApi.Migrations
{
    /// <inheritdoc />
    public partial class Notificaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Pedidos",
                newName: "Tiempo");

            migrationBuilder.AddColumn<string>(
                name: "NombreTitular",
                table: "Tarjetas",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraReservacion",
                table: "Reservaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NumeroMesa",
                table: "Reservaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tiempo",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Itbis",
                table: "PedidosDetalle",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    NotificacionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 70, nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.NotificacionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "NombreTitular",
                table: "Tarjetas");

            migrationBuilder.DropColumn(
                name: "HoraReservacion",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "NumeroMesa",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "Tiempo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Itbis",
                table: "PedidosDetalle");

            migrationBuilder.RenameColumn(
                name: "Tiempo",
                table: "Pedidos",
                newName: "Total");
        }
    }
}
