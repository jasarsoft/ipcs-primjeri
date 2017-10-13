using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_11_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users1 = { "Peter Smith", "Sally Jones" };
            string[] users2 = { "Geroge Stevans", "Nick Simmons" };
            string[] users3 = new string [users1.Length + users2.Length];

            Array.Copy(users1, 0, users3, 0, users1.Length);
            Array.Copy(users2, 0, users3, users1.Length, users2.Length);

            for (int i = 0; i < users3.Length; i++)
                Console.WriteLine(users3[i]);

        }
    }
}
