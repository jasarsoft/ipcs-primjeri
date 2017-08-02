using System;
using System.Collections;

namespace primjer04
{
    class HashtableDemo
    {
        static void Main(string[] args)
        {
            //kreiramo instancu klase Hashtable
            Hashtable hash = new Hashtable();

            //dodajemo elemente u hashtabelu
            hash.Add("prvo", "Beograd");
            hash.Add("drugo", "Novi Sad");
            hash.Add("trece", "Rume");

            //mozemo koristiti i indeksere za dodavanje elemenata
            hash["cetrvrto"] = "Sremska Kamenica";

            //uzima kljuceve iz kolekcije
            ICollection c = hash.Keys;

            //na osnvu predhodni uzetih kljuceva dobijamo vrijednost
            foreach (string str in c) Console.WriteLine(str + ": " + hash[str]);

            Console.Read();
        }
    }
}
