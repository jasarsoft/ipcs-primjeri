using System;


namespace IPCS_23_P1
{
    public partial class Calc
    {
        partial void ShowResult(int res);

        public void Add(int a, int b)
        {
            ShowResult(a + b);
        }
    }
}
