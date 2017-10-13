using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_10_V2
{
    class Program
    {
        const double PI = 3.14;

        static void Main(string[] args)
        {
            //definicija promjenljive r
            double r = 5;
            //definicija primjenjljive p kao rezultat izracunavanja povrsine kruga
            double p = (r * r) * PI;
            //emitovanje primjenljive p koja sadrzi rezultat povrsinu kruga sa poluprecinkom r
            Console.WriteLine(p);
        }
    }
}
