using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Socket客户端";
            #region 与服务端通信
            try
            {
                //创建一个大小为1024字节的字节数组
                byte[] recivedBytes = new byte[1024];
                //指定要连接的服务器的IP地址
                IPAddress ipAddress = IPAddress.Parse("139.196.242.14");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 2112);
                Console.WriteLine("正在创建连接对象...");
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(ipEndPoint);
                Console.WriteLine("成功地连接到服务器【{0}】", sender.RemoteEndPoint);
                string userCommand = "";
                int count = 0;
                while (userCommand != "exit")
                {
                    count++;
                    Console.WriteLine("请输入您的指令");
                    Console.Beep();
                    userCommand = Console.ReadLine();
                    sender.Send(ToBytes(userCommand));
                    int totalBytesReceived = sender.Receive(recivedBytes);
                    Console.WriteLine("第{0}次输入{1}", count, userCommand);
                    Console.WriteLine("服务器返回的消息:{0}，字节数：{1}", Encoding.UTF8.GetString(recivedBytes, 0, totalBytesReceived), totalBytesReceived);
                }
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                Console.Read();
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.Message);
            }
            #endregion            
        }
        /// <summary>
        /// 将字符串转换为字节数组
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static byte[] ToBytes(string msg)
        {
            return Encoding.UTF8.GetBytes(msg);// + "[FINAL]"
        }
    }
}
