using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cálculo de Conversión de Temperatura: Escribe un programa que pida al usuario una temperatura en
            // grados Celsius y la convierta a Fahrenheit.
            // Usa la fórmula: (0 °C × 9/5) + 32

            Console.WriteLine("Ingrese una temperatura en grados Celsius: ");

            float celsius = float.Parse(Console.ReadLine());

            float fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Tu temperatura en Fahrenheit es: {fahrenheit}");
        }
    }
}