using System;

namespace IPCS_18_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MakeException(3);
            }
            catch (MyExceptionClass ex)
            {
                Console.WriteLine("Exception cought " + ex.ToString());
            }
        }

        public static void MakeException(int no)
        {
            switch (no)
            {
                case 1:
                case 2:
                case 3:
                    throw new MyExceptionClass(no);
                    break;
                default:
                    Console.WriteLine("Excetpion is not thrown");
                    break;
            }
        }
    }
}
