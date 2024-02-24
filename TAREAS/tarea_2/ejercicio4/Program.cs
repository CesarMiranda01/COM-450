// See https://aka.ms/new-console-template for more information
using System;

namespace ejercicio4
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     // Puedes agregar código de ejemplo aquí si es necesario
        // }

        public static int ContarOcurrenciasSubcadena(string cadena, string subcadena)
        {
            // Implementa aquí la lógica para contar las ocurrencias de la subcadena
            // Puedes utilizar, por ejemplo, el método IndexOf y un bucle para contar las ocurrencias.
            int contador = 0;
            int indice = cadena.IndexOf(subcadena);
            while (indice != -1)
            {
                contador++;
                indice = cadena.IndexOf(subcadena, indice + 1);
            }
            return contador;
        }
    }
}
