using System;

//prvo genericki interfejs koji podrzava kovarijansu
public interface ICov<in T>
{
    void Show(T obj);
}

//MyClass implementira interfejs ICov
class MyClass<T> : ICov<T>
{
    public void Show(T x)
    {
        Console.WriteLine(x);
    }
}

//kreiramo jednostavnu hijerarhiju klasa
class Animal
{
    public override string ToString()
    {
        return "Ovo je zivotivnja.";
    }
}
class Horse : Animal
{
    public override string ToString()
    {
        return "Ovo je zivotirnja";
    }
}

namespace primjer03
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreirmao MyClass objekat tipa Animal dodjelimo ga instanci interfejsa
            //ICov tipa Animal
            ICov<Animal> Ref = new MyClass<Animal>();

            //kreiramo objekat MyClass<Animal> i dodjelimo ga Ref2 promjenljivoj koja je
            //instanca interfejsa ICov<Horse>
            ICov<Horse> Ref2 = new MyClass<Animal>();
            Ref2.Show(new Horse());

            Console.Read();
        }
    }
}
