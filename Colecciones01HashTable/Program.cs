using System;
using System.Collections;

namespace Colecciones01HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable miTabla = new Hashtable();

            //Adicionamos elementos
            miTabla.Add(132, "Osado");
            miTabla.Add(145, "Hello");
            miTabla.Add(23, "Playa");
            miTabla.Add(567, "Programacion");
            miTabla.Add(12456, "C#");

            //Mostramos los elementos
            foreach (DictionaryEntry elemento in miTabla)
                     Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

            //Si intentamos colocar un elemento con llave repetida, provocará una excepcion
            //miTabla.Add(567, "Hola que tal");

            Console.WriteLine("-----");

            //Cantidad de elementos
            Console.WriteLine(miTabla.Count);

            Console.WriteLine("-----");

            //Obtenemos el elemento de determinada llave
            Console.WriteLine(miTabla[132]);
            Console.WriteLine(miTabla[23]);

            Console.WriteLine("-----");

            //Colocamos un elemento en una llave
            miTabla[12456] = "C-Sharp";

            foreach (DictionaryEntry elemento in miTabla)
                     Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

            Console.WriteLine("-----");

            //Verificamos si hay un elemento
            Console.WriteLine(miTabla.Contains(78));

            //Eliminamos un elemento
            miTabla.Remove(145);

            foreach (DictionaryEntry elemento in miTabla)
                     Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

            Console.WriteLine("-----");

            //Podemos recorrer las llaves
            foreach (int llave in miTabla.Keys)
                     Console.WriteLine(llave);

            Console.WriteLine("-----");

            //Podemos recorrer los valores
            foreach (int llave in miTabla.Keys)
                     Console.WriteLine(llave);

            Console.WriteLine("-----");

        }
    }
}
