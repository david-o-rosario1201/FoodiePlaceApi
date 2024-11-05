using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Categorias
{
    [Key]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "El nombre de la categoría es requerido")]
    [StringLength(100, ErrorMessage = "El nombre de la categoría no puede exceder los 100 caracteres.")]
    public string Nombre { get; set; }

    public byte[]? Imagen { get; set; }
}
