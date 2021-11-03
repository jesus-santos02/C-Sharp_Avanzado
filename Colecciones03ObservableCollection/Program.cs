using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Colecciones03ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Punto> puntos = new ObservableCollection<Punto>();

            puntos.Add(new Punto(3, 4));
            puntos.Add(new Punto(1, 6));
            puntos.Add(new Punto(7, 2));

            //Adicionamos un Handler
            puntos.CollectionChanged += puntos_CollectionChanged;

            puntos.Add(new Punto(2, 3));

            Punto miPunto = new Punto(5, 3);
            puntos.Add(miPunto);

            puntos.Remove(puntos[0]);

            puntos[1] = new Punto(9, 3);

            Console.WriteLine("-----");

            foreach (Punto punto in puntos)
            {
                Console.WriteLine(punto);
            }
            
        }

        public static void puntos_CollectionChanged(Object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elemento agregado");
                foreach(var item in e.NewItems)
                    Console.WriteLine(item);
            }  
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elemento eliminado");
                foreach(var item in e.OldItems)
                    Console.WriteLine(item);
            } 
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("Elemento reemplazado");
            }
        }
    }
}
