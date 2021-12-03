using System;
using System.Diagnostics;
using System.Reflection;

namespace AppDomain02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cuando un ejecutable inicia, el CLR lo coloca en el AppDomain de default del
            //proceso que lo alberga
            //Podemos tener acceso a ese AppDomain de default

            AppDomain AD = AppDomain.CurrentDomain;

            System.Console.WriteLine();
            //Imprimimos la informacion que nos proporciona
            System.Console.WriteLine($"Nombre del Dominio: {AD.FriendlyName}");
            System.Console.WriteLine($"ID del Dominio en el proceso: {AD.Id}");
            System.Console.WriteLine($"Directorio Base del Dominio: {AD.BaseDirectory}");

            //Verificamos si es el AppDomain de default
            if(AD.IsDefaultAppDomain())
                System.Console.WriteLine("Es el AppDomain de default");
            else    
                System.Console.WriteLine("No es el AppDomain de default");

            System.Console.WriteLine("-----------");

            //Podemos encontrar los Assemblies que el AppDomain usa
            Assembly[] assemblies = AD.GetAssemblies();

            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine($"Nombre: {asm.GetName().Name} - Version: {asm.GetName().Version}");
            }
        }
    }
}
