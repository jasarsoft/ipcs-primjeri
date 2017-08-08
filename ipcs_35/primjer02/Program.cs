using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer2
{
    //deklarisemo delagat za dogadjaj
    public delegate void MyEventHandler();

    //deklarisemo klasu koja sadrzi dogadjaj
    class MyClassForEvent
    {
        public event MyEventHandler MyEvent;

        //ovu metodu zovemo da bi smo pokrenuli dogadjaj
        public void OnMyEvent()
        {
            if (MyEvent != null) MyEvent();
        }
    }

    //ove metode se pozivaju kad je dogadjaj pokrenut
    class HandlerClass1
    {
        public void Handler1()
        {
            Console.WriteLine("Desio se prvi dogadjaj!");
        }
    }

    class HandlerClass2
    {
        public void Handler2()
        {
            Console.WriteLine("Dosio se drugi dogadjaj!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClassForEvent e = new MyClassForEvent();
            HandlerClass1 obj1 = new HandlerClass1();
            HandlerClass2 obj2 = new HandlerClass2();

            //dodajemo handlere na listu dogadjaja
            e.MyEvent += obj1.Handler1;
            e.MyEvent += obj2.Handler2;

            //pokrecemo dogadjaj
            e.OnMyEvent();
            Console.ReadKey();

            //ovim uklanjamo handler2
            e.MyEvent -= obj2.Handler2;
            e.OnMyEvent();
            Console.ReadKey();
        }
    }
}
