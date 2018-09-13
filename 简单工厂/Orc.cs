using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 兽类
    /// </summary>
    public class Orc: IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("这里是兽类的国王");
        }
    }
}
