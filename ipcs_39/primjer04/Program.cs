using System;


namespace primjer04
{
    class GenericFunc
    {
        static void Main(string[] args)
        {
            //instanciranje delegata da referise na nasu metodu
            //za povratni tip definisemo da to bude string
            Func<string, string> MyMethod = LowercaseString;

            string city = "SARAJEVO";
            Console.WriteLine(MyMethod(city));

            Console.Read();
        }

        //nasa metoda koja vrsi konverziju iz velikih u mala slova
        private static string LowercaseString(string str)
        {
            return str.ToLower();
        }
    }
}
