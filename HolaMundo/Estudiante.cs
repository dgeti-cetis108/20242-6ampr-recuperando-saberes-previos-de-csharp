namespace HolaMundo;

public class Estudiante : Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string NúmeroDeControl { get; set; }
    public string Generación { get; set; }
    public SexoEnum Sexo { get; set; } // H, M
}

public enum SexoEnum
{
    Hombre, Mujer
}
