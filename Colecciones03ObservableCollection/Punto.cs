using System;
using System.Collections.Generic;

namespace Colecciones03ObservableCollection
{
    public class Punto: IComparable<Punto>
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Punto b)
        {
            double normA = Math.Sqrt(x*x + y*y);   
            double normB = Math.Sqrt(b.x*b.x + b.y*b.y);

            if (normA > normB)
                return 1;
            if(normA < normB)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return string.Format($"X = {x}, Y = {y}");
        }
    }
}