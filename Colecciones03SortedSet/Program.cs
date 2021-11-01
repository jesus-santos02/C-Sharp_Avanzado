using System;
using System.Collections.Generic;

namespace Colecciones03SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Punto> puntos = new SortedSet<Punto>();

            puntos.Add(new Punto(3, 4));
            puntos.Add(new Punto(1, 15));
            puntos.Add(new Punto(7, 4));

            foreach (Punto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");

            puntos.Add(new Punto(1, 2));
            puntos.Add(new Punto(9, 2));

            foreach (Punto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");
        }
    }
}
