using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = Dns.GetHostAddresses("127.0.0.1")[0];

            IPEndPoint iPEndPoint = new IPEndPoint(ip, 1024);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            string answer;
            try
            {
                socket.Connect(iPEndPoint);
                if (socket.Connected)
                {
                    string strSend = "GET\r\n\r\n";
                    socket.Send(Encoding.ASCII.GetBytes(strSend));
                    byte[] buffer = new byte[1024];
                    int i;
                    do
                    {
                        i = socket.Receive(buffer);
                        answer = Encoding.ASCII.GetString(buffer, 0, 1);
                        Console.WriteLine(answer);
                    } while (i > 0);
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
