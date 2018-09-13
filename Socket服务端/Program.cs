using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    /// <summary>
    /// 一对一链接
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //设置服务器的IP地址
            int port = 6000;
            string host = "120.27.113.46";
            IPAddress ip = IPAddress.Parse(host);
            IPEndPoint ipe = new IPEndPoint(ip, port);
            //声明一个套接字（称为监听套接字）
            Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //为套接字关联端点信息（服务器地址）
            ServerSocket.Bind(ipe);
            //设置监听队列
            ServerSocket.Listen(1);
            Console.WriteLine("监听已经打开，请等待");

            //与客户端建立链接
            Socket ClientSocket = ServerSocket.Accept();
            Console.WriteLine("客户端：{0}，连接已经建立", ((IPEndPoint)ClientSocket.RemoteEndPoint).Address.ToString());
            //接收客户端消息
            string recStr = "";
            byte[] recByte = new byte[4096];
            int bytes = ClientSocket.Receive(recByte, recByte.Length, 0);
            recStr += Encoding.UTF8.GetString(recByte, 0, bytes);
            Console.WriteLine("服务器端获得信息:{0}，IP{1}", recStr, ((IPEndPoint)ClientSocket.RemoteEndPoint).Address.ToString());
            //向客户端发送消息（此处是将接收到消息原样返回给客户端）
            string sendStr = "服务器发送到客户端的消息 :" + recStr;
            byte[] sendByte = Encoding.UTF8.GetBytes(sendStr);
            ClientSocket.Send(sendByte, sendByte.Length, 0);
            Console.Read();
            //关闭链接，释放资源
            ClientSocket.Close();
            ServerSocket.Close();
        }
    }
}
