using System;

namespace Exception02
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
                    CalderaException ex = new CalderaException
                                        (string.Format($"La caldera {marca} se sobrecalienta"),
                                        "Ha trabajado demasiado tiempo", DateTime.Now);
                    ex.HelpLink = "http://www.google.com.do";

                    throw ex;
                }
            }
        }
    }//Finaliza la clase Caldera

    //Todas las clases de excepcion deben tener acceso publico
    //V1 de la clase excepcion
    /*public class CalderaException: ApplicationException
    {
        private string _mensaje = "";
        private DateTime _momento;
        private string _causa;

        public DateTime Momento { get => _momento; set => _momento = value; }
        public string Causa { get => _causa; set => _causa = value; }
        public CalderaException(string mensaje, string causa, DateTime momento)
        {
            _mensaje = mensaje;
            _causa = causa;
            _momento = momento;            
        }

        //Hacemos un override a la propiedad Exception.Message
        public override string Message
        { 
            get => string.Format($"Mensaje de la excepción => {_mensaje}");        
        }
    }*/

    //V2 de la clase excepcion
    /*public class CalderaException: ApplicationException
    {
        private DateTime _momento;
        private string _causa;

        public DateTime Momento { get => _momento; set => _momento = value; }
        public string Causa { get => _causa; set => _causa = value; }
        public CalderaException(string mensaje, string causa, DateTime momento): base(mensaje)
        {
            _causa = causa;
            _momento = momento;            
        }

    }*/
    //V3
    //Excepcion completa de acuerdo con las reglas de .NET
    //Derivar de Exception/ApplicationException
    //Usar [System.Serializable]
    //Definir constructor de default
    //Definir contructor que coloca Message en la herencia
    //Definir contructor que maneja excepciones internas
    //Definir contructor que maneja la serializacion del tipo
    public class CalderaException: ApplicationException
    {
        public CalderaException() { }
        public CalderaException(string mensaje): base(mensaje) { }
        public CalderaException(string mensaje, System.Exception inner): base(mensaje, inner) { }
        public CalderaException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context): base(info, context) { }
        private DateTime _momento;
        private string _causa;
 
        public DateTime Momento { get => _momento; set => _momento = value; }
        public string Causa { get => _causa; set => _causa = value; }
        public CalderaException(string mensaje, string causa, DateTime momento): base(mensaje)
        {
            _causa = causa;
            _momento = momento;
        }

    }

}