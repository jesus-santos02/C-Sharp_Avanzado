using System;
using System.Collections;

namespace Colecciones01ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList palabras = new ArrayList();
            int r = 0;

            //Podemos adicionar con rango
            palabras.AddRange(new string[] {"Hola", "como", "estan?" });//Se puede pasar un arreglo como parametro

            Console.WriteLine($"Cantidad de elementos en el ArrayList es {palabras.Count}");

            //Recorremos con un ciclo For
            for (int i = 0; i < palabras.Count; i++)
            {
                Console.Write($" {palabras[i]}");
            }

            Console.WriteLine("\n------");

            //Otra forma de adicionar elementos
            palabras.Add("Bien y tu?");

            foreach (string palabra in palabras)
            {
                Console.Write($" {palabra}");
            }

            Console.WriteLine("\n------");

            ArrayList valores = new ArrayList();
            valores.Add(7);
            valores.Add(5);
            valores.Add(3);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("\n------");

            //Verificamos si existe un elemento en la coleccion
            Console.WriteLine(valores.Contains(7));
            Console.WriteLine(valores.Contains(17));

            Console.WriteLine("\n------");

            //Insertamos en un indice en particular
            valores.Insert(2, 4);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("\n------");

            //Removemos
            valores.Remove(3);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("\n------");

            //Removemos en un determinado indice
            valores.RemoveAt(0);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("\n------");
        }
    }
}
