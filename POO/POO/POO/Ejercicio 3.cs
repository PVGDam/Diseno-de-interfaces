using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    internal class Ejercicio_3
    {
        public class Serie : IEntregable{
            //Sus atributos son título, numero de temporadas, entregado, género y creador.

            private const int TEMPORADAS = 3;
            private const bool ENTREGADO = false;

            private string Titulo { get; set; } = "";
            private int Temporadas { get; set; } = TEMPORADAS;
            private bool Entregado { get; set; } = ENTREGADO;
            private string Genero { get; set; } = "";
            private string Creador { get; set; } = "";

            public Serie() { }

            public Serie(string titulo, string creador) {
                Titulo = titulo;
                Creador = creador;
            }

            public Serie(string titulo, int temporadas, string genero, string creador) {
                Titulo= titulo;
                Temporadas = temporadas;
                Genero = genero;
                Creador= creador;
            }

            public override string ToString()
            {
                return $"Serie -> Titulo: {Titulo}, Numero de temporadas: {Temporadas}, Genero: {Genero}, Creador: {Creador}, Entregado: {Entregado}";
            }

            public void Entregar()
            {
                Entregado = true;
            }

            public void Devolver()
            {
                Entregado = false;
            }

            public bool IsEntregado()
            {
                return Entregado;
            }


        }

        public class Videojuego : IEntregable {
            // título, horas estimadas, entregado, género y compañía
            private const string TITULO = "";
            private const int HORAS = 10;
            private const bool ENTREGADO = false;
            private const string GENERO = "";
            private const string COMPANIA = "";

            private string Titulo { get; set; }
            private int Horas { get; set; } = HORAS;
            private bool Entregado { get; set; } = ENTREGADO;
            private string Genero { get; set; }
            private string Compania { get; set; }

            public Videojuego() { }

            public Videojuego(string titulo, int horas) {
                Titulo = titulo;
                Horas = horas;
            }

            public Videojuego(string titulo, int horas, string genero, string compania) {
                Titulo = titulo;
                Horas = horas;
                Genero = genero;
                Compania = compania;
            }

            public override string ToString()
            {
                return $"Juego -> Titulo: {Titulo}, Horas estimadas: {Horas}, Genero: {Genero}, Compañia: {Compania}, Entregado: {Entregado}";
            }

            public void Entregar()
            {
                Entregado = true;
            }

            public void Devolver()
            {
                Entregado = false;
            }

            public bool IsEntregado()
            {
                return Entregado;
            }
        }

        public interface IEntregable
        {

            void Entregar();

            void Devolver();

            bool IsEntregado();
        }
    }
}
