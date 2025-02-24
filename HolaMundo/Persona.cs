namespace HolaMundo;

public class Persona
{
    public string Nombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    public DateOnly FechaDeNacimiento { get; set; }
    // propiedades o caracteristicas
    public float PesoEnKilogramos { get; set; }
    public float AlturaEnMetros { get; set; }

    // metodos o eventos o acciones
    public float CalcularIMC()
    {
        return PesoEnKilogramos / (float)Math.Pow(AlturaEnMetros, 2);
    }
}
