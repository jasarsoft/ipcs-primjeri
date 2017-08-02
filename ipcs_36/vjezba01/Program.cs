using System;
//obavezno navodimo prostor imena System.Collections kako bi smo 
//mogli da koristimo klase kolekcija
using System.Collections;

namespace vjezba01
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarisemo deklaraciju tipa ArrayList
            ArrayList cities = new ArrayList();

            //dodajemo svaki grad posebno
            cities.Add("Novi Sad");
            cities.Add("Beograd");
            cities.Add("Nis");

            //brisemo grad nis
            cities.Remove("Nis");

            //iscitava sva imena
            foreach (string city in cities)
                Console.WriteLine(city);

            Console.Read();
        }
    }
}
