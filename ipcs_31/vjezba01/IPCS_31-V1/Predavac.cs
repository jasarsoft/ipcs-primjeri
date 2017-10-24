using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_31_V1
{
    public class Predavac
    {
        string[] pred = new string[3];

        public string this[int i]
        {
            get { return pred[i]; }
        }


        public Predavac()
        {
            pred[0] = "Marko Markovic";
            pred[1] = "Pera Perovic";
            pred[2] = "Boza Bozovic";
        }
    }
}
