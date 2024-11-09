using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiePlaceApi.Models
{
    public class Ofertas
    {
        [Key]
        public int OfertasId { get; set; }

        [ForeignKey("Productos")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser un número positivo.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El descuento es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El descuento debe ser un número positivo.")]
        public decimal Descuento { get; set; }

        [Required(ErrorMessage = "El precio de oferta es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio de oferta debe ser un número positivo.")]
        public decimal PrecioOferta { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFinal { get; set; }

        public byte[]? Imagen { get; set; }
    }
}
