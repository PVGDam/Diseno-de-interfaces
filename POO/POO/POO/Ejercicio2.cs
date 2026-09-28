using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    internal class Ejercicio2
    {

        class Electrodomestico() {
            private int precio_base;
            private string color;
            private char consumo;
            private string peso;

            public int Precio_base { get; set; } = 100;
            public string Color { get; set; } = "Blanco";
            public char Consumo { get; set; } = 'F';
            public string Peso { get; set; } = "5kg";
        }

    }
}
