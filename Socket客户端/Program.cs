using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    /// <summary>
    /// Socket客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int port = 6000;
                string host = "139.196.242.14";//服务器端ip地址

                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);

                //IPAddress.Loopback;

                Socket SocketSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                SocketSocket.Connect(ipe);

                //向服务器发送消息
                string sendStr = Console.ReadLine();
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                SocketSocket.Send(sendBytes);

                //来自服务器的回复
                string recStr = "";
                byte[] recBytes = new byte[4096];
                int bytes = SocketSocket.Receive(recBytes, recBytes.Length, 0);
                recStr += Encoding.UTF8.GetString(recBytes, 0, bytes);
                Console.WriteLine(recStr);

                //clientSocket.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
