using System;
using System.IO;
using System.Text;
using System.Collections;

namespace IPCS_20_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            ArrayList cities = new ArrayList();
            StreamReader sr = new StreamReader("myFile.txt");

            while ((line = sr.ReadLine()) != null)
                cities.Add(line);

            foreach (string city in cities)
                Console.WriteLine(city);
        }
    }
}
