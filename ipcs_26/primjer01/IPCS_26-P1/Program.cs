using System;


namespace IPCS_26_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            p.setPrice(10);
            Console.WriteLine(p.getPrice());
        }
    }
}
