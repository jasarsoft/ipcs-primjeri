using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer1
{
    //deklarisemo delegat za dogadjaj
    delegate void MyEventHandler();

    //deklarisemo klasu koja sadrzi dogadjaj
    class MyClassForEvent
    {
        public event MyEventHandler MyEvent;

        //ovu metodu zovemo da pokrenemo dogadjaj
        public void OnMyEvent()
        {
            if (MyEvent != null)
            {
                MyEvent();
            }
        }
    }

    class Program
    {
        //rukovodilac dogadjajem: Event handler
        static void EHandler()
        {
            Console.WriteLine("Dogadjaj se dogodio!");
        }
        static void Main(string[] args)
        {
            MyClassForEvent e = new MyClassForEvent();

            //dodjajemo EHandler na listu dogadjaja
            e.MyEvent += EHandler;
            //pokrecemo dogadjaj
            e.OnMyEvent();

            Console.ReadKey();
        }
    }
}
