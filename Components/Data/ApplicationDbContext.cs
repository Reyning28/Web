using Microsoft.EntityFrameworkCore;

namespace tare9.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vivencia> Vivencias { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Vivencia>()
        .HasOne(v => v.Usuario) // Una vivencia tiene un usuario.
        .WithMany(u => u.Vivencias) // Un usuario tiene muchas vivencias.
        .HasForeignKey(v => v.UsuarioId) // Clave foránea en Vivencia.
        .OnDelete(DeleteBehavior.Cascade); // Eliminar vivencias si se elimina el usuario.

    base.OnModelCreating(modelBuilder);
}

    }
}
