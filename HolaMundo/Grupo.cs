namespace HolaMundo
{
    public class Grupo
    {
        public string Nombre { get; set; } // todo: solo lectura 6AM-PR
        public TurnoEnum Turno { get; set; }
        public string Letra { get; set; }
        public int Semestre { get; set; }
        public string Periodo { get; set; }
        public Carrera Carrera { get; set; }
        public Docente Tutor { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }
}

public enum TurnoEnum
{
    Matutino, Vespertino, Nocturno
}