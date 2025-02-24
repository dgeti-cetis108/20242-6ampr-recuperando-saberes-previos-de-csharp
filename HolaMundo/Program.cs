// See https://aka.ms/new-console-template for more information
using HolaMundo;

// ProbarCalculoDeIMC();

var ledesma = new Estudiante();
ledesma.Nombre = "Alberto";
ledesma.PrimerApellido = "Ledesma";
ledesma.SegundoApellido = "Sauceda";
ledesma.NúmeroDeControl = "22456789132";
ledesma.Sexo = SexoEnum.Hombre;


void ProbarCalculoDeIMC()
{
    // 1. declarar un objeto de tipo Persona
    var persona = new Persona();
    Console.WriteLine("Escribe tu peso en kg: ");
    persona.PesoEnKilogramos = float.Parse(Console.ReadLine());

    Console.WriteLine("Escribe tu altura en metros: ");
    persona.AlturaEnMetros = float.Parse(Console.ReadLine());

    Console.WriteLine($"Tu IMC es {persona.CalcularIMC()}");
}