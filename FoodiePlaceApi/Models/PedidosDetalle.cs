using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiePlaceApi.Models;
public class PedidosDetalle
{
    [Key]
    public int PedidoDetalleId { get; set;}

    public int PedidoId { get; set; }

    [ForeignKey("Productos")]
    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }


    public decimal Itbis { get; set; }

    public decimal SubTotal { get; set; }
}
