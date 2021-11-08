using System;

namespace ConversionExplicita01
{
    class Program
    {
        static void Main(string[] args)
        {
            Real real = new Real();
            Imaginario imaginario = new Imaginario();
            Complejo complejo = new Complejo(9, 2);

            real = (Real)complejo;
            imaginario = (Imaginario)complejo;

            Console.WriteLine(real);
            Console.WriteLine(imaginario);
        }
    }
}
