using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            
            单例类 单例 = 单例类.创建单例模式();
            单例.日志();
            单例.日志();
            单例.日志();
            单例.日志();

            Console.ReadKey();

        }
    }
}
