using System;
using System.Collections;

namespace Colecciones01Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack(); //LIFO: Last In, First Out

            pila.Push("Manzana");
            pila.Push("Fresa");
            pila.Push("Pera");
            pila.Push("Piña");
            pila.Push("Limón");

            //Iteramos
            foreach(var fruta in pila)
                    Console.WriteLine($" {fruta}");

            Console.WriteLine("-----");

            //Obtenemos el ultimo objeto insertado (solo lo observa, no lo saca de la pila)
            Console.WriteLine("Obtenemos el ultimo objeto insertado (solo lo observa, no lo saca de la pila)");
            Console.WriteLine(pila.Peek());
           
            Console.WriteLine("-----");

            //Extraemos elementos de la Cola
            Console.WriteLine("Pop {0}", pila.Pop());
            Console.WriteLine("Pop {0}", pila.Pop());

            Console.WriteLine("-----");

            //Iteramos los elementos que quedan en la Cola
            foreach(var fruta in pila)
                    Console.WriteLine($"{fruta}");

            Console.WriteLine("-----");

            //Conteo de objetos
            Console.WriteLine("La Cola tiene {0} objetos", pila.Count);

            Console.WriteLine("-----");

            //Verificamos la existencia de objetos
            Console.WriteLine(pila.Contains("Pera"));
            Console.WriteLine(pila.Contains("Piña"));
        }
    }
}
