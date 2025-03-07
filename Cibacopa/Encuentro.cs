namespace Cibacopa;

public class Encuentro
{
    public DateTime Fecha { get; set; }
    public Equipo EquipoDeCasa { get; set; }
    public Equipo EquipoVisitante { get; set; }
    public int PuntosDeCasa { get; set; }
    public int PuntosDeVisitante { get; set; }
    public List<Arbitro> Arbitros { get; set; }
}
