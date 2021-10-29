using System;
using System.Collections;

namespace Colecciones01SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList listaOrdenada = new SortedList();

            //Adicionamos objetos a la lista
            listaOrdenada.Add(358, "Pedro");
            listaOrdenada.Add(98, "Martín");
            listaOrdenada.Add(111, "Josefa");
            listaOrdenada.Add(23, "Jesus");
            listaOrdenada.Add(45, "Antonio");

            //Iteramos
            foreach (DictionaryEntry elemento in listaOrdenada)
            {
                Console.WriteLine($"({elemento.Key}-->{elemento.Value})");
            }

            Console.WriteLine("-----");

            //Cantidad de elementos
            Console.WriteLine("La Lista Ordenada tiene {0} objetos", listaOrdenada.Count);

            Console.WriteLine("-----");

            //Verificamos la existencia de objetos
            Console.WriteLine(listaOrdenada.Contains(358));
            Console.WriteLine(listaOrdenada.Contains(15));   

            Console.WriteLine(listaOrdenada.ContainsKey(111));
            Console.WriteLine(listaOrdenada.ContainsKey(13));

            Console.WriteLine(listaOrdenada.ContainsValue("Jesus"));
            Console.WriteLine(listaOrdenada.ContainsValue("Luis"));

            Console.WriteLine("-----");

            //Obtenemos por Indice
            Console.WriteLine(listaOrdenada.GetByIndex(2));
            Console.WriteLine(listaOrdenada.GetKey(2));

        }
    }
}
