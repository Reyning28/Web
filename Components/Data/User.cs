namespace tare9.Data
{
public class User
{
    public int Id { get; set; }
    public string? Usuario { get; set; }
    public string? Clave { get; set; }
    public string? Correo { get; set; }

    public ICollection<Vivencia>? Vivencias { get; set; }  // Relación uno a muchos
}


}