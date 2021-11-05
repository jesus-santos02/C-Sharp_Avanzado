using System;

namespace ConversionExplicita01
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

    }
}
