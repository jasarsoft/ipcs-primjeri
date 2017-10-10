using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer2
{
    //deklarisemo delagat
    delegate bool Parity(int v);

    class Program
    {
        static void Main(string[] args)
        {
            Parity n = test => test % 2 == 0;

            //sada cemo upotrijebiti lambda izraz
            //preko instance delegata test

            if (n(6))
                Console.WriteLine("Ovo je paran broj");
            else
                Console.WriteLine("Nije paran broj.");

            Console.Read();
        }
    }
}
