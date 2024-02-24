// See https://aka.ms/new-console-template for more information
using System;

namespace ejercicio5
{
    public class Program
    {
        public static string EliminarEspaciosBlanco(string cadena)
        {
            // Implementación para eliminar espacios en blanco
            // Caso de prueba 1: Cadena vacía
            if (string.IsNullOrEmpty(cadena))
            {
                return cadena;
            }

            // Caso de prueba 2: Cadena sin espacios en blanco
            if (!cadena.Contains(" "))
            {
                return cadena;
            }

            // Caso de prueba 3: Cadena con espacios al inicio y al final
            cadena = cadena.Trim();

            // Caso de prueba 4: Cadena con espacios entre palabras
            cadena = string.Join(" ", cadena.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            // Caso de prueba 5: Cadena con múltiples espacios consecutivos
            cadena = System.Text.RegularExpressions.Regex.Replace(cadena, @"\s+", " ");

            return cadena;
        }

        // static void Main(string[] args)
        // {
        //     // Puedes agregar código para probar tu función aquí si lo deseas
        // }
    }
}
