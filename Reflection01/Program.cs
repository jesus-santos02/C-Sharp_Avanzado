using System;



namespace Reflection01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtenemos el tipo
            Type t = Type.GetType("System.Console");

            CaracteristicasTipo(t);
        }

        public static void CaracteristicasTipo(Type tipo)
        {
            //Imprimimos las caracteristicas principales del tipo
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Las caracteristicas que tiene son:"); 
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            Console.WriteLine("Clase base: {0}", tipo.BaseType); 
            Console.WriteLine("Es una Clase: {0},", tipo.IsClass);    
            Console.WriteLine("Abstracta: {0}", tipo.IsAbstract); 
            Console.WriteLine("Sellada: {0}", tipo.IsSealed); 
            Console.WriteLine("Generica: {0}", tipo.IsGenericTypeDefinition);
        }
    }
}
