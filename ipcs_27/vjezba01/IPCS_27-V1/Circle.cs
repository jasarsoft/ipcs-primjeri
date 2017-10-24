using System;

namespace IPCS_27_V1
{
    class Circle : Shape
    {
        public double r;
        public readonly double PI = 3.14;

        public double Area()
        {
            return r * r * PI;
        }
    }
}
