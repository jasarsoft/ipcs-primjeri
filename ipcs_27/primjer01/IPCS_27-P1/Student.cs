using System;

namespace IPCS_27_P1
{
    class Student : Person
    {
        public string indexNumber;

        public void Show()
        {
            Console.WriteLine("Index number is " + indexNumber);
            base.Show();
        }
    }
}
