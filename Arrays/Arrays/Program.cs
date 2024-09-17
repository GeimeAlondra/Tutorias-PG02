using System;

namespace MiNuevoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que defina un arreglo de enteros con 5 números,
            //luego suma todos los elementos del arreglo e imprime el resultado en pantalla.
            int[] numeros = { 1, 2, 3, 4, 5 }; 
            //1+2
            //suma+3
            //suma+4
            //suma+5 = 15
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            Console.WriteLine($"La suma de los elementos es: {suma}" );
        }
    }
}
