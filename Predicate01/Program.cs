using System;
using System.Collections.Generic;

namespace Predicate01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplos con delegados
            //System.Predicate<T> es un delegado generico que representa un metodo que
            //va a definir un criterio y dice si el objeto cumple o no con ese criterio
            //public List<T> FindAll(Predicate<T> match) recorre los ejementos de la lista y 
            //los pasa como parametros al delegado, si este regresa true entonces los pone
            //en la lista de retorno

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 8, 11, 20});

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("------");

            //Indicamos el delegado
            Predicate<int> delegado = new Predicate<int>(Pares);

            //Invocamos metodo
            List<int> numerosPares = numeros.FindAll(delegado);

            foreach (var numero in numerosPares)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("------");

            int valor = numeros.RemoveAll(delegado);

            Console.WriteLine($"Cantidad de objetos eliminados: {valor}");

            Console.WriteLine("------");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }

        static bool Pares(int n) => n % 2 == 0;

        static bool Rango(int n) => n >= 3 && n <= 7;
    }
}
