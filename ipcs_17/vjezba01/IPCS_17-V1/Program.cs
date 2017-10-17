using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPCS_17_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string[] files = { "myFirstFile.txt", "mySecondFile.txt", "myThirdFile.txt" };

            //try
            //{
            //    s = File.ReadAllText(files[0]);
            //}
            //catch (Exception ex)
            //{
            //    try
            //    {
            //        s = File.ReadAllText(files[1]);
            //    }
            //    catch 
            //    {
            //        try
            //        {
            //            s = File.ReadAllText(files[2]);
            //        }
            //        catch
            //        {
            //            s = "File does not exist";
            //        }
            //    }
            //}

            foreach(string fname in files)
            {
                try
                {
                    s = File.ReadAllText(fname);
                    break;
                }
                catch (Exception ex)
                {
                    s = "File does not exist";
                }
            }

            Console.WriteLine(s);
        }
    }
}
