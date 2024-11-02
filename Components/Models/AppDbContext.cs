using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Visita> Visitas { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
