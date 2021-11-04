using System;

namespace MetodosAnonimos03
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto(5, 6);

            //Creamos el metodo anonimo para el delegado
            punto.mensaje += delegate()
            {
                Console.WriteLine("Estoy desde el metodo anonimo");
            };

            Console.WriteLine(punto);

            punto.mensaje();

            //Adicionamos otro metodo anonimo
            punto.mensaje += delegate()
            {
                Console.WriteLine("Este es otro metodo anonimo");
            };
        }
    }
}
