using System;


namespace IPCS_26_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            User a = new User();
            User b = new User();
            User c = new User();
            User d = new User();

            int totalUserOnline = User.userOnline;
            Console.WriteLine(totalUserOnline);
        }
    }
}
