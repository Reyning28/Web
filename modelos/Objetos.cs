// videojuego 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Videojuego
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Desarrollador { get; set; }
    public string? Plataforma { get; set; }  // Relación con plataformas
    public string? Genero { get; set; }
    public DateTime FechaLanzamiento { get; set; }
    public string? ImagenPortada { get; set; }
    public string? Descripcion { get; set; }
    public List<Personaje> Personajes { get; set; } = new List<Personaje>();
}


//plataforma
public class Plataforma
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Agregar esta línea
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public bool Activa { get; set; }
}


//personaje
public class Personaje
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Alias { get; set; }
    public string? Rol { get; set; }
    public string? HabilidadEspecial { get; set; }
    public string? ArmaFavorita { get; set; }
    public int NivelPoder { get; set; }
    public string? Imagen { get; set; }
}

