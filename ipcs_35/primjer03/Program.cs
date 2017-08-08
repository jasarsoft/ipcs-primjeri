using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer3
{
    //deklarisemo delegat za dogadjaj
    delegate void MyEventHandler(int n);

    //deklarisemo klasu koja ce sadzavati dogadjaj
    class MyEventClass
    {
        public event MyEventHandler MyEvent;

        //za startovanje dogadjaja
        public void OnMyEvent(int n)
        {
            if (MyEvent != null) MyEvent(n);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyEventClass evt = new MyEventClass();

            //koristimo labda izraz kao event handler
            //evt.MyEvent += (n) => Console.WriteLine("Vrijednost event handlera: " + n);

            //koristimo anonimnu metodu za event handler
            evt.MyEvent += delegate(int n)
            {
                Console.WriteLine("Vrijednsot eventa: " + n);
            };

            //pokrecemo dogadjaj dva puta
            evt.OnMyEvent(1);
            evt.OnMyEvent(2);

            Console.ReadKey();
        }
    }
}
