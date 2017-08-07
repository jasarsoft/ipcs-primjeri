using System;
using System.Collections;

namespace primjer05
{
    class MyClass
    {
        string[] cities = { "BGD", "NS" };

        public IEnumerator GetEnumerator()
        {
            foreach (string city in cities)
                yield return city;
        }
    }

    class MainClass
    {
        static void Main()
        {
            MyClass example = new MyClass();

            foreach (string city in example)
                Console.Write(city + ", ");

            Console.WriteLine();
            Console.Read();
        }
    }
}
