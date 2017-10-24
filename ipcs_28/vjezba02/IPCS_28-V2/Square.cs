using System;


namespace IPCS_28_V2
{
    class Square : Quad, IGeom
    {
        public double Area()
        {
            return a * a;
        }

        public double Volume()
        {
            return 4 * this.a;
        }

        public override void Setxya(double x, double y, double a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }
    }
}
