using System;

namespace ObjectLifeTime01
{
    class Program
    {
        static void Main(string[] args)
        {
            //GC: Garbage Collector
            long heapBytes = GC.GetTotalMemory(false);
            System.Console.WriteLine("El heap usa {0} bytes", heapBytes);

            //Obtenemos la cantidad de generaciones
            int maximaGeneraciones = GC.MaxGeneration + 1;
            System.Console.WriteLine("Se tienen {0} generaciones", maximaGeneraciones);

            var prueba = new Prueba(5);
            var prueba1 = new Prueba(10);
            heapBytes = GC.GetTotalMemory(false);
            System.Console.WriteLine("El heap usa {0} bytes", heapBytes);

            //Obtenemos la generacion de un Objeto en particular
            int generacionInstancia = GC.GetGeneration(prueba);
            System.Console.WriteLine("La generacion de la instancia es {0}", generacionInstancia);

            //Forzar la recoleccion de basura
            //Solo hacerlo en situaciones especiales:
            //- Cuando la aplicacion entra a un bloque de codigo que no debe de ser
            //  interrumpida por la recoleccion
            //- Cuando la aplicacion crea una gran cantidad de instancias y se necesita
            //  liberar la mayor cantidad de memoria posible

            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            ////Para recoleccion de una generacion en particular
            //GC.Collect(0);
            //GC.WaitForPendingFinalizers();

        }
    }
}

public class Prueba
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

    //------- Tipos finalizables --------
    //Object tienen un metodo virtual Finalizae()
    //Cuando se hace el override de Finalize tenemos un lugar donde llevar a cabo
    //la limpieza para la clase
    //No se puede invocar directamente, or que es un metodo protegido
    //Lo invoca el recolector de basura antes de eliminar el objeto de la memoria
    //No se puede hacer override de tipos Struct
    //Practicamente nunca haremos esto salvo que tengamos recursos no administradors
    //que necesiten ser eliminados manualmente: PInvoke, COM, memoria no administrada

    ~Prueba()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Aqui liberamos recursos no administrados");
        //Console.Beep(600, 50);
    }
}
