namespace Cibacopa;

public class Equipo
{
    public string Nombre { get; set; }
    public string Sede { get; set; }
    public string Mascota { get; set; }
    public string Patrocinador { get; set; }
    public Entrenador Entrenador { get; set; }
    public List<Jugador> Jugadores { get; set; }
}
