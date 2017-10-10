using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanicramo dva objekta klase Decrament
            //jedan koji ce da cuva taj broj koji mu proslijedimo a drugi za rezultat
            Decrament v1 = new Decrament(3);
            Decrament v2 = new Decrament();

            //implementiramo nas operator
            v2 = --v1;

            Console.WriteLine("Vrijednost dekramenta je: ({0})", v2.X);
            //Console.ReadKey();

            //instanciramo objekat klase TrueFalse
            TrueFalse v10 = new TrueFalse(-1);

            if (v10)
                Console.WriteLine("Vrijednost je true");
            else
                Console.WriteLine("Vrijednost je false");

            Console.ReadKey();


        }
    }
}
