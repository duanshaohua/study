using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核心语法库
{

    public class 任务工厂
    {
        /// <summary>
        /// 用法用例
        /// </summary>
        public void Usage()
        {
            TaskFactory taskFactory = new TaskFactory();//任务工厂
            //创建10个线程
            for (int i = 0; i < 10; i++)
            {
                Action action = new Action(Task);
                //启动一个线程去，创建对象
                taskFactory.StartNew(action);
            }
        }
        /// <summary>
        /// 空任务方法
        /// </summary>
        public void Task() { }
    }
}
