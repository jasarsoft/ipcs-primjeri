using System;

namespace IPCS_12_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 2, 5, 3 };
            int avg = (grades[0] + grades[1] + grades[2]) / grades.Length;

            if (avg > 1)
                Console.WriteLine("Grade " + avg + " is passing grade");
            else
                Console.WriteLine("Grade " + avg + " is not passing grade");
        }
    }
}
