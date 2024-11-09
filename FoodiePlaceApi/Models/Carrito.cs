using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiePlaceApi.Models;
public class Carrito
{
    [Key]
    public int CarritoId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [Required]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    [ForeignKey("CarritoId")]
    public ICollection<CarritoDetalle> CarritoDetalle { get; set; } = new List<CarritoDetalle>();
}
