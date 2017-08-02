using System;
using System.Collections;

namespace primjer03
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciranje objekta klase Stack
            Stack stack = new Stack();

            //dodavanje elemenata na stek
            stack.Push(11);
            stack.Push(22);
            stack.Push(33);

            //prikazivanje elemenata steka
            foreach (int i in stack) Console.Write(i + " ");
            Console.WriteLine();

            //brisanje elementa sa steka
            stack.Pop();
            foreach (int i in stack) Console.Write(i + " ");
            Console.Read();
        }
    }
}
