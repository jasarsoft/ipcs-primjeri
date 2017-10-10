using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_32_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 22);
            Vector v2 = new Vector(3, 2);
            Vector v3 = new Vector();

            v3 = v1 + v2;

            Console.WriteLine("Vrijednost sabiranja vektora: {0}, {1}", v3.X, v3.Y);
            Console.ReadKey();
        }
    }
}
