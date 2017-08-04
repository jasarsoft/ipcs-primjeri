using System;

//pravimo genericki interfejs koji podrzava kovarijansu
public interface ICov<out T>
{
    T GetObject();
}

//MyClass implementira intefejs ICov
class MyClass<T> : ICov<T>
{
    T obj;

    public MyClass(T v)
    {
        obj = v;
    }

    public T GetObject()
    {
        return obj;
    }
}

//kreiramo jednostavno hijerarhiju klasa
class Animal
{
    string name;

    public Animal(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }
}

class Horse : Animal
{
    public Horse (string n ) : base(n)
    {

    }
}

namespace primjer02
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo MyClass objekat i dodjelimo ga instanci interfejsa ICov
            ICov<Animal> Ref = new MyClass<Animal>(new Animal("ovca"));
            Console.WriteLine("Vrijednost na koju referise Ref je: " + Ref.GetObject().GetName());

            //kreiramo objekat MyClass<Horse> i dodjelimo ga Ref2 promjenljivoj, koja je tipa Horse
            //ovo je dozvoljeno i bez kovarijanse
            ICov<Horse> Ref2 = new MyClass<Horse>(new Horse("Novi konj"));

            //kreiramo objekat MyClass<Horse> i dodjelimo ga Ref promjenljivoj
            Ref = new MyClass<Horse>(new Horse("Konj"));
            Console.WriteLine("Vrijednost na koju referise Ref je: " + Ref.GetObject().GetName());

            Console.Read();

        }
    }
}
