using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer3
{
    //deklarisemo delegat
    delegate int Parity (int v);
    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo instancu delegata Parity
            //ova instanca n referise na lambda izraz koji provjerava parnost proslijedjenog broja
            //i ukooliko je paran uvecava vrijednost za jedan u suptrotnom ako je neparan smanjuje za jedan
            Parity n = test =>
            {
                int r = 1;
                if (test % 2 == 0)
                {
                    r = test + 1;
                    return r;
                }
                else
                    return test - 1;
            };

            //sada cemo iskoristit labda izraz preko delegata
            Console.WriteLine("Rezultat za 4 je: {0}", n(4));
            Console.WriteLine("Rezultat za 5 je: {0}", n(5));
            Console.Read();
        }
    }
}
