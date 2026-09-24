//Ejercicio 1. 

using E7_LINQ;

Console.WriteLine("EJERCICIO 1: ");
Console.WriteLine();
// Creamos nuestro array de 100 numeros
int[] numeros = Enumerable.Range(1,100).ToArray();

// Obtenemos solo los divisibles entre 7
var divisiblesDe7 = numeros.Where(n => n % 7 == 0).ToArray();

// Mostramos todos mediante un bucle
Console.Write("Estos son los numeros divisibles entre 7: ");
for (int i = 0; i < divisiblesDe7.Length; i++)
{
    Console.Write($"{divisiblesDe7[i]}, ");
}

Console.WriteLine();

// Creamos el agrupamiento segun si son pares o impares utilizando .GroupBy
var agrupamientoPorParidad = divisiblesDe7.GroupBy(n => n % 2 == 0);

// Hacemos un foreach para recorrer el agrupamiento por cada grupo
foreach (var grupo in agrupamientoPorParidad)
{
    // Operación ternaria para que muestre un texto en vez de True o False
    Console.Write($"En el grupo de {(grupo.Key ? "impares" : "pares")} hay {grupo.Count()}: ");

    // Creamos un foreach para recorrer cada elemento de cada grupo
    foreach (var numero in grupo)
    {
        Console.Write($"{numero}, ");
    }

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("------------------------------------------------");

// Ejercicio 2:

Console.WriteLine();
Console.WriteLine("EJERCICIO 2: ");
Console.WriteLine();

//●	Mostrar en consola los 3 libros con más ventas.
var mayorVentas3 = Libro.Lista.OrderByDescending(l => l.Ventas).Take(3).ToList();

Console.WriteLine("Los 3 libros con más ventas son: ");
foreach (var libro in mayorVentas3)
{
    Console.WriteLine($"- {libro.Titulo} con {libro.Ventas} ventas.");
}

Console.WriteLine();

//●	Mostrar en consola los 3 libros con menos ventas.
var menoresVentas3 = Libro.Lista.OrderBy(l => l.Ventas).Take(3).ToList();

Console.WriteLine("Los 3 libros con menos ventas son: ");
foreach (var libro in menoresVentas3)
{
    Console.WriteLine($"- {libro.Titulo} con {libro.Ventas} ventas.");
}

Console.WriteLine();

//●	Mostrar en consola el código y el nombre de los autores cuyo nombre tenga menos de 10 caracteres (eliminando espacios en blanco). .

Console.WriteLine();

//●	Mostrar en consola los libros agrupados por el autor.
var autorLibro = Libro.Lista.GroupBy(l => l.IDAutor);

foreach (var grupo in autorLibro)
{
    Console.WriteLine($"Los libros escritos por {Autor.Lista[grupo.Key-1].Nombre} son: ");

    foreach (var libro in grupo)
    {
        Console.WriteLine($"- {libro.Titulo}.");
    }
    Console.WriteLine();

}

//●	Mostrar en consola los libros publicados hace menos de 50 años.
var librosHaceMenos50 = Libro.Lista.Where(l => 2026 - l.FechaPublicacion < 50);

Console.WriteLine("Libros publicados hace menos de 50 años: ");
foreach (var libro in librosHaceMenos50)
{
    Console.WriteLine($"- {libro.Titulo}.");
    
}

Console.WriteLine();

//●	Mostrar en consola el libro más viejo.
var libroViejo = Libro.Lista.OrderBy(l => l.FechaPublicacion).First();

Console.WriteLine($"El libro más viejo es: {libroViejo.Titulo}.");

Console.WriteLine();

//●	Mostrar en consola los libros que comiencen con "El".