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
        static void Main(string[] args)
        {
            try
            {
                //把ip地址转换为实例  
                IPAddress ipa = IPAddress.Parse("139.196.242.14");
                //监听端口8001  
                TcpListener mylsn = new TcpListener(ipa, 8001);
                //开启监听  
                mylsn.Start();
                //输出监听成功的信息  
                Console.WriteLine("在8001启动服务，等待连接");
                //等待处理接入连接请求
                int i = 0;
                while (true)
                {
                    Socket mysock = mylsn.AcceptSocket();
                    Console.WriteLine("第{0}个连接，连接来自{1}", i, mysock.RemoteEndPoint);
                    work w = new work();
                    w.mysock = mysock;
                    w.mylsn = mylsn;
                    Thread t = new Thread(new ThreadStart(w.main));
                    t.Start();
                    i++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("捕获异常：【"+ ex.Message + "】");
            }
            Console.Read();
        }
    }

    class work
    {
        public Socket mysock;
        public TcpListener mylsn;
        public void main()
        {
            //接收客户端消息
            byte[] data = new byte[4096];
            int bytes = mysock.Receive(data, data.Length, 0);
            string client_msg = Encoding.UTF8.GetString(data, 0, bytes);
            Console.WriteLine(client_msg);
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
            if (dic.ContainsKey(client_msg))
            {
                mysock.Send(Encoding.UTF8.GetBytes(dic[client_msg]));
            }
            else {
                mysock.Send(Encoding.UTF8.GetBytes("@没有相应的指定【"+ client_msg + "】"));
            }
            
            //释放资源  
            mysock.Close();
            //mylsn.Stop();
        }
    }
}
