using Cibacopa;

// crear un torneo
var miTorneo = new Torneo();
miTorneo.Nombre = "Claudia Reuchón";
miTorneo.Edición = 2025;
miTorneo.Inicia = new DateOnly(2025,3,9);
miTorneo.Finaliza = new DateOnly(2025,6,30);

// todo: crear 4 equipos
var equipo1 = new Equipo {Nombre="Frayles", Sede="Guasave"};
var equipo2 = new Equipo {Nombre="Caballeros", Sede="Culiacán"};
var equipo3 = new Equipo {Nombre="Ostioneros", Sede="Guaymas"};
var equipo4 = new Equipo {Nombre="Zonkeys", Sede="Tijuana"};

// todo: crear 3 encuentros para cada equipo como 1ra vuelta
var encuentro12 = new Encuentro
{
    Fecha=new DateTime(2025,02,14,8,0,0),
    EquipoDeCasa = equipo1,
    EquipoVisitante = equipo2
};
var encuentro13 = new Encuentro
{
    Fecha=new DateTime(2025,02,16,8,0,0),
    EquipoDeCasa = equipo1,
    EquipoVisitante = equipo3
};
var encuentro14 = new Encuentro
{
    Fecha=new DateTime(2025,02,18,8,0,0),
    EquipoDeCasa = equipo1,
    EquipoVisitante = equipo4
};
var encuentro34 = new Encuentro
{
    Fecha=new DateTime(2025,02,14,8,0,0),
    EquipoDeCasa = equipo3,
    EquipoVisitante = equipo4
};
var encuentro32 = new Encuentro
{
    Fecha=new DateTime(2025,02,20,8,0,0),
    EquipoDeCasa = equipo3,
    EquipoVisitante = equipo2
};
var encuentro24 = new Encuentro
{
    Fecha=new DateTime(2025,02,18,8,0,0),
    EquipoDeCasa = equipo2,
    EquipoVisitante = equipo4
};

// todo: crear 3 arbritos
var arbitro1 = new Arbitro {Nombre="Pinky", Apellidos="Y Cerebro"};
var arbitro2 = new Arbitro {Nombre="Dora", Apellidos="La Exploradora"};
var arbitro3 = new Arbitro {Nombre="Calamarino", Apellidos="Elegante"};

// todo: crear 5 jugadores por cada equipo
var jugador1 = new Jugador
{
    Nombre = "Sergio",
    PrimerApellido = "El Bailador",
    Número = 23,
    Condición = CondiciónEnum.Local
};
var jugador2 = new Jugador { Nombre = "Juan", PrimerApellido = "Pérez", Número = 10, Condición = CondiciónEnum.Nacional };
var jugador3 = new Jugador { Nombre = "Luis", PrimerApellido = "Gómez", Número = 7, Condición = CondiciónEnum.Local };
var jugador4 = new Jugador { Nombre = "Carlos", PrimerApellido = "Martínez", Número = 5, Condición = CondiciónEnum.Extranjero };
var jugador5 = new Jugador { Nombre = "Pedro", PrimerApellido = "Rodríguez", Número = 2, Condición = CondiciónEnum.Nacional };
var jugador6 = new Jugador { Nombre = "Javier", PrimerApellido = "García", Número = 11, Condición = CondiciónEnum.Local };
var jugador7 = new Jugador { Nombre = "Rafael", PrimerApellido = "Díaz", Número = 9, Condición = CondiciónEnum.Extranjero };
var jugador8 = new Jugador { Nombre = "Miguel", PrimerApellido = "Hernández", Número = 4, Condición = CondiciónEnum.Nacional };
var jugador9 = new Jugador { Nombre = "Alejandro", PrimerApellido = "López", Número = 8, Condición = CondiciónEnum.Local };
var jugador10 = new Jugador { Nombre = "Francisco", PrimerApellido = "González", Número = 6, Condición = CondiciónEnum.Extranjero };
var jugador11 = new Jugador { Nombre = "Daniel", PrimerApellido = "Sánchez", Número = 3, Condición = CondiciónEnum.Nacional };
var jugador12 = new Jugador { Nombre = "Gabriel", PrimerApellido = "Romero", Número = 12, Condición = CondiciónEnum.Local };
var jugador13 = new Jugador { Nombre = "Andrés", PrimerApellido = "Torres", Número = 1, Condición = CondiciónEnum.Extranjero };
var jugador14 = new Jugador { Nombre = "Julio", PrimerApellido = "Cruz", Número = 15, Condición = CondiciónEnum.Nacional };
var jugador15 = new Jugador { Nombre = "Eduardo", PrimerApellido = "Morales", Número = 14, Condición = CondiciónEnum.Local };
var jugador16 = new Jugador { Nombre = "Fernando", PrimerApellido = "Alonso", Número = 20, Condición = CondiciónEnum.Local };
var jugador17 = new Jugador { Nombre = "Adrián", PrimerApellido = "García", Número = 18, Condición = CondiciónEnum.Nacional };
var jugador18 = new Jugador { Nombre = "Cristian", PrimerApellido = "Hernández", Número = 22, Condición = CondiciónEnum.Extranjero };
var jugador19 = new Jugador { Nombre = "David", PrimerApellido = "López", Número = 16, Condición = CondiciónEnum.Local };
var jugador20 = new Jugador { Nombre = "Iván", PrimerApellido = "Martínez", Número = 19, Condición = CondiciónEnum.Nacional };

// todo: crear 1 entrenador por cada equipo
var entrenador1 = new Entrenador {Nombre="Leono de los Thundercats",EntrenaDesde=new DateOnly(1980,01,01)};
var entrenador2 = new Entrenador {Nombre="Muuuuuunrrrraaaaaaa el inmortaaaaalllll",EntrenaDesde=new DateOnly(1180,01,01)};
var entrenador3 = new Entrenador {Nombre="Capitan Centella", EntrenaDesde=new DateOnly(1990,07,14)};
var entrenador4 = new Entrenador {Nombre="Jhonny G. Bravo", EntrenaDesde=new DateOnly(2000,12,12)};
