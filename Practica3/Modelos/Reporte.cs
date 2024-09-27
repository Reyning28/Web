using System;
using System.ComponentModel.DataAnnotations;

class Reporte
{
   public Guid Id { get; set; } // Cambiamos a Guid y generamos un nuevo Id

    [Required(ErrorMessage = "El campo Fecha es requerido")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Descripción es requerido")]
    [MinLength(10, ErrorMessage = "La descripción debe tener al menos 10 caracteres")]
    public string Descripcion { get; set; } = "";

    [Range(0, double.MaxValue, ErrorMessage = "El costo estimado debe ser un valor positivo")]
    public double CostoEstimado { get; set; } = 0;

    public int Muertos { get; set; } = 0;
    public int Heridos { get; set; } = 0;
    public int VehiculosInvolucrados { get; set; } = 0;
}
