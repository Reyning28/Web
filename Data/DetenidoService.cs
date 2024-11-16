
public class DetenidoService
{
    private readonly AppDbContext _context;

    public DetenidoService(AppDbContext context)
    {
        _context = context;
    }

    // Método para obtener las detenciones por fecha
    public IEnumerable<Detenido> ObtenerDetencionesPorFecha(DateTime fecha)
    {
        // Convertir la fecha a un rango desde las 00:00:00 hasta las 23:59:59 del mismo día
        var fechaInicio = fecha.Date; // 00:00:00
        var fechaFin = fecha.Date.AddDays(1).AddMilliseconds(-1); // 23:59:59.999

        return _context.Detenidos
            .Where(d => d.FechaDetencion >= fechaInicio && d.FechaDetencion <= fechaFin)
            .ToList();
    }
}
