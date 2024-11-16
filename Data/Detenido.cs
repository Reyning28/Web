using System;

public class Detenido
{
    public int Id {get; set;} 


    public DateTime FechaDetencion {get; set;} = DateTime.Now;

    public string Nombre {get; set;} = "";

     public string Apellido {get; set;} = "";


      public string NumeroPasaporte {get; set;} = "";


      public DateTime FechaNacimiento {get; set;}


      public double Latitud {get; set;}

      public double Longitud {get; set;}

}