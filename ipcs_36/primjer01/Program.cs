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

            Console.WriteLine("Broj elemenata nakon dodavanje {0}", names.Count);

            //prikazivanje cijele liste koriscenjem indeksera
            Console.WriteLine("Trenutni sadrzaj: ");
            for (int i = 0; i < names.Count; i++)
                Console.Write(names[i] + " ");

            Console.WriteLine("\n");
            Console.WriteLine("Uklanjanje elemenata u toku...");
            Console.WriteLine("Uklonjen elemenet Ana");
            names.Remove("Ana");
            Console.WriteLine("Trenutni broj elemenata: {0}", names.Count);

            //iscrtavanje elemenata upotreba foreach petlje
            Console.Write("Elementi: ");
            foreach (string name in names) Console.Write(name + " ");
            Console.WriteLine("\n");

            //mjenjanje sadrzaja
            Console.WriteLine("Mijenja se prvi element: ");
            names[0] = "Milena";
            Console.Write("Ponovo izlistavanje sadrzaja: ");
            foreach (string name in names) Console.Write(name + " ");

            Console.Read();

        }
    }
}
