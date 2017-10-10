using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba1
{
    public delegate int Putarina (int tipVozila);

    public class Metods
    {
        public int Naplata (int tipVozila)
        {
            if (tipVozila == 1)
                return 200;
            else
                return 250;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Metods met = new Metods();

            //instanciranje
            Putarina put = met.Naplata;

            //pozivanje metode
            //postavili smo vrijednost voizila na tip 1
            Console.WriteLine("Putarina iznosi: {0}", put(1));
            Console.ReadKey();
        }
    }
}
