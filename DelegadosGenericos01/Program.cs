using System;

namespace DelegadosGenericos01
{
    public delegate void miDelegado<T>(T p);
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxis 1
            //Registramos y usamos el string
            miDelegado<string> delCadena = HandlerString;
            delCadena("Hola a todos");

            //Sintaxis 2
            //Registramos y usamos el double
            miDelegado<double> delDoble = new miDelegado<double>(HandlerDouble);
            delDoble(4.57);
        }

        static void HandlerString(string p)
        {
            Console.WriteLine($"Uso String como tipo, y el valor es: {p}");
        }

        static void HandlerDouble(double p)
        {
            Console.WriteLine($"Uso Double como tipo, y el valor es: {p}");
        }
    }
}
