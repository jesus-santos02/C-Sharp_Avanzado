using System;

namespace ClasesGenericas01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para puntoI, T trabaja como int
            Punto<int> puntoI = new Punto<int>(3, 4);

            //Para puntoD, T trabaja como double
            Punto<double> puntoD = new Punto<double>(5.6, 7.8);

            //Para puntoF, T trabaja como float
            Punto<float> puntoF = new Punto<float>(3.28f, 9.37f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoF);

            Console.WriteLine("-----");

            //Colocamos el valos de default
            puntoD.Reset();
            Console.WriteLine(puntoD);

            //Verificamos si esta trabajando con entero
            puntoI.FindType();
            puntoD.FindType();
        }
    }
}
