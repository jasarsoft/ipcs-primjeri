using System;
using System.IO;
using System.Text;

namespace IPCS_20_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] { "Paris", "London", "New York", "Los Angeles" };

            StreamWriter sw = new StreamWriter("myFile.txt");
            foreach (string city in cities)
                sw.WriteLine(city);

            sw.Close();
        }
    }
}
