using System;

namespace Exception01
{
    public class Caldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public int Temperatura { get => tempActual; set => tempActual = value;}
        public string Marca { get => marca; set => marca = value; }
        public bool Funciona { get => funciona; }

        public Caldera(string marca, int temp)
        {
            this.marca = marca;
            this.tempActual = temp;
        }

        //Hacemos trabajar la caldera sin usar excepciones
        public void Trabajar(int aumento)
        {
            if (funciona == false)
            {
                System.Console.WriteLine($"La Caldera {marca} esta descompuesta");
            }
            else
            {
                tempActual += aumento;
                System.Console.WriteLine($"La temperatura actual es {tempActual}");

                if (tempActual > tempMax)
                {
                    System.Console.WriteLine($"{marca} superó la temperatura actual, tiene {tempActual}");
                    tempActual = tempMax;
                    funciona = false;

                    //Lanzamos una excepcion y tenemos una variable para la instancia
                    Exception ex = new Exception(string.Format($"La caldera {marca} se sobrecalienta"));
                    ex.HelpLink = "http://www.google.com.do";

                    ex.Data.Add("Momento:", string.Format($"Ocurrio en {DateTime.Now}"));
                    ex.Data.Add("Temperatura Actual:", string.Format($"{tempActual} ºC"));
                    ex.Data.Add("Incremento dado:", string.Format($"{aumento} ºC"));

                    throw ex;
                }
            }
        }
    }
}