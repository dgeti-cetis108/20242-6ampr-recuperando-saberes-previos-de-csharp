namespace HolaMundo;

public class Estudiante : Persona
{
    public string NúmeroDeControl { get; set; }
    public string Generación { get; set; }
    public SexoEnum Sexo { get; set; } // H, M
    public List<Calificacion> Calificaciones { get; set; } = new List<Calificacion>();
}

public enum SexoEnum
{
    Hombre, Mujer
}
