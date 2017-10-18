using System;
using System.IO;


namespace IPCS_19_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Your firstname: ");
                string firstName = Console.ReadLine();
                Console.Write("Your lastname: ");
                string lastName = Console.ReadLine();

                if (firstName == "" || lastName == "") break;

                File.AppendAllText("users.txt", "fname=" + firstName + "&laname=" + lastName + "|");

                string[] allUsers = File.ReadAllText("users.txt").Split('|');
                Console.WriteLine("Saved users:");
                for (int i = 0; i < allUsers.Length - 1; i++)
                {
                    string[] usrDetails = allUsers[i].Split('&');
                    Console.WriteLine("First name: " + usrDetails[0].Split('=')[1]);
                    Console.WriteLine("Last name: " + usrDetails[1].Split('=')[1]);
                }
            }
        }
    }
}
