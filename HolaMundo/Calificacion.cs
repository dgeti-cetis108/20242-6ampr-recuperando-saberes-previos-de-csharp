namespace HolaMundo;

public class Calificacion
{
    public Grupo Grupo { get; set; }
    public Asignatura Asignatura { get; set; }
    public Docente Docente { get; set; }
    public Estudiante Estudiante { get; set; }
    public float Parcial1 { get; set; }
    public float Parcial2 { get; set; }
    public float Parcial3 { get; set; }
}