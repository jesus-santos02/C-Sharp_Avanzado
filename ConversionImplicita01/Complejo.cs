using System;

namespace ConversionImplicita01
{
    class Complejo
    {
       public int A { get; set; }
       public int B { get; set; }

       public Complejo(){ }
       
       public Complejo(int a, int b)
       {
           A = a;
           B = b;
       }

       public override string ToString()
       {
           return string.Format($"{A} + {B}i");           
       }
       
       public static explicit operator Real( Complejo complejo)
       {
           Real temp = new Real();
           temp.A = complejo.A;

           return temp;
       }

       public static explicit operator Imaginario( Complejo complejo)
       {
           Imaginario temp = new Imaginario();
           temp.B = complejo.B;

           return temp;
       }
    }
}
