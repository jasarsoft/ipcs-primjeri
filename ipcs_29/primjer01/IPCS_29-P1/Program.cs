using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPCS_29_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGCCollectClass myGCCol = new MyGCCollectClass();

            //odrediti maksimalna broj generisanja koje GC sistem podrzava
            Console.WriteLine("The higest generation is {0}", GC.MaxGeneration);

            myGCCol.MakeSomeGarbage();

            //odrediti kojom metodom generisanja je objekat myGCCol sacuvan
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            //priblizno odrediti broj bajtova trenutno lociranih u koristenoj memoriji
            Console.WriteLine("Totoal Memory: {0}", GC.GetTotalMemory(false));

            //izvrsiti prikupljanje kada je generiasnje nula
            GC.Collect(0);

            //odrediti kojom metodom generisanja je objekat myGCCol sacuvan
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            //izvrsiti prikupljanje svih generisanja do 2 i ukljuciti 2
            GC.Collect(2);

            //odrediti kojom metodom generisanja je objekat myGCCol sacuvan
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
            Console.Read();
        }
    }
}
