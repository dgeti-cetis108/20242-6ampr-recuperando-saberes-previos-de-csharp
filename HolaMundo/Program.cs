// See https://aka.ms/new-console-template for more information
using HolaMundo;

// 1. declarar un objeto de tipo Persona
var persona = new Persona();
Console.WriteLine("Escribe tu peso en kg: ");
persona.PesoEnKilogramos = float.Parse(Console.ReadLine());

Console.WriteLine("Escribe tu altura en metros: ");
persona.AlturaEnMetros = float.Parse(Console.ReadLine());

Console.WriteLine($"Tu IMC es {persona.CalcularIMC()}");

// Console.WriteLine("Hola Mundo de C# desde VSCode!");
// IMC = PesoKg / (AlturaM * AlturaM)
// PascalCase camelCase
// float imc, alturaM, pesoKg;
// Console.WriteLine("Escribe tu peso en kg: ");
// pesoKg = float.Parse(Console.ReadLine());

// Console.WriteLine("Escribe tu altura en metros: ");
// alturaM = float.Parse(Console.ReadLine());

// imc = pesoKg / (alturaM * alturaM);
// Console.WriteLine($"Tu IMC es {imc}");

