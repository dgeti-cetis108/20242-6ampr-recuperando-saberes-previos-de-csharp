namespace Cibacopa;

public class Jugador
{
    public string Nombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    public CondiciónEnum Condición { get; set; }
    public int Número { get; set; }
}

public enum CondiciónEnum
{
    Local, Nacional, Extranjero
}