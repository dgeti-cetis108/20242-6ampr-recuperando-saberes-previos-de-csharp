namespace Cibacopa;

public class Torneo
{
    public int Edición { get; set; } // 2025
    public string Nombre { get; set; } // El Profe Güeron
    public DateOnly Inicia { get; set; }
    public DateOnly Finaliza { get; set; }
    public List<Encuentro> Encuentros { get; set; }
}
