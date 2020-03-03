using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GameField
{
    class Server
    {
        public IPAddress Ip { get; set; }
        public IPEndPoint IPEndPoint{ get; set; }

        public Server(string ip, int port)
        {
            Ip = IPAddress.Parse(ip);
            IPEndPoint = new IPEndPoint(Ip, port);
        }
        public void ServerStart()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
           

            s.Bind(IPEndPoint);
            s.Listen(10);
            Console.WriteLine("IpAddress: " + IPEndPoint.Address + ", port: " + IPEndPoint.Port);
            Console.WriteLine("Server started.");
            Socket socket;
            try
            {
                while (true)
                {
                    socket = s.Accept();
                    Console.WriteLine("Подскючился: " + socket.RemoteEndPoint.ToString() + " Time: " + DateTime.Now.ToString());
                    socket.Send(Encoding.ASCII.GetBytes("server on"));
                    socket.Shutdown(SocketShutdown.Both);
                    Console.WriteLine("Отключился: " + socket.RemoteEndPoint.ToString() + " Time: " + DateTime.Now.ToString());
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
