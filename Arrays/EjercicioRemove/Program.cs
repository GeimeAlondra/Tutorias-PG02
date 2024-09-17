namespace EjercicioRemove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea una lista de nombres en C#. Luego, elimina uno o más nombres especificados por el
            // usuario. Finalmente, muestra la lista actualizada.

            List<string> nombres = new List<string> { "Alondra", "Wendy", "Sonia", "Luis", "Alex", "Ívan" };

            Console.WriteLine("\nLista de nombres:");
            foreach (string nom in nombres)
            {
                Console.WriteLine(nom);
            }

            Console.WriteLine("\nIngrese el nombre que quiere remover: ");
            string[] nombreRemovido = Console.ReadLine().Split(' ');
            foreach (string nombre in nombreRemovido)
            {
                if (nombres.Contains(nombre))
                {
                    nombres.Remove(nombre);
                    Console.WriteLine($"El nombre '{nombre}' ha sido removido.");
                }
                else
                {
                    Console.WriteLine($"El nombre '{nombre}' no esta en la lista.");
                }
            }

            Console.WriteLine("\nLista actualizada:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
