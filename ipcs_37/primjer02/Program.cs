using System;

class Generics<T, V>
{
    T obj1;
    V obj2;

    //konstruktor koji ima dva parametra od kojih je jedan tipa T, a drugi tipa V
    public Generics(T obj1, V obj2)
    {
        this.obj1 = obj1;
        this.obj2 = obj2;
    }

    public T GetObj1()
    {
        return this.obj1;
    }

    public V GetObj2()
    {
        return this.obj2;
    }
}
namespace primjer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics<string, double> tgObj = new Generics<string, double>("testiranje", 14.22);

            string str = tgObj.GetObj1();
            Console.WriteLine(str);
            double d = tgObj.GetObj2();
            Console.WriteLine(d);

            Console.Read();
        }
    }
}
