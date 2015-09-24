using System.Net;
using System.Net.Sockets;
using System;
using System.Text;

namespace ServerConsole
{
    class Server
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server is runing ...");
            IPAddress ip = new IPAddress(new byte[] { 127, 0, 0, 1 });
            TcpListener listener = new TcpListener(ip, 8500);

            // 开始监听;
            listener.Start();
            Console.WriteLine("Start Listening ...");

            while(true)
            {
                // 获取一个连接,同步方法;
                TcpClient remoteClient = listener.AcceptTcpClient();
                 
                RemoteClient wapper = new RemoteClient(remoteClient);
                wapper.BeginRead();
            }
         
        }

        // 获得 对象的另外几种常用方法;
        /*  IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
         */
    }

}
