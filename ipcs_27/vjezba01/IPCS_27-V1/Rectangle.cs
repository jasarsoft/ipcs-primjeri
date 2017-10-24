using System;

namespace IPCS_27_V1
{
    class Rectangle : Shape
    {
        public double a;
        public double b;
        
        public double Area()
        {
            return a * b;
        }
    }
}
