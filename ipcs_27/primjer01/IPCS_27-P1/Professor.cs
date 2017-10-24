using System;

namespace IPCS_27_P1
{
    class Professor : Person
    {
        public string className;

        public void Show()
        {
            Console.WriteLine("Professor class is " + className);
        }
    }
}
