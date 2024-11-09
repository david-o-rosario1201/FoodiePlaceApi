using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Pagos
{
    [Key]
    public int PagoId { get; set; }

    [ForeignKey("Pedido")]
    public int PedidoId { get; set; }

    [ForeignKey("Tarjeta")]
    public int TarjetaId { get; set; }

    [Required]
    public DateTime FechaPago { get; set; } = DateTime.Now;

    [Required]
    public decimal Monto { get; set; }
}
