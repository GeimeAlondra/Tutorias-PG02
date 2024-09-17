using System;

namespace Intercambio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intercambiar Valores de Dos Variables: Escribe un programa que pida al usuario dos números y luego intercambie sus valores. 
            // Muestra los valores antes y después del intercambio.

            Console.Write("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nValores antes de convertirse: num1: {num1} y num2: {num2}");
           
            int num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine($"\nValores despues de convertirse: num1: {num1} y num2: {num2}");
        }
    }
}
