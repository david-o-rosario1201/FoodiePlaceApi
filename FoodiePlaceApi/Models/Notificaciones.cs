using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiePlaceApi.Models;

public class Notificaciones
{
    [Key]
    public int NotificacionId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    [StringLength(70, ErrorMessage = "La descripción no puede tener más de 50 caracteres.")]
    public string Descripcion { get; set; }

    public DateTime Fecha { get; set; }
}
