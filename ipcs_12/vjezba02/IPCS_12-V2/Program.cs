using System;

namespace IPCS_12_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ulazni podaci
            int x = 523132;
            int y = 325423;
            int reminder = x % y;

            switch (reminder)
            {
                case 0:
                    Console.WriteLine("no reminder");
                    break;
                default:
                    if (reminder > 1000)
                        Console.WriteLine("reminder above 1000");
                    else
                        Console.WriteLine("reminder below 1000");
                    break;

            }
        }
    }
}
