using System;

namespace BusquedaAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 10, 5, 3, 8, 15, 7, 20, 1 };
            Console.WriteLine("Valores en el arreglo:");
            Console.WriteLine(string.Join(", ", arreglo));

            Console.Write("Ingrese el valor que desea buscar: ");
            int valorBuscado = int.Parse(Console.ReadLine());

            // Búsqueda Secuencial
            BusquedaSecuencial busquedaSecuencial = new BusquedaSecuencial();
            int posicionSecuencial = busquedaSecuencial.Buscar(arreglo, valorBuscado);

            if (posicionSecuencial != -1)
            {
                Console.WriteLine($"Búsqueda Secuencial: Valor encontrado en la posición {posicionSecuencial}");
            }
            else
            {
                Console.WriteLine("Búsqueda Secuencial: Valor no encontrado.");
            }

            // Búsqueda Binaria
            BusquedaBinaria busquedaBinaria = new BusquedaBinaria();
            int posicionBinaria = busquedaBinaria.Buscar(arreglo, valorBuscado);

            if (posicionBinaria != -1)
            {
                Console.WriteLine($"Búsqueda Binaria: Valor encontrado en la posición {posicionBinaria}");
            }
            else
            {
                Console.WriteLine("Búsqueda Binaria: Valor no encontrado.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
