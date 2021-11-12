using System;
using System.Collections;

namespace Exception01
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera caldera = new Caldera("Mastic-O", 20);

            try
            {
                for(int i = 0; i < 10; i++)
                caldera.Trabajar(20);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Sucedió la excepcion");
                Console.WriteLine($"Este es el metodo: {e.TargetSite}");
                Console.WriteLine($"Con este mensaje de error: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
                Console.WriteLine($"Clase donde ocurrió: {e.TargetSite.DeclaringType}");
                Console.WriteLine($"Tipo de miembro: {e.TargetSite.MemberType}");
                Console.WriteLine($"Stack: {e.StackTrace}");
                Console.WriteLine($"Help Link: {e.HelpLink}");
                
                if (e.Data != null)
                {
                    foreach(DictionaryEntry informacion in e.Data)
                    Console.WriteLine($"{informacion.Key} {informacion.Value}");
                }
            }
        }
    }
}
