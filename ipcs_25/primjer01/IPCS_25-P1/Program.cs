using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPCS_25_P1
{
    //class Test
    //{
    //    public int x;
    //}

    struct Test
    {
        public int x;
    }

    class Program
    {
        static void ChangeX(Test t)
        {
            t.x = 55;
        }

        static void Main(string[] args)
        {
            Test t = new Test();
            t.x = 25;
            Console.WriteLine(t.x);
            ChangeX(t);
            Console.WriteLine(t.x);
        }
    }
}
