using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba2
{
    public class Exam
    {
        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value > 1 && value <= 12)
                    month = value;
                else
                    Console.WriteLine("Niste unijeli validan mjesec odrzavanja ispita");
            }
        }


        //pravimo metodu koju mogu da koriste objekti ove klase 
        //i koja sluzi za implementaciju get metode
        public static Exam Read()
        {
            Exam e = new Exam();
            Console.WriteLine("Mjesec odrzavanja prijemnog ispita: ");
            e.Month = int.Parse(Console.ReadLine());
            return e;
        }

        //pravimo metodu koju mogu da koriste objekti ove klase
        //i koja sluzi za implementaciju set metode
        public static void Write(Exam ex)
        {
            Exam e = new Exam();
            Console.WriteLine("Mjesec koji ste unijeli ispravan je i iznosi: {0}", ex.Month);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
