using System;
using System.Linq;

namespace EmpaticaBLEClient
{
    // State object for receiving data from remote device.

    public class Program
    {
        static void Main(string[] args)
        {
            if (args.FirstOrDefault() == "--help")
            {
                Console.WriteLine();
                Console.WriteLine("********** Empatica streaming server client **********");
                Console.WriteLine("For the communication protocol and the list of commands, please visit");
                Console.WriteLine("http://empatica.github.io/windows-ble-server.html");
                return;
            }

            Console.WriteLine("Press ENTER to connect to E4 streaming server");
            Console.ReadKey();

            AsynchronousClient.StartClient();

            Console.ReadKey();
        }
    }
}
