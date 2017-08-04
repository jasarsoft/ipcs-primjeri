using System;

namespace primjer01
{
    class Program
    {
        public static void MyMethod<T>(T val)
        {
            Console.WriteLine(val);
        }

        static void Main(string[] args)
        {
            //vidimo kako se ponasa metoda kada joj proslijedimo sve ove tipove
            int intVal = 1;
            double doubleVal = 3.14;
            bool boolVal = true;
            string stringVal = "Hello!";

            MyMethod(intVal);
            MyMethod(doubleVal);
            MyMethod(boolVal);
            MyMethod(stringVal);

            Console.Read();
        }
    }
}
