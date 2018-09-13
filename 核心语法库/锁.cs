using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核心语法库
{
    public class 锁
    {
        private static object Lock = new object();
        /// <summary>
        /// 给处理程序上锁
        /// </summary>
        public static void Single()
        {
            lock (Lock)
            {
                //处理程序
            }
        }
    }
}
