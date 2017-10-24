using System;


namespace IPCS_27_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();

            c.r = 12;
            c.color = "red";
            c.x = 100;
            c.y = 200;

            Console.WriteLine(c.Area());
        }
    }
}
