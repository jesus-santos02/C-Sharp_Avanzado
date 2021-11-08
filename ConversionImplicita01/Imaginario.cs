using System;

namespace ConversionImplicita01
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

        public static implicit operator Complejo( Imaginario imaginario)
        {
            Complejo temp = new Complejo(0, (int)imaginario.B);

            return temp;
        }
    }
}
