using System;
using System.IO;
using System.Text;

namespace IPCS_20_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream sourceFile = new FileStream("myFile.bin", FileMode.Open, FileAccess.Read);

            //Kreiranje objekata klase BinaryReader i proslijedjivanje FileStream objekta kao parametar;
            BinaryReader reader = new BinaryReader(sourceFile);

            int position = 0; //incijalizacija pocetne pozicije ciljanog niza
            int lenght = (int)reader.BaseStream.Length; //izracunavanje duzine toka;
            byte[] dataCollection = new byte[lenght]; //kreiranje niza u koji ce biti smjesten svaki bajt iz fajla;
            int returnByte; //petlja koja izvrsava citanje sve dok postoje bajtovi (dok marker ne vrati rezultat -1)

            while ((returnByte = reader.Read()) != -1)
            {
                dataCollection[position] = (byte)returnByte; //smjestanje aktuelnog bajta na odgovarajucu poziciju niza
                position += sizeof(byte); //pomjeranje pozicije ciljanog niza za velicinu procitanog podatka
            }
            //zatvaranje otvoreni tokova
            reader.Close();
            sourceFile.Close();

            //prikaz procitanih podataka
            foreach (byte data in dataCollection)
                Console.WriteLine(data.ToString());

        }
    }
}
