using System;
using System.Linq;


namespace primjer01
{
    class Program
    {
        static void Main()
        {
            int[] Age = { 11, 10, 9, 6, 18, 23, 48 };

            //upit koji propusta (odnosno koji vraca) samo one osobe koje imaju 18 i vise godina
            var ages = from a in Age where a >= 18 select a;

            Console.Write("Samo osobe sa ovim godina mogu kupovati: ");

            //izvrsavanje upita ages
            foreach (int i in ages)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.Read();
        }
    }
}
