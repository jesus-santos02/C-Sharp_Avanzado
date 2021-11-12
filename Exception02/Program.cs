using System;

namespace Exception02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excepciones de aplicaciones
            //Necesitamos 4 entidades
            //  Una clase que representa los detalles de la excepcion
            //  Un miembro que lanza una instancia de la excepcion
            //  Un bloque de codigo que invoca el codigo que puede generar la excepcion
            //  Un bloque que va a cachar o procesar la excepcion si es que ocurre

            //V1, V2, V3
            Caldera caldera = new Caldera("Mastic-O", 20);
            Random rnd = new Random();

            while (caldera.Funciona)
            {
                try
                {
                    caldera.Trabajar(rnd.Next(10));
                }
                /*catch (System.Exception e)
                {
                    System.Console.WriteLine($"El mensaje: {e.Message}");
                }*/
                catch (CalderaException e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    System.Console.WriteLine($"{e.Message}");
                    System.Console.WriteLine($"{e.Momento}");
                    System.Console.WriteLine($"{e.Causa}");
                }
            }

        }
    }
}
