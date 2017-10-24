using System;

namespace IPCS_28_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.SetOperands(2, 3);

            Console.WriteLine(c.Add());
            Console.WriteLine(c.Sub());
        }
    }
}
