using System;


namespace vjezba02
{
    public class Program
    {
        public static void MyMethod<U, V>(U val1, V val2)
        {
            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }

        static void Main(string[] args)
        {
            int intVal1 = 1;
            int intVal2 = 3;

            MyMethod(intVal1, intVal2);

            Console.Read();
        }
    }
}
