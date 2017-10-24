using System;


namespace IPCS_28_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciranje klase pica
            Pizza p = new Pizza("Kapricoza", 25);
            //dodavanja doataka
            p.Addition("paradajz");
            p.Addition("pavlaka");

            //instanciranje kalse sendvic (Sandwich)
            Sendwitch s = new Sendwitch("Sendvic sa sunkom", 35);
            //dodavanje doataka
            s.Addition("krastavac");
            s.Addition("luk");
            s.Addition("paradajz");

            //prikazivanje rezultata
            Console.WriteLine(p);
            Console.WriteLine(s);
        }
    }
}
