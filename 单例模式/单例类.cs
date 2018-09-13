using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// sealed关键字为密封类
    /// 目标：只能创建一个对象（只能实例化一次）
    /// 利用锁来创建单例
    /// </summary>
    public sealed class 单例类
    {
        private static int BuildCount = 0;
        private static int CreateCount = 0;
        private static int MethodCount = 0;
        /// <summary>
        /// 内部静态对象
        /// </summary>
        private static 单例类 singleton = null;
        /// <summary>
        /// 私有化构造函数，不让外面随意创建对象
        /// </summary>
        private 单例类()
        {
            单例类.BuildCount++;
            Console.WriteLine("单例模式第{0}次执行构造函数", 单例类.BuildCount);
        }

        private static object Lock = new object();
        /// <summary>
        /// 静态方法获取对象实例
        /// </summary>
        /// <returns></returns>
        public static 单例类 创建单例模式()
        {
            //检测singletonOne是否为空,保证第一次创建后，不再等待锁
            if (singleton == null)
            {
                //加锁
                lock (Lock)
                {
                    //Thread.Sleep(1000);
                    //二次检测singletonOne是否为空，保证单例
                    if (singleton == null)
                    {
                        singleton = new 单例类();
                    }
                }
            }
            单例类.CreateCount++;
            Console.WriteLine("单例模式第{0}次执行创建单例模式", 单例类.CreateCount);
            return singleton;
        }

        public void 日志()
        {
            单例类.MethodCount++;
            Console.WriteLine("我是第{0}次调用，但是我是第{1}次构造的对象", 单例类.MethodCount, 单例类.BuildCount);
        }
    }
    /// <summary>
    /// 利用静态构造函数创建单例
    /// </summary>
    public class 单例模式二
    {
        /// <summary>
        /// 内部静态对象
        /// </summary>
        private static 单例模式二 singleton = null;
        /// <summary>
        /// 私有化构造函数，不让外面随意创建对象
        /// </summary>
        private 单例模式二()
        {
            Console.WriteLine("这里是构造函数");
        }
        /// <summary>
        /// 静态构造函数，该类第一次使用时执行，且只执行一次
        /// </summary>
        static 单例模式二()
        {
            Console.WriteLine("单例模式静态构造函数");
            singleton = new 单例模式二();
        }
        /// <summary>
        /// 静态方法获取对象实例
        /// </summary>
        /// <returns></returns>
        public static 单例模式二 创建单例模式()
        {
            Console.WriteLine("这里是创建单例模式");
            return singleton;
        }
    }
    /// <summary>
    /// 利用静态变量
    /// </summary>
    public class 单例模式三
    {
        /// <summary>
        /// 内部静态对象，程序会永久创建一次
        /// </summary>
        private static readonly 单例模式三 singleton = null;
        /// <summary>
        /// 私有化构造函数，不让外面随意创建对象
        /// </summary>
        private 单例模式三()
        {
            Console.WriteLine("这里是构造函数");
        }
        /// <summary>
        /// 静态方法获取对象实例
        /// </summary>
        /// <returns></returns>
        public static 单例模式三 创建单例模式()
        {
            Console.WriteLine("这里是创建单例模式");
            return singleton;
        }
    }
}
