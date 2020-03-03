using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace GameField
{
    class Programcs
    {
        static void Main(string[] args)
        {
            Server server = new Server("127.0.0.1", 1024);
            server.ServerStart();
        }

    
    }
}


