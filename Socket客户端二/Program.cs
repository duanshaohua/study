using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        public static void sendMessage(object obj)
        {
            Socket socket = (Socket)obj;
            string input = Console.ReadLine();

            byte[] data = Encoding.UTF8.GetBytes(input);
            socket.Send(data, data.Length, SocketFlags.None);
            //Thread thread = new Thread(new ParameterizedThreadStart(ReceiveMessage));
            //thread.Start(socket);
        }
        public static void ReceiveMessage(object obj)
        {
            Socket socket = (Socket)obj;
            byte[] data = new byte[1024];
            int len = socket.Receive(data);
            string dataString = Encoding.UTF8.GetString(data, 0, len);
            Console.WriteLine("回复消息：{0}，来自：{1}", dataString, socket.RemoteEndPoint);
            //Thread thread = new Thread(new ParameterizedThreadStart(SendMessage));
            //thread.Start(socket);
        }
        static void Main(string[] args)
        {
            //定义发送数据缓存
            byte[] data = new byte[1024];
            //定义字符串，用于控制台输出或输入
            string input, stringData;
            //定义主机的IP及端口
            IPAddress ip = IPAddress.Parse("139.196.242.14");
            IPEndPoint ipEnd = new IPEndPoint(ip, 5566);
            //定义套接字类型
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //尝试连接
            try
            {
                socket.Connect(ipEnd);
            }
            //异常处理
            catch (SocketException e)
            {
                Console.WriteLine("无法连接服务器!");
                Console.WriteLine(e.ToString());
                Console.Read();
                return;
            }
            //定义接收数据的长度
            int recv = socket.Receive(data);
            //将接收的数据转换成字符串
            stringData = Encoding.UTF8.GetString(data, 0, recv);
            //控制台输出接收到的数据
            Console.WriteLine(stringData);
            while (true)
            {
                //Thread thread = new Thread(sendMessage);
                //thread.Start(socket);
                //定义从键盘接收到的字符串
                input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                //将从键盘获取的字符串转换成整型数据并存储在数组中    
                data = Encoding.UTF8.GetBytes(input);
                //发送该数组
                socket.Send(data, data.Length, SocketFlags.None);
                ////如果字符串是"exit"，退出while循环
                //if (input == "exit")
                //{
                //    break;
                //}
                ////对data清零
                //data = new byte[1024];
                ////定义接收到的数据的长度
                //recv = socket.Receive(data);
                ////将接收到的数据转换为字符串
                //stringData = Encoding.ASCII.GetString(data, 0, recv);
                ////控制台输出字符串
                //Console.Write(stringData);
                ////发送收到的数据
                //socket.Send(data, recv, 0);

            }
            Console.WriteLine("与服务器断开链接！");
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();            
        }
    }
}
