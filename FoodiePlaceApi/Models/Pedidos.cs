using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Pedidos
{
    [Key]
    public int PedidoId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [Required]
    public DateTime FechaPedido { get; set; } = DateTime.Now;

    [Required]
    public decimal Total { get; set; }

    [Required]
    public bool ParaLlevar { get; set; }

    [Required]
    public string Estado { get; set; }

    [ForeignKey("PedidoId")]
    public ICollection<PedidosDetalle> PedidosDetalle { get; set; } = new List<PedidosDetalle>();
}
