using System;
using System.Linq;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        {
            // Comprobamos si el array esta vacio
            if (array == null || array.Length == 0)
            {
                // Devolvemos 0 en caso de que este vacio
                return 0;
            }

            // Creamos un valor enorme, para que cualquier valor sea menor a el
            int minValue = int.MaxValue;

            // Hacemos un bucle que itera por cada elemento del array comporando,
            // en caso de que uno sea menor, le asignamos dicho valor a la variable
            foreach (var item in array)
            {
                if (minValue>item)
                {
                    minValue = item;
                }
            }

            // Devolvemos la variable
            return minValue;
        }
        public static int[] invertirArray(int[] array)
        {
            // Creamos un nuevo array con el tamaño del array inicial
            int[] arrayInvertido = new int[array.Length];

            // Creamos un contador para añadir los valores adecuadamente
            int contador = 0;

            // Hacemos un bucle for inverso
            for (int i = array.Length-1; i >= 0; i--)
            {
                // Añadimos a la posicion del contador, el valor del array con la posicion inversa
                arrayInvertido[contador] = array[i];

                // Subamos el contador para seguir añadiendo sin poblema
                contador++;
            }

            // Devolvemos el array
            return arrayInvertido;
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {
            // Creamos una variable para la posicion, inicializada en -1,
            // ya que este sera el valor si no encuentra el valor que buscamos
            int posicion = -1;

            // Creamos un bucle for para tener un indicador de posicion
            for (int i = 0; i < array.Length; i++) {

                // Si en la posicion actual del array esta el valor,
                // lo guardamos y rompemos el bucle
                if (array[i] == valor) {
                    posicion = i;
                    break;
                }
            }

            // Devolvemos la posicion del array
            return posicion;
        }

        public static int calcularModa(int[] entrada)
        {
            // Declaramos la variable
            int moda;

            // Comprobamos si el array esta vacio o no, en caso de estarlo
            // ponemos como valor 0, si tiene contenido, le damos a moda el primer valor
            if (entrada == null || entrada.Length == 0)
            {
                moda = 0;
            }
            else {
                moda = entrada[0];
            }

            // Ordenamos el array
            Array.Sort(entrada);

            // Declaramos variables de ayuda para comprobar la moda
            int repetido = 1;
            int repMaximas = 1;

            // Hacemos un bucle por el array para comprobar el moda
            for (int i = 1; i < entrada.Length; i++)
            {
                // Comprobamos si un valor es repetido y en caso de serlo,
                // aumentamos la variable auxiliar, si no lo devolvemos a 0
                if (entrada[i - 1] == entrada[i])
                {
                    repetido++;
                }
                else {
                    repetido = 1;
                }

                // En caso de que un numero se repita más de una vez
                // lo comparamos con el numero maximo de repeticiones y guardamos el valor
                if (repetido == repMaximas && repetido> 1) {
                    moda = entrada[i];
                    repMaximas = repetido;
                }
            }

            // Devolvemos el valor
            return moda;
        }
    }
}
