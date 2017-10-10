using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer5
{
    //primjetimo da nas delegat ima parametar
    //posto ga i anonimna metoda ima
    delegate void Numbers(int end);
    class Program
    {
        static void Main(string[] args)
        {
            //prosliedjujemo argument anonimnoj metodi
            Numbers numb = delegate(int end)
            {
                for (int i = 10; i >= end; i--) Console.WriteLine(i);
            };

            Console.WriteLine("I odbrojavanje pocinje sada!");
            numb(1);
            
            Console.ReadKey();
        }
    }
}
