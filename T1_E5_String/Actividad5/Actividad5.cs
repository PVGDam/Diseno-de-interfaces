using System;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {
            // Creamos una variable donde guardaremos el resultado
            string frase = "";

            // Hacemos un bucle for para iterar por todo el array
            for (int i = 0; i < vs.Length; i++)
            {   
                // Añadimos el valor del array a la frase
                frase += vs[i];
            }

            // Devolvemos el resultado
            return frase;
        }

        public static string devolverStringOrdenado(string[] vs)
        {
            // Ordenamos el array
            Array.Sort(vs);

            // Creamos una variable donde guardaremos el resultado
            string frase = "";

            // Hacemos un bucle for para iterar por todo el array
            for (int i = 0; i < vs.Length; i++)
            {
                // Añadimos el valor del array a la frase
                frase += vs[i];
            }

            // Devolvemos el resultado
            return frase;

        }

        public static int contarCaracter(string[] vs, char v)
        {
            // Creamos una variable para contar
            int contador = 0;

            // Creamos un bucle que vaya por cada string del array
            for (int i = 0; i < vs.Length; i++)
            {
                // Creamos un bucle que vaya por cada caracter de cada string
                for (int j = 0; j < vs[i].Length; j++)
                {
                    // Comprobamos que sea el caracter que queremos y lo sumamos
                    if (vs[i][j] == v) contador++;
                }

            }

            // Devolvemos el contador
            return contador;
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            // Creamos un array que tendra las sumas, del tamaño correcto
            int[] totalArray = new int[vs1.Length];

            // Utilizamos for ya que necesitamos un indicador
            for (int i = 0; i < vs1.Length; i++) {
                // Sumamos cada valor de los arrays y los añadimos al nuevo
                totalArray[i] = vs1[i] + vs2[i];
            }
            
            // Devolvemos el array
            return totalArray;

        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            // Creamos un array que tendra las sumas, del tamaño correcto
            int[] totalArray = new int[vs1.Length];

            // Utilizamos for ya que necesitamos un indicador
            for (int i = 0; i < vs1.Length; i++)
            {
                // Multiplicamos cada valor de los arrays y los añadimos al nuevo
                totalArray[i] = vs1[i] * vs2[i];
            }

            // Devolvemos el array
            return totalArray;
        }

        public static bool isPalindromo(string entrada)
        {
            // Creamos la variable por defecto en true, ya que "" es palindromo
            Boolean palindromo = true;

            // Sanitizamos la entrada para evitar mayusculas y espacios
            string entradaSanitizada = new string(entrada.ToLower().Where(char.IsLetter).ToArray());

            // Hacemos un bucle que itera por cada caracter
            for (int i = 0; i < entradaSanitizada.Length; i++)
            {
                // Si el caracter en la posicion i no es igual al de la posición contraria
                // ponemos el palindromo como falso
                if (entradaSanitizada[i] != entradaSanitizada[^(i+1)]) {
                    palindromo = false;
                }
            }

            // Otra forma de hacerlo seria haciendo un reverse a la cadena y compararlas
            // bool result = entradaSanitizada.SequenceEqual(entradaSanitizada.Reverse());

            // Devolvemos el palindromo
            return palindromo;
        }

        public static int contarPalabras(string entrada)
        {
            // Creamos una variable para contar las palabras
            int contador = 0;

            // Hacemos un bucle con indicador para iterar por cada caracter
            for (int i = 0; i < entrada.Length; i++) {
                // Comparamos el caracter con un espacio y sumamos
                if (entrada[i] == ' ') contador++;
            }

            // Devolvemos el valor
            return contador;
        }

        public static int contarCaracteres(string entrada)
        {
            // Creamos una variable para contar los caracteres
            int contador = 0;

            // Hacemos un bucle con indicador para iterar por cada caracter
            for (int i = 0; i < entrada.Length; i++)
            {
                // Comprobamos que el caracter no es un espacio y sumamos
                if (entrada[i] != ' ') contador++;
            }

            // Devolvemos el valor
            return contador;
        }
    }
}
