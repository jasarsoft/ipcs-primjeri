using System;

namespace IPCS_28_V3
{
    class Calculator : Operands, Operations
    {
        public double a;
        public double b;

        public double Add()
        {
            return a + b;
        }

        public double Sub()
        {
            return a - b;
        }

        public void SetOperands(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
