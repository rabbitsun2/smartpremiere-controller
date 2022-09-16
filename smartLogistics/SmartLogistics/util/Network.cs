using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.util
{
    internal class Network
    {
        public static string GetMyIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string clientIP = string.Empty;
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    clientIP = host.AddressList[i].ToString();
                }
            }
            return clientIP;
        }
    }
}
