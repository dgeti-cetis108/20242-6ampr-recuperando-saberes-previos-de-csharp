namespace HolaMundo
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public int Semestre { get; set; }
        public int HorasSemestrales { get; set; }
        public Carrera Carrera { get; set; }
    }
}
