using System;
using System.Linq;

namespace vjezba01
{
    class Program
    {
        static void Main()
        {
            int[] Numb = { 3, -4, 9, 6, 18, 23, 0 };

            //napravili smo upit, koji propusta (koji vraca) samo one osobe
            //koje imaju 18 i vise godina
            var numbs = from n in Numb
                        where n > 0 && n < 8
                        select n;

            Console.Write("Parni brojevi i brojevi manji od 8: ");

            //izvrsenje naseg upita
            foreach (int i in numbs)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.Read();
        }
    }
}
