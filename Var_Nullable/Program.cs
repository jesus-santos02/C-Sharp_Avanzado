using System;

namespace Var_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion implicita de variables
            //Solo se permiten en variables locales
            //No se pueden usar en atributos
            //No se pueden usar como tipos de retorno
            //Se debe colocar un valor en el momento de declaracion
            //No confundir con Var o Variant de otros lenguajes, es fuertemente tipificado
            //Se usan en LINQ donde un query puede dar un resultado dinamicamente creado

            var a = 5;
            var b = "Hola a todos";
            var c = 15.3686;
            var d = false;
            //var e = null; NO PUEDE SER NULL
            //d = 58; Una vez inicializada, no se puede cambiar de tipo
            var f = c;

            //Imprimimos
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);

            //Usamos reflexion para conocer el tipo
            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("b es {0}", b.GetType().Name);
            Console.WriteLine("c es {0}", c.GetType().Name);
            Console.WriteLine("d es {0}", d.GetType().Name);
            Console.WriteLine("f es {0}", f.GetType().Name);

            /*Tipos Nulleables*/
            //Los tipos por valor no pueden tener un null
            //int valor = null; NO SE PUEDE

            //Los tipos nulleables pueden representar los mismos valores mas el valor de null
            //Son utiles en bases de datos, pues podemos encontrar columnas no definidas
            //Para definirlo usamos ?
            //Pero realmente lo que hacemos es crear una instancia de System.Nullable<T>

            int? dato = 5;
            Console.WriteLine(dato);
            dato = null;
            Console.WriteLine(dato);

            double? precio = null;
            precio = 6.7;
            Console.WriteLine(precio);

            //El string no es nulleable ya que es un tipo por referencia
            //string? nombre = "Kevin"; NO SE PUEDE

            //Podemos saber si tiene o no valor
            //precio = null;

            if(precio.HasValue)
                Console.WriteLine("Tiene valor {0}", precio.Value);
            else
                Console.WriteLine("No tiene valor");

            //El operador ?? nos permite asignar un valor en caso de que tenga null
            double? numero = Allocator() ?? 6.7;
            Console.WriteLine(numero);


        }

        static double? Allocator()
        {
            return 4.5;
            //return null;
        }
    }
}
