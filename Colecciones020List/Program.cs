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
        }
    }
}
