using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPCS_25_P2
{
    struct Test
    {
        public int x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.x = 25;
            Console.WriteLine(t.x);

            object o = t;
            Test t1 = (Test)o;
            Console.WriteLine(t1.x);
        }
    }
}
