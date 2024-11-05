using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Pagos
{
    [Key]
    public int PagoId { get; set; }

    [ForeignKey("Pedido")]
    public int PedidoId { get; set; }

    [Required]
    public string TipoTarjeta { get; set; }

    [Required]
    [StringLength(16, MinimumLength = 13)] // Limita la longitud del número de tarjeta entre 13 y 16 caracteres
    [RegularExpression(@"^\d+$", ErrorMessage = "El número de tarjeta debe contener solo dígitos.")]
    public string NumeroTarjeta { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaExpiracion { get; set; }

    [Required]
    [StringLength(3, MinimumLength = 3)] // Limita la longitud del CVV a 3 caracteres
    [RegularExpression(@"^\d+$", ErrorMessage = "El CVV debe contener solo dígitos.")]
    public string CVV { get; set; }

    [Required]
    public DateTime FechaPago { get; set; } = DateTime.Now;

    [Required]
    public decimal Monto { get; set; }
}
