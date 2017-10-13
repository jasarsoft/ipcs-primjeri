using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_11_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[,] 
            {
                {1, 2, 3},
                {5, 6, 7},
                {9, 0, 1}
            };

            int[,] matrix2 = new int[,]
            {
                {4, 1, 6},
                {2, 3, 5},
                {7, 4, 3}
            };

            int[,] matrix3 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write("{0,3}", matrix3[i, j]);
                }
                Console.WriteLine();
            }
                

                    

            
        }
    }
}
