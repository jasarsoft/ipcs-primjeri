using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_32_P1
{
    public class Vector
    {
        public int X;
        public int Y;


        //konstruktor bez parametara
        public Vector() {}

        //konstruktor sa prametrima
        public Vector(int i, int j)
        {
            X = i;
            Y = j;
        }

        //prekoracenje za binrni operator +
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
}
