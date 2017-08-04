using System;

namespace primjer02
{
    //deklarisemo genericki delegat
    delegate T MyDelegate<T>(T v);

    class GenericDelegate
    {
        //vraca proslijedjenu vrijednost uvecanu za jedan
        static int Increment(int v)
        {
            v += 1;
            return v;
        }

        //vraca preokrenut string koji smo mu proslijedili
        static string Reverse(string str)
        {
            string result = "";

            foreach (char ch in str)
            {
                result = ch + result;
            }

            return result;
        }

        static void Main(string[] args)
        {
            //kreiramo int delegat
            MyDelegate<int> i = Increment;
            Console.WriteLine(i(234));

            //kreiramo string delegat
            MyDelegate<string> str = Reverse;
            Console.WriteLine(str("Genericki delegat!"));

            Console.Read();
        }
    }
}
