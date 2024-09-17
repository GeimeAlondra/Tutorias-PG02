
using System;

namespace MiNuevoPrograma
{
    class Listas    
    {
        static void Main(string[] args)
        {
            //Crea un programa que permita al usuario agregar nombres a una lista hasta que ingrese "salir".
            //Luego imprime todos los nombres ingresados.
            List<string> nombres = new List<string>();
            string nombre;
            do
            {
                Console.WriteLine("Ingresa un nombre o escribe 'salir', para terminar");
                nombre = Console.ReadLine();
                if(nombre.ToLower() != "salir")
                {
                    nombres.Add(nombre);
                }
            }
            while (nombre.ToLower() != "salir");
            Console.WriteLine($"Los nombres ingresados son: \n");
            foreach(string n in nombres)
            {
                Console.WriteLine(n);
            }
        }
    }
}
