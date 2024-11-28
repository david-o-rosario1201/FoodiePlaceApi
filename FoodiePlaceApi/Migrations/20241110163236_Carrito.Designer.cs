﻿// <auto-generated />
using System;
using FoodiePlaceApi.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodiePlaceApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241110163236_Carrito")]
    partial class Carrito
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("FoodiePlaceApi.Models.Carrito", b =>
                {
                    b.Property<int>("CarritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarritoId");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.CarritoDetalle", b =>
                {
                    b.Property<int>("CarritoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarritoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Impuesto")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Pagado")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Propina")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("CarritoDetalleId");

                    b.HasIndex("CarritoId");

                    b.ToTable("CarritoDetalle");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Ofertas", b =>
                {
                    b.Property<int>("OfertasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("BLOB");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioOferta")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OfertasId");

                    b.ToTable("Ofertas");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Pagos", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("PedidoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TarjetaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PagoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Pedidos", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ParaLlevar")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.PedidosDetalle", b =>
                {
                    b.Property<int>("PedidoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PedidoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("PedidoDetalleId");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidosDetalle");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Disponibilidad")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Resena", b =>
                {
                    b.Property<int>("ResenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calificacion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaResena")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ResenaId");

                    b.ToTable("Resena");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Reservaciones", b =>
                {
                    b.Property<int>("ReservacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaReservacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroPersonas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReservacionId");

                    b.ToTable("Reservaciones");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Tarjetas", b =>
                {
                    b.Property<int>("TarjetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaExpiracion")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroTarjeta")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoTarjeta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TarjetaId");

                    b.ToTable("Tarjetas");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.CarritoDetalle", b =>
                {
                    b.HasOne("FoodiePlaceApi.Models.Carrito", null)
                        .WithMany("CarritoDetalle")
                        .HasForeignKey("CarritoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.PedidosDetalle", b =>
                {
                    b.HasOne("FoodiePlaceApi.Models.Pedidos", null)
                        .WithMany("PedidosDetalle")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Carrito", b =>
                {
                    b.Navigation("CarritoDetalle");
                });

            modelBuilder.Entity("FoodiePlaceApi.Models.Pedidos", b =>
                {
                    b.Navigation("PedidosDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}