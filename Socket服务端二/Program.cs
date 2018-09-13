using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        public static void SendMessage()
        {
            Socket socket = serverSocket.Accept();
            Console.WriteLine("链接一个客户端:{0}", socket.RemoteEndPoint);
            socket.Send(Encoding.UTF8.GetBytes("欢迎来到服务器"));
            Thread thread = new Thread(ReceiveMessage);
            thread.Start();
        }
        /// <summary>
        /// 接收客户端发来的消息
        /// </summary>
        /// <param name="obj"></param>
        public static void ReceiveMessage(object obj)
        {
            Socket socket = (Socket)obj;
            byte[] data = new byte[1024];
            int len = socket.Receive(data);
            string dataString = Encoding.UTF8.GetString(data, 0, len);
            Console.WriteLine("客户端消息:{0}，来源：{1}", dataString, socket.RemoteEndPoint);
            //Thread thread = new Thread(SendMessage);
            //thread.Start(socket);
            
        }


        static Socket serverSocket;
        static void Main(string[] args)
        {
            //定义接收数据长度变量
            int recv;
            //定义接收数据的缓存
            byte[] data = new byte[1024];
            //定义侦听端口
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 5566);
            //定义套接字类型
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //连接
            serverSocket.Bind(ipEnd);
            //开始侦听
            serverSocket.Listen(10);
            //控制台输出侦听状态
            Console.WriteLine("监听已经打开，请等待");

            //Socket client;
            while (true)
            {
                //一旦接受连接，创建一个客户端
                Socket client = serverSocket.Accept();
                //获取客户端的IP和端口
                IPEndPoint ipEndClient = (IPEndPoint)client.RemoteEndPoint;
                //输出客户端的IP和端口
                Console.WriteLine("客户端IP地址：{0}，端口：{1}", ipEndClient.Address, ipEndClient.Port);
                //定义待发送字符
                string welcome = "欢迎来到我的服务器！";
                //数据类型转换
                data = Encoding.UTF8.GetBytes(welcome);
                while (true)
                {
                    try
                    {
                        //发送
                        client.Send(data, data.Length, SocketFlags.None);
                        //接收数据可以用线程也可以不用
                        //ReceiveMessage(client);
                        Thread thread = new Thread(ReceiveMessage);
                        thread.Start(client);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("发生错误：{0}", ex.Message);
                        client.Close();
                        serverSocket.Close();
                    }
                }                               
                //client.Close();                
            }
            //Console.WriteLine("Disconnect form{0}", ipEndClient.Address);
            //serverSocket.Close();            
        }
    }
}
