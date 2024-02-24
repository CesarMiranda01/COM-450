// See https://aka.ms/new-console-template for more information
using System;

namespace ejercicio2
{
    class Program
    {
        public static double CalcularAreaCirculo(double radio)
        {
            if (radio < 0)
            {
                throw new ArgumentException("El radio no puede ser negativo.");
            }

            if (radio == 0)
            {
                throw new ArgumentException("El radio no puede ser cero.");
            }

            return Math.PI * Math.Pow(radio, 2);
        }
    }
}

