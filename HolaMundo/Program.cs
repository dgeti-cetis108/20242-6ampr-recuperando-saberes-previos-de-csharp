// See https://aka.ms/new-console-template for more information
using HolaMundo;

// ProbarCalculoDeIMC();

// crear alumnos
var alumno2 = new Estudiante();
alumno2.Nombre = "Alberto";
alumno2.PrimerApellido = "Ledesma";
alumno2.SegundoApellido = "Sauceda";
alumno2.NúmeroDeControl = "22456789132";
alumno2.Sexo = SexoEnum.Hombre;

var alumno1 = new Estudiante
{
    Nombre = "Juanete",
    PrimerApellido = "Del Pie",
    NúmeroDeControl = "1234567890",
    FechaDeNacimiento = new DateOnly(2002, 2, 26)
};

// imprimir el nombre completo de alumno1
Console.WriteLine(alumno1.NombreCompleto());

var estudiantes = new Estudiante[3]; // matriz o array
var alumnos = new List<Estudiante>(); // lista

// crear una carrera
var programacion = new Carrera
{
    Nombre = "Programación",
    Abreviatura = "PR",
    PlanDeEstudios = 2017
};

// crear un tutor/a
var merlyn = new Docente
{
    Nombre = "Merlyn",
    PrimerApellido = "Ramirez"
};

// crear dos docentes
var docente1 = new Docente
{
    Nombre = "Bidkar",
    PrimerApellido = "Aragón"
};

var docente2 = new Docente
{
    Nombre = "Julio",
    PrimerApellido = "Monroy"
};

// crear tres asignatura
var damios = new Asignatura {Nombre="DAMiOS", Carrera=programacion};
var damandroid = new Asignatura {Nombre="DAMAndroid", Carrera=programacion};
var historia = new Asignatura {Nombre="Historia", Carrera=programacion};

// crear un grupo
var sextoampr = new Grupo
{
    Carrera = programacion,
    Semestre = 6,
    Letra = "A",
    Turno = TurnoEnum.Matutino,
    Tutor = merlyn,
    Periodo = "2024-2",
    Nombre = "6AM-PR"
};

// todo: crear tres calificaciones del alumno1



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