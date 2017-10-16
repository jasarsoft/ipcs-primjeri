using System;

namespace IPCS_13_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -1, 4, 5, -1 };
            int[] arr1 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                    arr1[i] = 0;
                else
                    arr1[i] = arr[i];
            }

            foreach (int n in arr1)
                Console.WriteLine(n);
        }
    }
}
