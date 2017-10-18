using System;

namespace IPCS_18_P1
{
    class MyExceptionClass : ApplicationException
    {
        private int num;

        public MyExceptionClass(int num1)
        {
            num = num1;
        }

        public override string ToString()
        {
            return ("My exception no " + num);
        }
    }
}
