using System;
using System.Collections;

namespace Colecciones01Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue(); //FIFO: First In, First Out

            cola.Enqueue("Manzana");
            cola.Enqueue("Fresa");
            cola.Enqueue("Pera");
            cola.Enqueue("Piña");
            cola.Enqueue("Limón");

            //Iteramos
            foreach(var fruta in cola)
                    Console.WriteLine($" {fruta}");

            Console.WriteLine("-----");

            //Obtenemos el primer objeto insertado (solo lo observa, no lo saca de la cola)
            Console.WriteLine(cola.Peek());

            Console.WriteLine("-----");

            //Extraemos elementos de la Cola
            Console.WriteLine("Dequeue {0}", cola.Dequeue());
            Console.WriteLine("Dequeue {0}", cola.Dequeue());

            Console.WriteLine("-----");

            //Iteramos los elementos que quedan en la Cola
            foreach(var fruta in cola)
                    Console.WriteLine($"{fruta}");

            Console.WriteLine("-----");

            //Conteo de objetos
            Console.WriteLine("La Cola tiene {0} objetos", cola.Count);

            Console.WriteLine("-----");

            //Verificamos la existencia de objetos
            Console.WriteLine(cola.Contains("Piña"));
            Console.WriteLine(cola.Contains("Melocoton"));
            
        }
    }
}
