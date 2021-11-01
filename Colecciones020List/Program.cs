using System;
using System.Collections.Generic;

namespace Colecciones020List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de objetos de nuestra clase
            //ADICION EXPLICITA
            List<Punto> puntos = new List<Punto>
            {
               new Punto(2, 3),
               new Punto(5, 23),     
               new Punto(7, 9)
            };

            foreach (Punto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");

            //Adicionamos un Punto
            puntos.Add(new Punto(15, 8));

            foreach (Punto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");

            //Insertamos un Punto en un indice determinado
            puntos.Insert(2, new Punto(21, 12));

            foreach (Punto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");

            //Crear un arreglo a partir de una lista
            Punto[] arregloPuntos = puntos.ToArray();

            for (var i = 0; i < arregloPuntos.Length; i++)
            {
                Console.WriteLine(arregloPuntos[i]);
            }


        }
    }
}
