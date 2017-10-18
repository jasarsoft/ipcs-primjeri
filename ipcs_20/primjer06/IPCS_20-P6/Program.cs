using System;
using System.IO;

namespace IPCS_20_P6
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinationFilePath = "myFile.bin";

            FileStream destFile = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(destFile);

            int intValue = 999999999;

            writer.Write(intValue);
            writer.Close();
            destFile.Close();
        }
    }
}
