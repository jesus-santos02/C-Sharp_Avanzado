using System;

namespace Action_Func02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action nos permite crear delegados en el momento, para un maximo de 16 parametros
            //pero el tipo de retorno debe ser void            
            string m = "Hola a todos";
            int n = 5;

            Action<string, int> delAction = new Action<string, int>(RepeatMessage);

            //Invocamos el delegado
            delAction(m, n);

            //Func funciona similar a Action, pero permite tipo de retorno
            int x = 5;
            int y = 9;

            //Definimos el delegado, el ultimo tipo listado es siempre el tipo de retorno
            Func<int, int, int> delFunc = Suma;
            Console.WriteLine(delFunc(x, y));

        }

        static void RepeatMessage(string message, int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(message);
            }
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }
    }
}
