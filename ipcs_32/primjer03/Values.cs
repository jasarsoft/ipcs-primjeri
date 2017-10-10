using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_3
{
    //deklarisimo klasu u kojoj ce konverzioni operator biti definisan
    class Values
    {
        public int x;
        public int y;
        public int z;

        //definisimo konstrukotr za klasu Values koji ne uzima argumente
        public Values() { }

        //definisimo konstruktor za klasu Values koji uzima arguemnte
        public Values(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //definisimo implicitnu konverziju iz Values u int
        //public static implicit operator int(Values op1)
        //{
        //    return op1.x * op1.y * op1.z;
        //}

        //definisimo eksplicitnu konverziju iz Values u int
        public static explicit operator int(Values op1)
        {
            return op1.x * op1.y * op1.z;
        }
    
    }
}
