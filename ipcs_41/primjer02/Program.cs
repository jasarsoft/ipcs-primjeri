using System;
using System.Linq;


namespace primjer02
{
    class Program
    {
        static void Main()
        {
            int[] sort = { 2, 8, 4, 6, 7, 5, 3, 1, 9, 10 };

            Console.Write("Niz: ");
            foreach (int i in sort)
                Console.Write(i + " ");
            Console.WriteLine();
            //upit koji sortira brojeve u rastucem poretku iz niza sort
            var sorts = from s in sort orderby s select s;

            Console.Write("Brojevi od 1-10: ");

            foreach (int i in sorts)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.Read();
        }
    }
}
