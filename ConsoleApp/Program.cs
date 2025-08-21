// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Personas persona = new Personas();
persona.Id = 1;
persona.Nombre = "Juan Pérez";
persona.Estatura = 1.75m;
persona.Vive = false;
persona.Fecha = DateTime.Now;
persona.Estado = new Estados() { Id= 1, Nombre ="Viudo"};
public class Personas
{    // Propiedades de la clase Personas
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Estatura { get; set; }
    public bool Vive { get; set; }
    public DateTime Fecha { get; set; }

    public Estados? Estado { get; set; } // Relación con Estados

}

public class Estados
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Tipo { get; set; }
    public int Edad { get; set; }
    public int PersonasId { get; set; } // Relación con Personas
    public Personas? Persona { get; set; }
}

public class Estudiantes : Personas
{
    public string? Carnet { get; set; }
    public int Semestre { get; set; }


}

    

