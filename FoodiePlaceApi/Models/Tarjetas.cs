using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiePlaceApi.Models;

public class Tarjetas
{
    [Key]
    public int TarjetaId { get; set; }


    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [Required]
    public string TipoTarjeta { get; set; }

    [Required]
    [StringLength(16, MinimumLength = 13)] // Limita la longitud del número de tarjeta entre 13 y 16 caracteres
    [RegularExpression(@"^\d+$", ErrorMessage = "El número de tarjeta debe contener solo dígitos.")]
    public string NumeroTarjeta { get; set; }

    [Required]
    public string FechaExpiracion { get; set; }

    [Required]
    [StringLength(3, MinimumLength = 3)] // Limita la longitud del CVV a 3 caracteres
    [RegularExpression(@"^\d+$", ErrorMessage = "El CVV debe contener solo dígitos.")]
    public string CVV { get; set; }
}
