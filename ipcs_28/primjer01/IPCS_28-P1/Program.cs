using System;


namespace IPCS_28_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            c.setOperands(3, 5);
            Console.WriteLine(c.add());
        }
    }
}
