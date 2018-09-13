using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 核心语法库
{
    public class 异步
    {
        private delegate void Delegate(string str);
        /// <summary>
        /// 异步方法
        /// </summary>
        public static void Async()
        {
            Console.WriteLine("*******Async********");
            for (int i = 0; i < 5; i++)
            {
                string str = string.Format("Async-{0}", i);
                Delegate dele = DoSomething;
                dele.BeginInvoke(str, null, null);
            }
            Console.WriteLine("*******end Async********");
            Console.Read();
        }
        /// <summary>
        /// 异步方法
        /// </summary>
        public static void AsyncAdvanced()
        {
            Console.WriteLine("*******AsyncAdvanced********");
            string str = string.Format("Async-{0}", 1);
            Delegate method = DoSomething;
            
            //第一个参数为委托的参数，第二个参数为异步执行完成后的回调，第三个参数是用户定义的对象（AsyncState）
            AsyncCallback callback = t => Console.WriteLine("这里是AsyncCallback，当前线程ID={0}", Thread.CurrentThread.ManagedThreadId, t.AsyncState);
            IAsyncResult result = method.BeginInvoke(str, callback, "dsh");

            #region 异步等待（让主线程等待）
            //方式一（一直等到结束）
            result.AsyncWaitHandle.WaitOne(-1);
            //方式二（此方式可做进度条）
            while (!result.IsCompleted)
            {
                Thread.Sleep(100);
                Console.WriteLine("请继续等待！");
            }
            //方式三
            method.EndInvoke(result);
            #endregion 

            Console.WriteLine("*******end AsyncAdvanced********");

            #region 接收返回值
            Func<string, long> method_result = GetSomething;
            result = method_result.BeginInvoke(str, callback, "dsh");
            //主线程得到返回值
            long lResult = method_result.EndInvoke(result);
            #endregion 
            Console.Read();
        }
        /// <summary>
        /// 同步方法
        /// </summary>
        public static void Sync()
        {
            Console.WriteLine("*******Sync********");
            for (int i = 0; i < 5; i++)
            {
                string str = string.Format("Sync-{0}", i);
                DoSomething(str);
            }
            Console.WriteLine("*******end Sync********");
            Console.Read();
        }
        /// <summary>
        /// 耗时任务
        /// </summary>
        /// <param name="str"></param>
        public static void DoSomething(string str)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("str={0}，当前线程Id={1}",str,Thread.CurrentThread.ManagedThreadId);
            long lResult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lResult += i;
            }
            Thread.Sleep(1000);
            watch.Stop();
            Console.WriteLine("str={0}，当前线程Id={1}，计算结果是{2}，耗时{3}", str, Thread.CurrentThread.ManagedThreadId, lResult, watch.ElapsedMilliseconds);
        }
        /// <summary>
        /// 耗时任务有返回值
        /// </summary>
        /// <param name="str"></param>
        public static long GetSomething(string str)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("str={0}，当前线程Id={1}", str, Thread.CurrentThread.ManagedThreadId);
            long lResult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lResult += i;
            }
            Thread.Sleep(1000);
            watch.Stop();
            Console.WriteLine("str={0}，当前线程Id={1}，计算结果是{2}，耗时{3}", str, Thread.CurrentThread.ManagedThreadId, lResult, watch.ElapsedMilliseconds);
            return lResult;
        }
    }
}
