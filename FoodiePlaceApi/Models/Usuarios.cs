using System.ComponentModel.DataAnnotations;

namespace FoodiePlaceApi.Models;
public class Usuarios
{
    [Key]
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
    [RegularExpression(@"^(\d{10}|(\d{3}-\d{3}-\d{4}))$", ErrorMessage = "El número de teléfono debe tener 10 dígitos o el formato XXX-XXX-XXXX.")]
    public string Telefono { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
    [MaxLength(255, ErrorMessage = "El correo electrónico no puede tener más de 255 caracteres.")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [StringLength(100, ErrorMessage = "La contraseña debe tener al menos {2} caracteres y máximo {1} caracteres.", MinimumLength = 6)]
    public string Contrasena { get; set; }
}
