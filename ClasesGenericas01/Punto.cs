using System;

namespace ClasesGenericas01
{
    public class Punto<T>
    {
        private T x;
        private T y;

        public Punto(T px, T py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", x, y);
        }

        public void Reset()
        {
            x = default(T);
            y = default(T);
        }

        public void FindType()
        {
            if(typeof(T) == typeof(int))
                Console.WriteLine("Trabajo como entero");
            else if(typeof(T) == typeof(double))
                Console.WriteLine("Trabajo como doble");
            else
                Console.WriteLine("Trabajo otro tipo");
        }
    }
}