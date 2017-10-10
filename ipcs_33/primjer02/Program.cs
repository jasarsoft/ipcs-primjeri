using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer2
{
    delegate string Example();

    public class Practice
    {
        public string Insturctor()
        {
            return "Zdravo! Zovem se Petra Petrovic i ja sam predavac!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo instancu klase practicle
            Practice obj = new Practice();

            //kreiramo instancu delegata
            Example examp = obj.Insturctor;

            //pozivanje metode
            string str = examp();

            Console.WriteLine("Ovo je primjer: " + str);
            Console.ReadKey();

        }
    }
}
