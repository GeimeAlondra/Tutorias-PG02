using System;

namespace Bucle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determina si un número es par o impar.

            Console.WriteLine("Ingrese un número: ");

            int valor = int.Parse(Console.ReadLine());

            if(valor % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }
    }
}