using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Resena
{
    [Key]
    public int ResenaId { get; set; }

    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }

    [Required]
    public string Comentario { get; set; }

    [Required]
    public DateTime FechaResena { get; set; } = DateTime.Now;

    public int Calificacion { get; set; } = 0;
}
