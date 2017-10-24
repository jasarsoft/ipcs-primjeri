using System;

namespace IPCS_28_P1
{
    class Calculator :Operands, Operations
    {
        public double a;
        public double b;



        public void setOperands(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double add()
        {
            return a + b;
        }
    }
}
