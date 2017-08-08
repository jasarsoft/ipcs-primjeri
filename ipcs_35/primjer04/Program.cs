using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer4
{
    //ovim izvodimo klasu iz kalse EventArgs
    class MyEventArgsClass : EventArgs
    {
        public int NumberOfEvents;
    }

    //deklarisemo delegat za dogadjaj sa predefinisanim parametrima
    delegate void MyEventHadler(object sender, MyEventArgsClass e);

    //deklarisemo klasu koja sadrzi delegat
    class MyEventClass
    {
        static int count = 0;
        public event MyEventHadler MyEvent;

        //startuje MyEvent dogadjaj
        public void OnMyEvent()
        {
            MyEventArgsClass arg = new MyEventArgsClass();

            if (MyEvent != null)
            {
                arg.NumberOfEvents = count++;
                MyEvent(this, arg);
            }
        }
    }

    //kreirajmo klasu koja ce sadrzavati event handler dogadjaj
    class EventHandlerClass
    {
        //kreiramo event handler
        public void Handler(object sender, MyEventArgsClass e)
        {
            //u kojoj klasi se startuje dogadjaj - sender
            //i koji je poredu izvrsavanja NumberOfEvents
            Console.WriteLine("Dogadjaj iz {0} je po redu desavanja broj {0}", sender, e.NumberOfEvents);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventHandlerClass ob1 = new EventHandlerClass();
            MyEventClass e = new MyEventClass();

            //dodjaje Handler u listu dogadjaja
            e.MyEvent += ob1.Handler;

            //startuje dogadjaj
            e.OnMyEvent();
            e.OnMyEvent();

            Console.ReadKey();
        }
    }
}
