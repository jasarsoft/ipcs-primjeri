using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_08_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //amortizacija i cekanje korisnicog unosa
            string line;
            //iscitavanje reda teksta sa tastature
            while ((line = Console.ReadLine()) != null)
            {
                //formatiranje podatak
                line = line.Replace(",", " y:");
                line = "x:" + line;

                //ispisivanje rezultata u konzolnom prozoru
                Console.WriteLine(line);    
            }

            

        }
    }
}
