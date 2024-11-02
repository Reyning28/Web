using System.ComponentModel.DataAnnotations;

public class Visita
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El teléfono es obligatorio")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio")]
    public string? Apellido { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio")]
    [EmailAddress(ErrorMessage = "Formato de correo inválido")]
    public string? Correo { get; set; }
}
