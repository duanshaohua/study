using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //新建客户端套接字  
                TcpClient tclient = new TcpClient();
                //连接服务器  
                if (!tclient.Connected)
                {
                    tclient.Connect("139.196.242.14", 8001);
                }
                Console.WriteLine("输入要发送的消息【】");
                //work w = new work();
                //w.client = tclient;
                //Thread t = new Thread(new ThreadStart(w.main));
                //t.Start();

                //读入要传输的字符  
                string input = Console.ReadLine().Trim();
                Console.WriteLine("【" + input + "】");
                //得到流
                Stream stream = tclient.GetStream();
                //发送字符串 
                byte[] data = Encoding.UTF8.GetBytes(input);
                stream.Write(data, 0, data.Length);
                //接受服务器返回的消息  
                byte[] back = new byte[100];
                int back_length = stream.Read(back, 0, 100);
                string server_msg = Encoding.UTF8.GetString(back, 0, back_length);
                
                //输出服务器返回的消息 
                Console.WriteLine("服务器返回的消息:【" + server_msg + "】");
                
                //关闭连接  
                //client.Close();
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("捕获异常：【" + ex.Message + "】");
            }
            Console.Read();
        }
    }
    class work
    {
        public TcpClient client;
        public void main()
        {
            //读入要传输的字符  
            string input = Console.ReadLine().Trim();
            Console.WriteLine("【" + input + "】");
            //得到流
            Stream stream = client.GetStream();
            //发送字符串 
            byte[] data = Encoding.UTF8.GetBytes(input);
            stream.Write(data, 0, data.Length);
            //接受服务器返回的消息  
            byte[] back = new byte[100];
            int back_length = stream.Read(back, 0, 100);
            //输出服务器返回的消息 
            Console.WriteLine("服务器返回的消息:【" + Encoding.UTF8.GetString(back, 0, back_length) + "】");
            //关闭连接  
            //client.Close();
        }
    }
}
