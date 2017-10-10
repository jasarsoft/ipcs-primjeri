using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Values m = new Values(3, 2, 1);
            Values n = new Values(1, 2, 3);
            Values v = new Values();

            //int i;

            //i = m;
            //v = m + n;

            int i;

            i = (int)m; //vrsimo kastovanje
            Console.WriteLine("Result of i = a: " + i);

        }
    }
}
