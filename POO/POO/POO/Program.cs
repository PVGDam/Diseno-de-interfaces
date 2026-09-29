using System.Reflection.Metadata.Ecma335;
using static POO.Ejercicio2;
using static POO.Ejercicio_3;

public class Empleado {

    private string nombre;
    public string Nombre { get { return nombre; } set { nombre = value; } }

    public Empleado(string nombre)
    {
        Nombre = nombre;
    }

    public override string ToString() {
        return $"Empleado {Nombre}";
    }

}

public class Operario : Empleado {

    public Operario(string nombre) : base(nombre)
    {
    }

    public override string ToString()
    {
        return base.ToString() + " -> Operario";
    }
}

public class Directivo : Empleado {

    public Directivo(string nombre) : base(nombre)
    {
    }

    public override string ToString()
    {
        return base.ToString() + " -> Directivo";
    }
}

public class Oficial : Operario {

    public Oficial(string nombre) : base(nombre)
    {
    }
    public override string ToString()
    {
        return base.ToString() + " -> Oficial";
    }
}

public class Tecnico : Operario {

    public Tecnico(string nombre) : base(nombre)
    {
    }
    public override string ToString()
    {
        return base.ToString() + " -> Tecnico";
    }
}

class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado("Rafa");

        Operario operario = new Operario("Alfonso");

        Directivo directivo = new Directivo("Mario");

        Oficial oficial = new Oficial("Luis");

        Tecnico tecnico = new Tecnico("Pablo");

        Console.WriteLine(empleado);
        Console.WriteLine(directivo);
        Console.WriteLine(operario);
        Console.WriteLine(oficial);
        Console.WriteLine(tecnico);

        Electrodomestico[] electrodomesticos = new Electrodomestico[10];

        electrodomesticos[0] = new Electrodomestico();
        electrodomesticos[1] = new Electrodomestico(200, 15);
        electrodomesticos[2] = new Electrodomestico(300, "NEGRO", 'A', 25);

        electrodomesticos[3] = new Lavadora();
        electrodomesticos[4] = new Lavadora(400, 35);
        electrodomesticos[5] = new Lavadora(500, "ROJO", 'B', 45, 40);

        electrodomesticos[6] = new Television();
        electrodomesticos[7] = new Television(600, 20);
        electrodomesticos[8] = new Television(50, true, 700, 30, "AZUL", 'C');

        electrodomesticos[9] = new Electrodomestico(150, "GRIS", 'F', 10);

        foreach (var electrodomestico in electrodomesticos)
        {
            Console.WriteLine(electrodomestico.PrecioFinal());
        }

        var agrupamientoPorElectrodomestico = electrodomesticos.GroupBy(e => e.GetType());

        foreach (var grupo in agrupamientoPorElectrodomestico)
        {
            Console.WriteLine($"Precio de {grupo.Key}: ");

            foreach (var electrodomestico in grupo)
            {
                Console.WriteLine(electrodomestico.Precio_base);

            }

        }

        Serie[] series = new Serie[5];

        series[0] = new Serie();
        series[1] = new Serie("Breaking Bad", "Vince Gilligan");
        series[2] = new Serie("The Office", 9, "Comedia", "Greg Daniels");
        series[3] = new Serie("Dark", 3, "Ciencia ficción", "Baran bo Odar");
        series[4] = new Serie("Friends", 10, "Comedia", "David Crane");


        Videojuego[] videojuegos = new Videojuego[5];

        videojuegos[0] = new Videojuego();
        videojuegos[1] = new Videojuego("Minecraft", 100);
        videojuegos[2] = new Videojuego("God of War", 40, "Acción", "Santa Monica Studio");
        videojuegos[3] = new Videojuego("FIFA 24", 80, "Deportes", "Electronic Arts");
        videojuegos[4] = new Videojuego("The Legend of Zelda", 60, "Aventura", "Nintendo");
    }
}