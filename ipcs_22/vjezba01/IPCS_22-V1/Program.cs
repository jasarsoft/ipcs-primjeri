using System;


namespace IPCS_22_V1
{
    class Program
    {
        enum ServerStatus
        {
            Stopped,
            Running,
            Unknown
        };

        static ServerStatus getStatus(string url)
        {
            string[] pars = url.Split('&');
            foreach (string par in pars)
            {
                string[] split = par.Split('=');

                if (split[0] == "serverStatus")
                    return (Enum.IsDefined(typeof(ServerStatus), split[1])) ? (ServerStatus)Enum.Parse(typeof(ServerStatus), split[1]) : ServerStatus.Unknown;

                //if (par.Split('=')[0] == "serverStatus") return (Enum.IsDefined(typeof(ServerStatus), par.Split('=')[1]))
                //    ? (ServerStatus)Enum.Parse(typeof(ServerStatus), par.Split('=')[1]) : ServerStatus.Unknown;

            }

            return ServerStatus.Unknown;
        }

        static void Main(string[] args)
        {
            string url = "serverId=25&serverName=myname&serverStatus=Stopped";
            Console.WriteLine(getStatus(url));
        }
    }
}
