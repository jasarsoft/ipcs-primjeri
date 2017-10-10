using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer1
{
    //deklarisemo delegat
    delegate int Sum(int x);


    class Program
    {
        static void Main(string[] args)
        {
            int n;

            //kreiramo instancu delegata Sum
            //ova instanca test referise na lambda izraz
            //koji inkrementira svoj parametar za 1
            Sum test = numb => numb + 1;
            //Sum test = (int numb) => numb + 1; //explicitna verzija

            //sada cemo upotrebiti labda izraz test
            n = test(3);
            Console.WriteLine("Rezulzat je {0}", n);
            Console.Read();
        }
    }
}
