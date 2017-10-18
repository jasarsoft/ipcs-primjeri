using System;
using System.IO;
using System.Text;

namespace IPCS_20_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] dataCollection = { 1, 4, 6, 7, 12, 33, 26, 98, 82, 101 };

            FileStream destFile = new FileStream("myFile.bin", FileMode.Create, FileAccess.Write);

            BinaryWriter writer = new BinaryWriter(destFile);
            foreach (byte data in dataCollection)
            {
                writer.Write(data);
            }
            writer.Close();
            destFile.Close();
        }
    }
}
