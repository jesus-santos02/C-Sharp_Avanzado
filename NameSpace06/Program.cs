using System;
using System.Configuration;

namespace NameSpace06
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettingsReader lector = new AppSettingsReader();
            
            string nombre = (string)lector.GetValue("Nombre", typeof(string));

            System.Console.WriteLine($"Mi nombre es {nombre}");

        }
    }
}
