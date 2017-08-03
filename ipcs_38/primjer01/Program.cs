using System;
using System.Collections.Generic;

//na ovaj nacin deklarisemo korisnicki interfejs
interface IExample<T>
{
    //deklarisemo neku metodu koju taj interfejs moze da implementira
    T getValue(T val);
}

//deklarisemo genericku klasu koja implementira nas genericki interfejs
class NewClass<T> : IExample<T>
{
    public T getValue(T val)
    {
        return val;
    }
}

namespace primjer01
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciramo objekat klase MyClass sa parametrom tipa string
            NewClass<string> mytext = new NewClass<string>();

            //ovaj kod je dodat samo za potrebe objasnjavanja invarijansa
            NewClass<string> text = mytext;

            Console.WriteLine("{0}", mytext.getValue("Dobar Dan!"));
            Console.Read();
        }
    }
}
