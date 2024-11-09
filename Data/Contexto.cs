using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

public class AppDbContext : DbContext
{
    public DbSet<Detenido> Detenidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=redadasMigracion.db");

        
    }
}
