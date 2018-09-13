using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Socket服务端";
            try
            {
                Console.WriteLine("正在准备服务...");
                //创建一个套接字（寻址方案使用IPV4，传输使用字节流，使用TCP传输协议）
                Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //为套接字绑定一个终结点
                listener.Bind(new IPEndPoint(IPAddress.Any, 2112));
                //使套接字置于侦听状态（挂起的队列的最大长度为10）
                listener.Listen(10);
                Console.WriteLine("服务已就绪，等待在端口2112上的连接...");
                int count = 0;
                while (true)
                {
                    count++;
                    //与客户端生成一个新的连接
                    Socket socket = listener.Accept();
                    Connect connect = new Connect();
                    connect.count = count;
                    connect.socket = socket;
                    Thread t = new Thread(new ThreadStart(connect.contact));
                    t.Start();
                }
                listener.Close();
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        /// <summary>
        /// 根据客户端消息，给出回复
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static string reply(string msg)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["01"] = "算命先生：“你这个人怎么算了命，不给钱就走了？”路人：“难道你没算出来，我现在身无分文吗？”";
            dic["02"] = "晚上十二点不睡等于慢性自杀，不吃早餐等于慢性自杀，经常烧烤等于慢性自杀，长期呆室内等于慢性自杀，缺乏锻炼等于慢性自杀，手机24小时开机等于慢性自杀……我突然发现，我一天啥都没干，专门自杀了。";
            dic["03"] = "课堂上老师叫学生们作一篇作文，题目是：“假如我是经理”。 学生们纷纷动起笔来，唯有一个男生神气十足地抄着手，靠在椅背上。 “你干嘛不写？”老师走到他跟前问道。  学生：“等秘书。”";
            dic["04"] = "“我像你这么大的时候，哪有机会上学呀！没钱，学校也少。”爷爷对上一年级的孙子说。“爷爷，现在有个好机会！您现在替我去上学吧！”";
            dic["05"] = "女婿在丈人面前抱怨自己的妻子如何如何蛮横无理。丈人说：“委屈你了，放心，我一定取消她的遗产继承权！”女婿立刻赔笑声明：“我是开玩笑，您女儿贤淑端庄，天下第一！”";
            dic["06"] = "一位父亲对朋友说：“我无法想象我儿子能够做什么，他是那么不可靠。”朋友说：“那就去气象台搞天气预报吧。";
            dic["07"] = "银行老板办公室养着一缸金鱼。客户说：”太美了，可它不会影响您的工作吗？”“不！完全相反，这儿唯一张开大嘴却不向我要钱的，就是它们了”。";
            dic["08"] = "一天去超市购物，看到一个和尚也在逛超市，额的个神，满满的一购物车，我当时就想该不会是碰到个土豪和尚吧？到收银的时候，妹子问，是现金还是刷卡？和尚双手合十说：阿弥陀佛，贫僧是来化缘的。笑喷……";
            dic["09"] = "天突然下起了雨，看着身边的行人都打了伞，而没有人心疼没有人爱的我却没有伞，心里淡淡的忧伤，于是，大雨中我安慰自己，唱起来那首我最喜爱的歌：打伞的子孙哟……";
            //给客户端发消息
            if (dic.ContainsKey(msg))
            {
                return dic[msg];
            }
            else
            {
                return "@没有相应的指定【" + msg + "】";
            }
        }
        /// <summary>
        /// 连接处理类
        /// </summary>
        class Connect
        {
            /// <summary>
            /// 连接套接字
            /// </summary>
            public Socket socket = null;
            /// <summary>
            /// 连接数
            /// </summary>
            public int count = 0;
            /// <summary>
            /// 通信
            /// </summary>
            public void contact()
            {
                Console.WriteLine("第【{0}】个连接，来自【{1}】", count, socket.RemoteEndPoint);
                string receivedValue = string.Empty;
                while (true)
                {
                    //创建一个大小为1024字节的字节数组
                    byte[] receivedBytes = new byte[1024];
                    //接收客户端发来的消息
                    int numBytes = socket.Receive(receivedBytes);
                    receivedValue = Encoding.UTF8.GetString(receivedBytes, 0, numBytes);
                    Console.WriteLine("第【{0}】个连接的消息【{1}】", count, receivedValue);
                    //向客户端回复消息
                    string replyValue = reply(receivedValue.Replace("[FINAL]", ""));
                    byte[] replyMessage = Encoding.UTF8.GetBytes(replyValue);
                    //发送消息
                    socket.Send(replyMessage);
                    if (receivedValue.IndexOf("[FINAL]") > -1)
                    {
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                        break;
                    }
                }
            }
        }
    }
}
