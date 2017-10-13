using System;

namespace IPCS_12_V4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] status = { "stopped", "moving", "lost", "turned off", "sos" };
            string currentStatus = status[0];
            int speed = 25;

            if (currentStatus == "moving")
            {
                if (speed > 20)
                    Console.WriteLine("Speed limit broken");
                else
                    Console.WriteLine("Speed limit ok");
            }
            else
                Console.WriteLine(currentStatus);
        }
    }
}
