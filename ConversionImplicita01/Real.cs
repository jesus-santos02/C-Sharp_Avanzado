using System;

namespace ConversionImplicita01
{
    class Real
    {
        public double A { get; set; }
        
        public Real() { }

        public Real(double a)
        {
            A = a;
        }

        public override string ToString()
        {
            return string.Format($"{A}");
        }

        public static implicit operator Complejo(Real real)
        {
            Complejo temp = new Complejo((int)real.A, 0);

            return temp;
        }

    }
}
