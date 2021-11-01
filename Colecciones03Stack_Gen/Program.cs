using System;
using System.Collections.Generic;

namespace Colecciones03Stack_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Punto> puntos = new Stack<Punto>();

            puntos.Push(new Punto(3, 4));
            puntos.Push(new Punto(7, 5));
            puntos.Push(new Punto(9, 11));
            puntos.Push(new Punto(1, 4));

            foreach (Punto punto  in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");

            //Hacemos un Peek
            Console.WriteLine(puntos.Peek());

            Console.WriteLine("-----");

            //Hacemos Pop
            Console.WriteLine("Pop--> {0}", puntos.Pop());
            Console.WriteLine("Pop--> {0}", puntos.Pop());

            Console.WriteLine("-----");

            foreach (Punto punto  in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");

            //Hacemos un Peek
            Console.WriteLine(puntos.Peek()); 
        }
    }
}
