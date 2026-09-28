using System.Reflection.Metadata.Ecma335;

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
    }
}