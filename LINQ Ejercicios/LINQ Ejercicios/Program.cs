using LINQ_Ejercicios;

int[] numeros = Enumerable.Range(1,20).ToArray();
int[] numeros2 = Enumerable.Range(1,20).ToArray();

var numerosImpares = numeros2.Where(n => n % 2 == 1).ToList();

var numerosMultiplosDe3 = numeros2.Where(n => n % 3 == 0).ToList();

// Lista de personas
var personas = new List<Persona> {
    new Persona("Eduardo", 20, new DateTime(2021, 1, 2), true),
    new Persona("Blanca", 26, new DateTime(2020, 1, 2), false),
    new Persona("Juan", 23, new DateTime(2020, 1, 2), true),
    new Persona("Jaime", 12, new DateTime(2020, 1, 2), true),
};

// Personas solteras
var personasSolteras = personas.Where(p => p.Soltero).ToList();

foreach (var persona in personasSolteras) {
    Console.WriteLine($"{persona.Nombre} esta Solter@");
}

// Personas mayores a 25 y no solteras
var personasMayoresDe25NoSolteros = personas.Where(p => p.Edad >= 25 && !p.Soltero);

foreach (var persona in personasMayoresDe25NoSolteros) {
    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} y no esta solter@");
}

// Como obtener la primera de la lista
var primeraPersona = personas.First();
var primeraPersona2 = personas.FirstOrDefault();

// Crear una lista de strings
var paises = new List<string>();

// La primera persona mayor de 25 y la primera persona mayor de 100
var primeraPersonaMenorDe25 = personas.First(p => p.Edad > 25);
var primeraPersonaMayorDe100 = personas.FirstOrDefault(p => p.Edad > 100);

if (primeraPersonaMayorDe100 is null) {
    Console.WriteLine("No hay ninguna persona mayor de 100");
}

// La primera persona mayor a 23
var primeraPersonaDe23 = personas.FirstOrDefault(p => p.Edad == 23);

if (primeraPersonaDe23 is null) {
    Console.WriteLine("No hay ninguna persona que tenga 23 años");
}

// La primera persona mayor a 90
var primeraPersonaMayorDe90 = personas.FirstOrDefault(p => p.Edad > 90);

if (primeraPersonaMayorDe90 is null) {
    Console.WriteLine("No hay ninguna persona mayor de 90");
}

// Personas ordenadas por edad ascendentemente
foreach (var persona in personas.OrderBy(p => p.Edad))
{
    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
}

// Personas ordenadas por edad descendentemente
foreach (var persona in personas.OrderByDescending(p => p.Edad))
{
    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
}

// Personas ordenadas por nombre
foreach (var persona in personas.OrderBy(p => p.Nombre))
{
    Console.WriteLine($"{persona.Nombre}");
}

int[] notas = { 85, 42, 95, 68, 70 };

// Ordena de manera descendente
var numerosOrdenados = notas.OrderByDescending(n => n).ToArray();

// Personas solo por nombre y edad
var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad}).ToList();

// Obten los numeros duplicados
var numeros4 = Enumerable.Range(1, 5).ToList();
var numerosDuplicados = numeros4.Select(n => n*2).ToList();

// Fechas de ingresos
var fechasDeIngresos = personas.Select(p => new { fechasDeIngresos = p.FechaIngresoEmpresa }).ToList();

// Personas mayores de edad
var personasMayoresDeEdad = personas.Where(p => p.Edad >= 18).Select(p => new { Nombre = p.Nombre, MayorDeEdad = p.Edad });

foreach (var persona in personasMayoresDeEdad) {
    Console.WriteLine($"Persona mayor de edad {persona.Nombre}");
}


// Obten el minimo
var minimo = numeros4.Min();
var edadMinima = personas.Min(p => p.Edad);

// Calcula la edad media
var promedio = numeros.Average();
var edadMedia = personas.Average(p => p.Edad);

// Obten el minimo y maximo de edad de las personas
var personasConLaEdadMasPequeña = personas.MinBy(p => p.Edad);
var personasConLaEdadMasGrande = personas.MaxBy(p => p.Edad);

// Cuenta cuantas personas mayores a 20 hay
var personasMayoresDe20 = personas.Count(p => p.Edad > 20);

// Calcula la suma total de las edades de todas las personas
var personasEdadTotal = personas.Sum(p => p.Edad);

// CUANTIFICADORES UNIVERSALES: solo devuelven booleans
// .All .Any .Contains

// Verifica si todas las personas son mayores de edad
var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);

// Verifica si alguna persona se llama Juan
var existeJuan = personas.Any(p => p.Nombre == "Juan");

// TAKE y SKIP

var primeros10Numeros = numeros.Take(10).ToList();
var ultimos10Numeros = numeros.TakeLast(10).ToList();

// Si queremos saltarnos n numeros usaremos la funcion SKIP

var segundoLoteDe10 = numeros.Skip(10).ToList();
var penultimoLoteDe10 = numeros.SkipLast(10).ToList();

// El metodo takewhile nos retornara una lista con los vaolres
// hasta que la condicion marcada se cumpla
// El resultado de esa expresion
// sera una coleccion con los valores 0, 1, 4

int[] numeros9 = { 0, 1, 4, 5, 2, 6, 3, 9, 7, 8 };
var primerosMenoresQue5 = numeros9.TakeWhile(n => n < 5);

// El metodo skipwhile funciona de una manera similar
// solo que ignorara los vaolres que cumplan con la condicion indicada
// hasta que dejen de cumplirla

var saltarMenorque5 = numeros9.SkipWhile(n => n < 5);

// AGRUPANDO POR GROUP BY

// El GroupBy sirve para agrupar objetos cuando un campo repite su valor 
var agrupamientoPorSolteria = personas.GroupBy(p => p.Soltero);

foreach (var grupo in agrupamientoPorSolteria) {
    Console.WriteLine($"Grupo de las personas donde Soltero = {grupo.Key} (Total: {grupo.Count()})");

    foreach (var persona in grupo) {
        Console.WriteLine($"- {persona.Nombre}");
    }

}

int[] numeros7 = { 1, 2, 3, 1, 1, 6 };

// Eliminar repetidos
var numerosSinRepeticion = numeros7.Distinct();
var personasSinRepeticion = personas.DistinctBy(p => p.Nombre);


// Dividir una coleccion en varias chunks
int[] numeros8 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var resultado = numeros8.Chunk(3);