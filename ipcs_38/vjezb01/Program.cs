using System;

//pravimo genericki interfejs koji podrzava kovarijnsu
public interface ICov<out T>
{
    T GetObject();
}

//MyClass implementira interfejs ICov
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
class People
{
    string name;

    public People(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }
} 

class Student : People
{
    public Student(string n) : base(n)
    {
    }
}

namespace vjezb01
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo MyClass  objekat tipa Student i dodjelimo ga instanci
            //interfejsa ICov koji je nadtipa People
            ICov<People> Ref = new MyClass<Student>(new Student("Marko Markovic"));
            Console.WriteLine("Novi student je: " + Ref.GetObject().GetName());

            Console.Read();
        }
    }
}
