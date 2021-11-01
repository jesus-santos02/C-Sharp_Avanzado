using System;
using System.Collections.Generic;

namespace Colecciones03Queue_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Punto> puntos = new Queue<Punto>();

            puntos.Enqueue(new Punto(3, 4));
            puntos.Enqueue(new Punto(7, 5));
            puntos.Enqueue(new Punto(9, 11));
            puntos.Enqueue(new Punto(1, 4));

            foreach (Punto punto  in puntos)
            {
                Console.WriteLine(punto);
            }

            Console.WriteLine("-----");

            //Hacemos un Peek
            Console.WriteLine(puntos.Peek());

            Console.WriteLine("-----");

            //Hacemos Dequeue
            Console.WriteLine("Dequeue--> {0}", puntos.Dequeue());
            Console.WriteLine("Dequeue--> {0}", puntos.Dequeue());

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
