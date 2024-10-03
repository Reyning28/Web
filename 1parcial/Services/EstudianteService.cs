//2023-1110
using System.Collections.Generic;
using System.Linq;

public class EstudianteService
{
    private List<Estudiante> estudiantesTarde = new List<Estudiante>();

    public List<Estudiante> GetEstudiantesTarde()
    {
        return estudiantesTarde;
    }

    public void RegistrarTardanza(Estudiante estudiante)
    {
        estudiante.FechaHoraTardanza = DateTime.Now;
        estudiantesTarde.Add(estudiante);
    }
}
//2023-1110