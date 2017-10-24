using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_31_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            var predaje = new Predavac();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Predavac: {0}", predaje[i]);
            }
        }
    }
}
