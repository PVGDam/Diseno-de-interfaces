using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;


namespace POO
{
    internal class Ejercicio2
    {

        public class Electrodomestico {
            public int Precio_base { get; private set; }
            private string Color { get; set; }
            private char Consumo { get; set; }
            private int Peso { get; set; }

            private const int PRECIO_BASE_DEFECTO = 100;
            private const string COLOR_DEFECTO = "BLANCO";
            private const char CONSUMO_DEFECTO = 'F';
            private const int PESO_DEFECTO = 5;

            // Forma correcta
            //private int Precio_base { get; set; } = PRECIO_BASE_DEFECTO;
            //private string Color { get; set; } = COLOR_DEFECTO
            //private char Consumo { get; set; } = CONSUMO_DEFECTO
            //private int Peso { get; set; } = PESO_DEFECTO

            public Electrodomestico()
            {
                Precio_base = PRECIO_BASE_DEFECTO;
                Color = COLOR_DEFECTO;
                Consumo = CONSUMO_DEFECTO;
                Peso = PESO_DEFECTO;
            }

            public Electrodomestico(int precio_base, int peso){
                Precio_base = precio_base;
                Color = COLOR_DEFECTO;
                Consumo = CONSUMO_DEFECTO;
                Peso = peso;
            }

            public Electrodomestico(int precio_base, string color, char consumo, int peso) {
                Precio_base=precio_base;
                Color = ComprobarColor(color);
                Consumo = ComprobarConsumoEnergia(consumo);
                Peso = peso;
            }

            private static char ComprobarConsumoEnergia(char letra) {
                var letraMayus = Char.ToUpper(letra);


                if (letraMayus == 'A' || letraMayus == 'B' || letraMayus == 'C' || letraMayus == 'D' || letraMayus == 'E' || letraMayus == 'F')
                {
                    return letraMayus;
                }
                else return CONSUMO_DEFECTO;
            }

            private static string ComprobarColor(string color) {
                color = color.ToUpper();

                if (color == "BLANCO" || color == "NEGRO" || color == "ROJO" || color == "AZUL" || color == "GRIS")
                {
                    return color;
                }
                else return COLOR_DEFECTO;
            }

            public virtual int PrecioFinal() {
                var precioPeso = 10;
                Dictionary<char, int> consumos = new Dictionary<char, int> {
                    { 'A', 100 },
                    { 'B', 80 },
                    { 'C', 60 },
                    { 'D', 50 },
                    { 'E', 30 },
                    { 'F', 10 }
                };


                if (this.Peso > 19 && this.Peso < 50)
                {
                    precioPeso = 50;
                }
                else if (this.Peso >= 50 && this.Peso < 80)
                {
                    precioPeso = 80;
                }
                else if (this.Peso >= 80) {
                    precioPeso = 100;
                }

                return Precio_base + (precioPeso + consumos[Consumo]);
            }
        }

        public class Lavadora : Electrodomestico { 
        
            private int Carga { get; set; }
            private const int CARGA_POR_DEFECTO = 5;

            public Lavadora(int precio_base, string color, char consumo, int peso, int carga): base(precio_base, color, consumo, peso) {
                Carga = carga;
            }

            public Lavadora(): base()
            {
                Carga = CARGA_POR_DEFECTO;
            }

            public Lavadora(int precio_base, int peso) : base(precio_base, peso) {
                Carga = CARGA_POR_DEFECTO;
            }

            public Lavadora(int carga) : base() {
                Carga = carga;
            }

            public override int PrecioFinal() {
                if (Carga > 30) {
                    return base.PrecioFinal() + 50;
                } return base.PrecioFinal();
            }

        }

        public class Television : Electrodomestico {
        
            private int Resolucion { get; set; }
            private Boolean SintonizadoTDT { get; set; }
            private const int RESOLUCION_POR_DEFECTO = 20;
            private const Boolean SINTONIZADORTDT_POR_DEFECTO = false;

            public Television(): base() {
                Resolucion = RESOLUCION_POR_DEFECTO;
                SintonizadoTDT = SINTONIZADORTDT_POR_DEFECTO;
            }

            public Television(int precio_base, int peso) : base(precio_base, peso)
            {
                Resolucion = RESOLUCION_POR_DEFECTO;
                SintonizadoTDT = SINTONIZADORTDT_POR_DEFECTO;

            }

            public Television(int resolucion, bool sintonizador, int precio_base, int peso, string color, char consumo) : base(precio_base, color, consumo, peso) {
                Resolucion = resolucion;
                SintonizadoTDT = sintonizador;
            }

            public override int PrecioFinal() {
                var precioActual = base.PrecioFinal();

                if (Resolucion > 40) {
                    precioActual = (int)(precioActual * 1.3);
                }

                if (SintonizadoTDT) { precioActual = precioActual + 50; }

                return precioActual;
            }


        }

    }
}
