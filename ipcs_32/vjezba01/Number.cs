using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_1
{
    class Number
    {
        private int value;

        public Number(int val)
        {
            value = val;
        }

        public static Number operator+(Number arg1, Number arg2)
        {
            return new Number(arg1.value + arg2.value);
        }

        //deklarisemo prekoracenje operatora *
        //nad jednim operandom tima Number i drugim tima int
        public static Number operator* (Number one, int two)
        {
            return new Number(one.value * two);
        }
    }
}
