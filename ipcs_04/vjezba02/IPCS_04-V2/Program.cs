using System;


namespace Animals
{
    namespace Cats
    {
        namespace Domestic
        {
            class Info { public static void Show() { Console.WriteLine("Miaou"); } }
        }

        namespace Wild
        {
            class Info { public static void Show() { Console.WriteLine("Grrr"); } }
        }
    }

    namespace Dogs
    {
        namespace Domestic
        {
            class Info { public static void Show() { Console.WriteLine("Wof"); } }
        }

        namespace Wild
        {
            class Info { public static void Show() { Console.WriteLine("Grr"); } }
        }
    }
}

namespace IPCS_04_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals.Cats.Domestic.Info.Show();
            Animals.Cats.Wild.Info.Show();
            Animals.Dogs.Domestic.Info.Show();
            Animals.Dogs.Wild.Info.Show();
        }
    }
}
