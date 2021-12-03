using System;

namespace DisposableObject02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si deseamos que los recursos no administrados sean liberados
            //tan pronto como sea posible en lugar de que lo haga el recolector de basura
            //podemos imoplementar la interfaz iDisposable
            //En este caso se toma en cuenta que cuando el usuario deja de usar al objeto,
            //el usuario invoca Dispose(), se libera lo no administrado, pero el objeto
            //sigue existiendo

            using(var prueba = new Prueba(10))
            {
                System.Console.WriteLine(prueba);
            }
        }
    }

    public class Prueba: IDisposable
    {
        private int _a;

        public Prueba(int a)
        {
            _a = a;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}", _a);
        }

        public void Dispose()
        {
            System.Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado");
        }
        
    }
}
