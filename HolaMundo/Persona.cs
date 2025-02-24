namespace HolaMundo;

public class Persona
{
    // propiedades o caracteristicas
    public float PesoEnKilogramos { get; set; }
    public float AlturaEnMetros { get; set; }

    // metodos o eventos o acciones
    public float CalcularIMC()
    {
        return PesoEnKilogramos / (float)Math.Pow(AlturaEnMetros, 2);
    }
}
