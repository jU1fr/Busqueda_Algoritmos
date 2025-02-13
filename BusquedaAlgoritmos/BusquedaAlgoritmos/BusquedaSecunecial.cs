namespace BusquedaAlgoritmos
{
    public class BusquedaSecuencial
    {
        public int Buscar(int[] arreglo, int valorBuscado)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valorBuscado)
                {
                    return i; // Retorna la posición si lo encuentra
                }
            }
            return -1; // Retorna -1 si no lo encuentra
        }
    }
}
