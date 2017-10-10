using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer4
{
    //deklarisemo delegat, negov tip i argumente (ovdje ih nema)
    public delegate void Example();

    class Program
    {
        static void Main(string[] args)
        {
            //dodajemo anonimnu metodu delegatu
            Example message = delegate
            {
                //stavimo da anonimna metoda nesto radi
                //u ovom slucaju ispisuje ovaj tekst izmedju navodinika
                Console.WriteLine("Zdravo! Zovem se Petra Petrovic i ja sam predavac!");
            };

            //pozivamo metodu
            message();
        
        }
    }
}
