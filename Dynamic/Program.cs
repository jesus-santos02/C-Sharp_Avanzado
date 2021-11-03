using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic se puede ver como una forma de System.Object
            //en el sentido de que cualquier valor se puede asignar a dynamic
            //La diferenci es que no es fuertemente tipificado
            //Se le puede asignar cualquier tipo al inicio y posteriormente asignar otro

            dynamic a = 5;
            Console.WriteLine("Tipo {0}, valor: {1}", a.GetType().Name, a);

            a = "Hola a todos";
            Console.WriteLine("Tipo {0}, valor: {1}", a.GetType().Name, a);

            //A diferencia de Object, en dynamic se conoce el tipo hasta el
            //tiempo de ejecucion
            //Dynamic se puede usar como ti de retorno
            //No se puede usar en expresiones lambda o en metodos anonimos
            //Puede resultar util si nos comunicamos con bibliotecas COM

            
        }
    }
}
