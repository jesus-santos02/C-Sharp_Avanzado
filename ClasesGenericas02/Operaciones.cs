namespace ClasesGenericas02
{
    public class Operaciones<T>
    {
        //Usamos dynamic, ya que el tipo se checa en tiempo de ejecucion y no en compilacion
        public T Suma(T a, T b)
        {
            dynamic da = a, db = b;
            return da + db;
        }

        public T Resta(T a, T b)
        {
            dynamic da = a, db = b;
            return da - db;
        }

        public T Multiplicacion(T a, T b)
        {
            dynamic da = a, db = b;
            return da * db;
        }

        public T Division(T a, T b)
        {
            dynamic da = a, db = b;
            return da / db;
        }
    }

    //La siguiente clase genera un error en tiempo de compilacion, ya que una clase generica
    //al trabajar con cualquier tipo, el compilador no sabe si el tipo implementa
    //los operadores + - * /

    /*
        public class Operaciones<T>
    {
        public T Suma(T a, T b)
        {
            return a + b;
        }

        public T Resta(T a, T b)
        {
            return a - b;
        }

        public T Multiplicacion(T a, T b)
        {
            return a * b;
        }

        public T Division(T a, T b)
        {
            return a / b;
        }
    }
    */
}