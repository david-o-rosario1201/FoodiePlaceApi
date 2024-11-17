using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre del producto no puede tener más de 100 caracteres.")]
    public string Nombre { get; set; }

    [ForeignKey("Categorias")]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    public string Descripcion { get; set; } // Usualmente se usa TEXT en la base de datos

    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser un número positivo.")]
    public decimal Precio { get; set; }

    [Required(ErrorMessage = "La disponibilidad es obligatoria.")]
    public bool Disponibilidad { get; set; }

    public byte[]? Imagen { get; set; }

    public string Tiempo { get; set; }
}