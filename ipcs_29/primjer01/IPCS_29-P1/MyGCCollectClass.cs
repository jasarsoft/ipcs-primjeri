using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPCS_29_P1
{
    class MyGCCollectClass
    {
        private const long maxGarbage = 1000;

        public void MakeSomeGarbage()
        {
            Version vt;

            for (int i = 0; i < maxGarbage; i++)
            {
                //kreirati objekte i osloboditi ih da popune memoriju sa nekoristenim objektima
                vt = new Version();
            }
        }
    }
}
