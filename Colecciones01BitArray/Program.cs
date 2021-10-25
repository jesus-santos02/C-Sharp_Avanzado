using System;
using System.Collections;

namespace Colecciones01BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray myArreglo = new BitArray(new byte[]{1, 2, 4, 8, 16});//cada elemento es un byte

            //Cantidad de elementos, 5 bytes * 8 = 40 bytes
            Console.WriteLine(myArreglo.Count);
            MuestraArreglo(myArreglo);

            Console.WriteLine("-----");

            //Obtenemos un bit en particular
            Console.WriteLine(myArreglo.Get(0));

            //Ponemos un bit en particular
            myArreglo.Set(7, true);
            MuestraArreglo(myArreglo);
            Console.WriteLine(myArreglo.Get(7));

            Console.WriteLine("-----");

            //Clonamos el bitArray
            BitArray arreglo2 = (BitArray)myArreglo.Clone();
            MuestraArreglo(arreglo2, "Arreglo2");

            //Invertimos el arreglo, NOT
            arreglo2.Not();
            MuestraArreglo(arreglo2);

            Console.WriteLine("-----");

            //Creamos otro arreglo
            BitArray arreglo3 = new BitArray(new byte[]{5, 7, 9, 13, 15});
            MuestraArreglo(arreglo3, "Arreglo3");
            Console.WriteLine("-----");

            //Hacemos OR entre arreglos
            arreglo3.Or(myArreglo);
            MuestraArreglo(myArreglo, "MyArreglo");
            MuestraArreglo(arreglo3, "Arreglo3");
            Console.WriteLine("=====");

            //Hacemos AND entre arreglos
            MuestraArreglo(myArreglo, "MyArreglo");
            MuestraArreglo(arreglo3, "Arreglo3");
            Console.WriteLine("=====");
            arreglo3.And(myArreglo); //El resultado se guarda en arreglo3
            MuestraArreglo(arreglo3, "Arreglo3");
            Console.WriteLine("=====");

            //Hacemos XOR entre arreglos
            MuestraArreglo(myArreglo, "MyArreglo");
            MuestraArreglo(arreglo3, "Arreglo3");
            Console.WriteLine("=====");
            arreglo3.Xor(myArreglo); //El resultado se guarda en arreglo3
            MuestraArreglo(arreglo3, "Arreglo3");
            Console.WriteLine("=====");

        }

        private static void MuestraArreglo(BitArray arreglo, string nombre = "")
        {
            int c = 0;
            Console.Write("\t", nombre);

            foreach (bool b in arreglo)
            {
                if(b)
                    Console.Write("1");
                else
                    Console.Write("0");
                
                c++;
                if(c % 8 == 0)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
