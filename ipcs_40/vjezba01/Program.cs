using System;
using System.Collections;

namespace vjezba01
{
    class EnumClass
    {
        char[] letters = { 'A', 'B', 'V', 'G', 'D', 'Đ' };

        public IEnumerator GetEnumerator()
        {
            foreach (char letter in letters)
                yield return letter;
        }
    }

    class Program
    {
        static void Main()
        {
            EnumClass let = new EnumClass();

            foreach (char letter in let)
                Console.Write(letter + " ");

            Console.Read();
        }
    }
}
