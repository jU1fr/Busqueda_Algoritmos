using System;

namespace BusquedaAlgoritmos
{
    public class BusquedaBinaria
    {
        public int Buscar(int[] arreglo, int valorBuscado)
        {
            Array.Sort(arreglo); // Ordenar el arreglo para aplicar búsqueda binaria
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (arreglo[medio] == valorBuscado)
                {
                    return medio;
                }
                else if (arreglo[medio] < valorBuscado)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }
            return -1; // Retorna -1 si no lo encuentra
        }
    }
}
