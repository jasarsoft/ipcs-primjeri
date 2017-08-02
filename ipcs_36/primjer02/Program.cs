using System;
using System.Collections;

namespace primjer02
{
    class QueneDemo
    {
        static void Main(string[] args)
        {
            //dodajemo instancu klase Quene
            Queue quene = new Queue();

            //dodajemo vrijednosti u red
            quene.Enqueue(33);
            quene.Enqueue(55);
            quene.Enqueue(66);

            //prikazujemo sve vrijednosti iz reda
            foreach (int i in quene) Console.Write(i + " ");
            Console.WriteLine();

            //brisemo prvu vrijednost iz reda
            quene.Dequeue();

            //prikazujemo sve vrijednosti iz reda
            foreach (int i in quene) Console.Write(i + " ");

            Console.Read();
        }
    }
}
