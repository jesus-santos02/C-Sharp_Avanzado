using System;

namespace ClasesGenericas02
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones<int> miOperacion = new Operaciones<int>();
            Console.WriteLine(miOperacion.Suma(3, 4));
            Console.WriteLine(miOperacion.Resta(3, 4));
            Console.WriteLine(miOperacion.Multiplicacion(3, 4));


            Operaciones<string> miOperacionS = new Operaciones<string>();
            Console.WriteLine(miOperacionS.Suma("Hola", " que tal")); //Se produce concatenacion
            //Console.WriteLine(miOperacionS.Multiplicacion("Hola", " que tal")); Esto da error

        }
    }
}
