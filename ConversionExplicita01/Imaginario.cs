using System;

namespace ConversionExplicita01
{
    class Imaginario
    {
        public double B { get; set; }
        
        public Imaginario() { }

        public Imaginario(double b)
        {
            B = b;
        }

        public override string ToString()
        {
            return string.Format($"{B}i");
        }
    }
}
