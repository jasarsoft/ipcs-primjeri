using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //SIFT OPERATOR
            //int a = 10;
            //int b = a << 1;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(Convert.ToString(a, 2));
            //Console.WriteLine(Convert.ToString(b, 2));

            //BINARNO NE (komplement)
            //int a = 10;
            //int b = ~a;
            //Console.WriteLine(b);
            //Console.WriteLine(Convert.ToString(b, 2));

            //BINARNO XOR (exclusive or)
            int a = 10;
            int b = 20;
            int c = b ^ a;
            Console.WriteLine(c);
            Console.WriteLine(Convert.ToString(c, 2));
        }
    }
}
