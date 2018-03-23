using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            Socket newsock = new Socket(AddressFamily.InterNetwork,
            SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            Console.WriteLine("Waiting for a client...");
            IPEndPoint sender = ipep;
            EndPoint Remote = (EndPoint)ipep;
            recv = newsock.ReceiveFrom(data, ref Remote);
            Console.WriteLine("Message received from {0}:", Remote.ToString());
            while (true)
            {
                data = new byte[1024];
                recv = newsock.ReceiveFrom(data, ref Remote);
                string k = Encoding.ASCII.GetString(data, 0, recv);
                if (k == "1") Console.WriteLine(" {0} choose rock ", Remote.ToString());
                if (k == "2") Console.WriteLine(" {0} choose scissors", Remote.ToString());
                if (k == "3") Console.WriteLine(" {0} choose paper", Remote.ToString());
                int n = rd.Next(1, 4);
                if (n == 1) Console.WriteLine("You choose rock");
                if (n == 2) Console.WriteLine("You choose scissors");
                if (n == 3) Console.WriteLine("You choose paper");
                newsock.SendTo(Encoding.ASCII.GetBytes(n.ToString()), recv, SocketFlags.None, Remote);
            }

        }
    }
}

