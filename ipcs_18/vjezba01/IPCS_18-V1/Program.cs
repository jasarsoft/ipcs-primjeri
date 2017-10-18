using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_18_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;

            try
            {
                checked
                {
                    int x = 2147483647;
                    y = x * 2;
                }
            }
            catch
            {
                y = 0;
            }
            Console.WriteLine(y);
        }
    }
}
