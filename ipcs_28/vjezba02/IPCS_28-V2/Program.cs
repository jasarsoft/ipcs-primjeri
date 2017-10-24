using System;


namespace IPCS_28_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();

            s.Setxya(100, 100, 5);

            Console.WriteLine(s.Area());
            Console.WriteLine(s.Volume());
        }
    }
}
