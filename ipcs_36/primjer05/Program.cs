using System;
using System.Collections;

namespace primjer05
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo instancu klase SortedList
            SortedList sort = new SortedList();

            //dodajemo elemente u hes tablicu
            sort.Add("provo", "Beograd");
            sort.Add("drugo", "Novi Sad");
            sort.Add("trece", "Ruma");

            //mozemo koristiti i indeksere za dodavanje elemenata
            sort["cetvrto"] = "Sremska Kamenica";

            //uzimanje kljuceva iz kolekcije
            ICollection ic = sort.Keys;

            //na osnovu predhodno uzeti kljuceva dobijamo vrijednosti
            foreach (string str in ic) Console.WriteLine(str + ": " + sort[str]);

            //prikaz liste koristeci cijelobrojne vrijednosti za indekse
            Console.WriteLine("Sadrzaj cijelobrojnih indeksa");
            for (int i = 0; i < sort.Count; i++)
                Console.WriteLine(sort.GetByIndex(i));

            //prikazuje cijelobrojne indekse uzetih vrijednosti
            foreach (string str in ic)
                Console.WriteLine(str + ": " + sort.IndexOfKey(str));

            Console.Read();


        }
    }
}
