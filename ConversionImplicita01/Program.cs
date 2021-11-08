using System;

namespace ConversionImplicita01
{
    class Program
    {
        static void Main(string[] args)
        {
            Real real = new Real(3.7);
            Imaginario imaginario = new Imaginario(12.4);
            Complejo complejo = new Complejo();

            //complejo = real;
            complejo = imaginario;

            Console.WriteLine(complejo);

        }
    }
}
