using FoodiePlaceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodiePlaceApi.DAL;
public class Contexto: DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }

    public DbSet<Carrito> Carrito { get; set; }

    public DbSet<Pagos> Pagos { get; set; }

    public DbSet<Pedidos> Pedidos { get; set; }

    public DbSet<Productos> Productos { get; set; }

    public DbSet<Resena> Resena { get; set; }

    public DbSet<Reservaciones> Reservaciones { get; set; }

    public DbSet<Usuarios> Usuarios { get; set; }

    public DbSet<Categorias> Categorias { get; set; }
    public DbSet<Tarjetas> Tarjetas { get; set; }
    public DbSet<Ofertas> Ofertas { get; set; }
}
