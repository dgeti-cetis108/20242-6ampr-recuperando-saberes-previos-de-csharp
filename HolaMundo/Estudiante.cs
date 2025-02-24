namespace HolaMundo;

public class Estudiante : Persona
{
    public string NúmeroDeControl { get; set; }
    public string Generación { get; set; }
    public SexoEnum Sexo { get; set; } // H, M
}

public enum SexoEnum
{
    Hombre, Mujer
}
