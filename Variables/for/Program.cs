using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa que pida al usuario un número
            // y muestre la tabla de multiplicar de ese número

            Console.WriteLine("Escribe un número: ");

            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine("---TABLA---");
            for(int i = 1; i <= 10;)
            {
                int resultado = valor * i;
                Console.WriteLine(valor + " x " + i + " = " + valor * i);
                i++;
            }
        }
    }
}