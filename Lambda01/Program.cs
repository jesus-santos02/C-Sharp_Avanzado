using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una Expresion Lambda es una funcion anonima cuya ejecucion depende del
            //contexto en el que se encuentra
            //solo se pueden usar donde se haga uso de un metodo anonimo o un delegado
            //fuertemente tipificado

            List<int> numeros = Enumerable.Range(1, 10).ToList();

            //Lista de parametros => instrucciones a realizar
            //El tipo de los parametros puede ser implicito o explicito: (int i)

           /* List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            foreach (var numero in numerosPares)
            {
                Console.WriteLine(numero);
            }*/

            Console.WriteLine("------");

            List<int> numPares = numeros.FindAll((i)=>
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Un Par");
                    return true;
                }
                else
                {
                    Console.WriteLine("Un Impar");
                    return false;
                }      
            });

            foreach (var numero in numPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
