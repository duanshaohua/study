using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核心语法库
{
    /// <summary>
    /// 声明一个事件的委托
    /// </summary>
    public delegate void AffairDelegate();
    public class 事件
    {
        /// <summary>
        /// 声明一个事件
        /// </summary>
        public event AffairDelegate AffairEvent;
        /// <summary>
        /// 开始执行事件
        /// </summary>
        public void Run()
        {
            if (AffairEvent != null)
                AffairEvent.Invoke();
        }
        /// <summary>
        /// 使用示例
        /// </summary>
        public void Usage()
        {
            事件 Even = new 事件();
            Even.AffairEvent += Example;
            Even.AffairEvent += Example;
            Even.AffairEvent += Example;
            Even.Run();
        }

        #region 示例方法
        private void Example()
        {
            //处理程序
        }
        #endregion
    }
}
