using System;

//T je tip parametra koji ce se koristiti kao pravi tip, kada se objekat
//tipa generic kreira

class Generics<T>
{
    //deklarisemo promjenljivu tipa T
    T obj;

    //konstruktor koji ima parametar tipa T
    public Generics(T obj)
    {
        this.obj = obj;
    }

    //vraca vrijednost obj koji je tipa T
    public T GetObj()
    {
        return this.obj;
    }

    //prikazuje koji je tipa T
    public void ShowType()
    {
        Console.WriteLine("Stvarni tip parametra T je: " + typeof(T));
    }
}

namespace primjer01
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo referencu Generics za tip string
            Generics<string> str = new Generics<string>("Ovo je string!");

            //prikazuje stvarni tip podataka koji predstavlja tip objekta
            //kojeg smo dodjelili promjenljivoj str
            str.ShowType();

            //prikazuje vrijednosti koja je dodjeljena instanci klase Generics str i 
            //smjesta je u promjenljivu tipa string
            string str1 = str.GetObj();
            Console.WriteLine("Vrijednost ovog stringa je: " + str1);

            //kreira instancu klase Generics za tip double
            Generics<double> d = new Generics<double>(9.33);

            //prikazuje stvarni tip podataka koji predstavlja tip objekta, kojeg smo
            //dodjelili promjenljivoj d
            d.ShowType();

            //prikazuje vrijednosti koja je dodjeljena instanci klase Generics d
            //i smjesta je u promjenljivu tipa double
            double d1 = d.GetObj();
            Console.WriteLine("Vrijednost ovog stringa je: " + d1);

            Console.Read();

            Console.Read();
        }
    }
}
