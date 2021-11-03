using System;

namespace MetodosGenericos01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Swap<int>(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);

            Console.WriteLine("-----");

            double m = 98.7;
            double n = 73.23;
            Console.WriteLine("m = {0}, n = {1}", m, n);
            Swap<double>(ref m, ref n);
            Console.WriteLine("m = {0}, n = {1}", m, n);

            Console.WriteLine("-----");

           string a = "Osado";
            string b = "Gracias";
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Swap<string>(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            Console.WriteLine("-----");


        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temporal;
            
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
