using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba1
{
    //deklarisemo delegat koji ima dva parametra
    //oba tima int i ciji je povratni tip takodje int
    delegate int Subtraction (int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //pravimo instancu delegatu Operator i dodjeljujemo joj labda izraz
            //koji vrsi oduzimanje dva parametra koja joj se prosljedjuju
            //i vraca rezultat koji je tipa int
            Subtraction Operation = (x, y) =>
            {
                return x - y;
            };

            //pozivamo lambda izraz preko instance delegata i ispisujemo rezultat
            Console.WriteLine("Rezultat za 4 i 3 je: {0}", Operation(4, 3));
            Console.Read();
        }
    }
}
