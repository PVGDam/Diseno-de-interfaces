using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Ejercicios
{
    public class Persona
    {
        public string Nombre { get; set;  }

        public int Edad { get; set; }

        public DateTime FechaIngresoEmpresa { get; set; }

        public bool Soltero { get; set; }

        public Persona(string nombre, int edad, DateTime fechaIngesoEmpresa, bool soltero) {
            Nombre = nombre;
            Edad = edad;
            FechaIngresoEmpresa = fechaIngesoEmpresa;
            Soltero = soltero;
        }
    }
}
