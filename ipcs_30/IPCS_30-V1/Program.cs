using System;


namespace IPCS_30_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Unesite broj ljudi: ");
            number = int.Parse(Console.ReadLine());

            Man m = new Man(number);
            Console.WriteLine("Broj ljudi na planeti: {0}", m.NumberOfPeople);
            Console.ReadLine();

            //instanciramo jedan objekat i odredjujemo mu svojstvo
            Flower c = new Flower { Color = "Zuta" };
            
            //instanciramo jos jedan objekat i odredjumo mu svojstvo name
            Flower n = new Flower { Name = "Ruza" };
            
            //instanciramo objekat i postavljamo mu visestruka svojstva
            Flower f = new Flower
            {
                Name = "Lala",
                Color = "Crvena"
            };
        }
    }
}
