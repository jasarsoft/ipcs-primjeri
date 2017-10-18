using System;
using System.IO;
using System.Text;

namespace IPCS_20_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //postavlja se svojstvo Out klase Console na objekat StreamWriter klase
            Console.SetOut(new StreamWriter("myFile.txt"));

            //definise se string koji ce sluziti kao skladiste za svaku unijetu liniju
            string line;

            //zapocinje petlja koja prihvata korisnicki unos i traje sve dok korisnik ne unese prazan string
            while ((line = Console.ReadLine()) != "")
            {
                //unijeti sadrzaj se ispisuje na izlaz fajla
                Console.WriteLine(line);
                //izvrsava se flush toka
                Console.Out.Flush();
            }
        }
    }
}
