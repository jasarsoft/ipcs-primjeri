using System;


namespace IPCS_22_P2
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
            Neptune,
            Unknown
        };

        static void Main(string[] args)
        {
            Planets p;
            string planet = "Mars";

            if (Enum.IsDefined(typeof(Planets), planet))
                p = (Planets)Enum.Parse(typeof(Planets), planet, true);
            else
                p = Planets.Unknown;

            Console.WriteLine(p);
        }
    }
}
