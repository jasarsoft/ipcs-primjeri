using System;
using System.Collections.Generic;
using System.Text;

namespace Schools
{
    class Info
    {
        public static void Show()
        {
            System.Console.WriteLine("Info about schools");
        }
    }
}

namespace Universities
{
    class Info
    {
        public static void Show()
        {
            System.Console.WriteLine("Info about universities");
        }
    }
}

namespace IPCS_04_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Schools.Info.Show();
            Universities.Info.Show();
        }
    }
}
