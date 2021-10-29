using System;
using System.Collections.Generic;

namespace Colecciones02List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int r = 0;

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);

            //Recorremos con un ciclo For
            for (int i = 0; i < valores.Count; i++)
            {
                //no hay necesidad de hacer Type Cast
                r = valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("-----");

            //Vemos si contiene a determinado elemento
            Console.WriteLine(valores.Contains(5));  
            Console.WriteLine(valores.Contains(13));      

            Console.WriteLine("-----");

            //Obtenemos el indice de un elemento
            Console.WriteLine("El valor (8) esta en el indice: {0}", valores.IndexOf(8));

            Console.WriteLine("-----");

            //Insertamos elemento en un indice
            valores.Insert(2, 23);

            foreach(int valor in valores)
                    Console.WriteLine(valor);

            Console.WriteLine("-----");

            //Eliminamos elemento de un indice
            valores.RemoveAt(2);

            foreach(int valor in valores)
                    Console.WriteLine(valor);

            Console.WriteLine("-----");

            //Eliminamos elemento de la lista
            valores.Remove(8);

            foreach(int valor in valores)
                    Console.WriteLine(valor);

            Console.WriteLine("-----");

            //Invertir sentido de la lista
            valores.Reverse();

            foreach(int valor in valores)
                    Console.WriteLine(valor);

            Console.WriteLine("-----");

            //Ordenamos la lista
            valores.Sort();

            foreach(int valor in valores)
                    Console.WriteLine(valor);

            Console.WriteLine("-----");

            //Creamos una lista para la clase Punto
            List<Punto> listaPuntos = new List<Punto>();

            listaPuntos.Add(new Punto(5, 3));
            listaPuntos.Add(new Punto(7, 8));
            listaPuntos.Add(new Punto(12, 5));
            listaPuntos.Add(new Punto(6, 2));

            foreach(var punto in listaPuntos) Console.WriteLine(punto);

            //No funciona porque no hemos implementado IComparable
            //listaPuntos.Sort();
        }
    }
}
