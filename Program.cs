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
                Console.WriteLine("********** Empatica BLE Client **********");
                Console.WriteLine("For the communication protocol and the list of commands, please visit");
                Console.WriteLine("www.empatica.com/docs/reference_TCP_win.php");
                return;
            }

            Console.WriteLine("Press ENTER to connect to Empatica BLE Server");
            Console.ReadKey();

            AsynchronousClient.StartClient();

            Console.ReadKey();
        }
    }
}
