using System;
using System.Collections.Generic;

namespace Colecciones02LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           //LinkedList es mas eficiente que List cuando se necesita borrar e insertar elementos
           //a la lista constantemente, ya que esta constituida por nodos
           LinkedList<int> numeros = new LinkedList<int>();
           numeros.AddFirst(6);

           foreach (var item in new int[]{8,5,3,5,4,6,7,0,4})
           {
               numeros.AddFirst(item);
           }

           foreach (var numero in numeros)
           {
               Console.WriteLine(numero);
           }   

           Console.WriteLine("-------");  

           for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
           {
               Console.WriteLine(nodo.Value);
           }       

        }
    }
}
