

// Promedio de Notas:Pide al usuario que ingrese tres notas. Calcula e imprime el
// promedio de las notas y determina si el promedio es suficiente para aprobar
// (promedio >= 60).

Console.WriteLine("Ingrese la primera nota: ");
double nota1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la segunda nota: ");
double nota2 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la tercera nota: ");
double nota3 = Double.Parse(Console.ReadLine());

double promedio = (nota1 + nota2 + nota3) / 3;

if(promedio >= 60)
{
    Console.WriteLine($"Has aprobado con promedio de: {promedio}");
}
else
{
    Console.WriteLine($"Has reprobado con promedio de: {promedio}");
}