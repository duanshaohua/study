using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 人类
    /// </summary>
    public class Human: IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("这里是人类的国王");
        }
    }
}
