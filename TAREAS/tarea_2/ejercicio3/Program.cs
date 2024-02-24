// See https://aka.ms/new-console-template for more information
// Program.cs
using System;

namespace ejercicio3
{
    public class Program
    {
        // static void Main(string[] args)
        // {
        // Tu código principal puede ir aquí si es necesario
        // }
        
        public static bool EsNumeroPrimo(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("El número no puede ser negativo.", nameof(n));
            }

            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
