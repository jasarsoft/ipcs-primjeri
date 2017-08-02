using System;
using System.Collections;

namespace primjer01
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarisemo kolekciju tipa ArrayList
            ArrayList names = new ArrayList();
            Console.WriteLine("Incjalizovani broj elemenata: " + names.Count + "\n");

            //dodoavanje elemenata u listu
            names.Add("Andjela");
            names.Add("Nevena");
            names.Add("Ana");

            Console.WriteLine("Broj elemenata nakon dodavanje {0}\n", names.Count);

            //prikazivanje cijele liste koriscenjem indeksera
            Console.WriteLine("Trenutni sadrzaj: ");
            for (int i = 0; i < names.Count; i++)
                Console.Write(names[i] + " ");
        }
    }
}
