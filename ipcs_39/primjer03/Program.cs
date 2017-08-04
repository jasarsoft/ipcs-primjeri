using System;
using System.Collections.Generic;

namespace primjer03
{
    class Program
    {
        static void Main()
        {
            //uzimamo instancu delegata Action, tipa string
            Action<String> example = new Action<String>(Program.Show);

            //instanca objekta kolekcija List-a
            List<String> cities = new List<String>
            {
                "Novi Sad", "Beograd", "Nis"
            };

            cities.ForEach(example);

            Console.Read();
        }

        static void Show(String s)
        {
            Console.WriteLine(s);
        }
    }
}
