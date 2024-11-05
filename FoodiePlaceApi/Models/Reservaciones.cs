using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Reservaciones
{
    [Key]
    public int ReservacionId { get; set; }

    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }

    [Required]
    public DateTime FechaReservacion { get; set; } = DateTime.Now;

    [Required]
    public int NumeroPersonas { get; set; }

    [Required]
    public string Estado { get; set; }
}
