using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientConsole
{
    class Client
    {
        const int BufferSize = 8192;
        static void Main(string[] args)
        {
            ConsoleKey key;

            ServerClient client = new ServerClient();
            client.SendMessage();

            Console.WriteLine("\n\n输入\"Q\"键退出。");
            do
            {
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Q);

        }
    }
}
