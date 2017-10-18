using System;
using System.IO;

namespace IPCS_20_P7
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = "myFile.bin";

            FileStream sourceFile = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(sourceFile);
            int value = reader.ReadInt32();
            reader.Close();
            sourcePath.Clone();
            Console.WriteLine(value);
        }
    }
}
