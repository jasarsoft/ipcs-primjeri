using System;

namespace IPCS_13_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int x = 0;

            while (x < arr.Length)
            {
                Console.WriteLine(arr[x]);
                x++;
            }
        }
    }
}
