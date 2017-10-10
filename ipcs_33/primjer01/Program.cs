using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer1
{
    class Program
    {
        //deklarisimo tip delegata
        delegate string StringDelegate(string str);

        //metoda koja preokrece string
        static string Reverse(string s)
        {
            int i, j;
            string temp = "";

            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            {
                temp += s[i];
            }

            return temp;
        }

        static void Main(string[] args)
        {
            //pravimo konstruktor za delegat
            StringDelegate rev = new StringDelegate(Reverse);

            string str;

            //pozivamo metodu kroz delegat
            //ovdje je metoda Reverse pozvana kroz instancirani delegat rev
            str = rev("Hej! Ovo je cudno!");

            Console.WriteLine("Ovo je preokrenut string: " + str);

        }
    }
}
