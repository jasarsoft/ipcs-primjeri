using System;


namespace IPCS_22_P1
{
    class Program
    {
        enum Planets
        {
            Mercury,
            Venus,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Uranus,
            Neptune
        };
        
        static void Main(string[] args)
        {
            for (Planets planet = Planets.Mercury; planet <= Planets.Neptune; planet++)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine(Enum.IsDefined(typeof(Planets), "Mercury"));
            Console.WriteLine(Enum.Parse(typeof(Planets), "Mercury"));
        }
    }
}
