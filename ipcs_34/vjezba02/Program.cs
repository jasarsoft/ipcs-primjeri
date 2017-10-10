using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba2
{
    class Program
    {
        //pravimo delegat koji ima povratni tip double
        //i koji za parametar uzima vrijednost tipa double
        delegate double Divide(double x);
        static void Main(string[] args)
        {
            //instanciramo objekat delegata Divide kojem dodjeljujemo labda izraz
            //kojem se proslijedjuje vrijednost tipa double i koji vraca vrijednost tiap double isto kao i delegat
            Divide decim = (double number) =>
            {
                return number / 2;
            };

            //nas program ce vratit broj 37,5 jer smo proslijedili broj 75
            Console.WriteLine("Rezultat za 75 je: {0}", decim(75));
            Console.Read();

        }
    }
}
