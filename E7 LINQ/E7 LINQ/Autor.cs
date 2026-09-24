using System;
using System.Collections.Generic;
using System.Text;

namespace E7_LINQ
{
    public class Autor
    {
        public int IDAutor { get; set; }
        public string Nombre { get; set; }

        public static List<Autor> Lista = new List<Autor>()
        {
            new Autor{IDAutor= 1, Nombre= "Miguel de Cervantes"},
            new Autor{IDAutor=2, Nombre= "Charles Dickens"},
            new Autor{IDAutor=3, Nombre= "J. R. R. Tolkien"},
            new Autor{IDAutor=4, Nombre= "Antoine de Saint-Exupéry"},
            new Autor{IDAutor=5, Nombre= "Cao Xueqin"},
            new Autor{IDAutor=6, Nombre= "Lewis Car"},
            new Autor{IDAutor=7, Nombre= "Agatha Christie"},
            new Autor{IDAutor=8, Nombre= "C. S. Lewis"},
            new Autor{IDAutor=9, Nombre= "Dan Brown"},
            new Autor{IDAutor=10, Nombre= "J. D. Salinger"},
        };
    }

}
