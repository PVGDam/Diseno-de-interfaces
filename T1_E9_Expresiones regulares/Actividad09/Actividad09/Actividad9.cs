using System;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Actividad09
{
    public class Actividad9
    {
        static void Main(string[] args)
        {
        }

        public static bool cadenaContenedora(string cadena, string valor)
        {
            var result = Regex.Match(cadena, valor);

            return result.Success;
        }

        public static bool numeroEntero(string v)
        {
            var result = Regex.Match(v, "^\\d+$");

            return result.Success;
        }

        public static bool isSpanish(string telefono)
        {
            var result = Regex.Match(telefono, "\\d+$");

            return result.Success;
        }

        public static bool isCorrectEmail(string email)
        {
            var result = Regex.Match(email, "^[\\w.+]+@[\\w.]+\\.\\w+$");

            return result.Success;
        }

        public static bool numeroPositivo(string v)
        {
            var result = Regex.Match(v, @"^\d+$");

            return result.Success;
        }

        public static bool isOctal(string v)
        {
            var result = Regex.Match(v, @"^[0-7]+$");

            return result.Success;
        }

        public static bool dni(string v)
        {
            var result = Regex.Match(v, @"^\d{8}\w$");

            return result.Success;
        }

        public static bool fechaFormat(string v)
        {
            var result = Regex.Match(v, @"^\d{2}/\d{2}/\d{4}$");

            return result.Success;
        }

        public static bool isBinario(string v)
        {
            var result = Regex.Match(v, @"^[0-1]+$");

            return result.Success;
        }
    }
}
