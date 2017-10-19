using System;


namespace IPCS_26_P5
{
    public static class MyExtension
    {
        //kreiranje ekstenzionog metoda
        public static string up(this String str)
        {
            if (str.Length > 5)
                return str.ToUpper();
            else
                return str;
        }
    }
}
