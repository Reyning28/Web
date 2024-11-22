using Microsoft.AspNetCore.SignalR;
namespace tare9.Data
{
public class Vivencia
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descripcion { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string? Imagen { get; set; }

    public int UsuarioId { get; set; }  // Clave foránea para la relación con Usuario
    public User? Usuario { get; set; }   // Relación con Usuario
}

}
