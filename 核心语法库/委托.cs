using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核心语法库
{
    /// <summary>
    /// 一’声明委托（也可与类并列）
    /// </summary>
    public delegate void NoParaNoReturnOutClass();
    public class 委托
    {
        //一’声明委托
        public delegate void NoParaNoReturn();//无参数无返回值
        public delegate string NoParaWithReturn();//无参数有返回值
        public delegate void WithParaNoReturn(string str);//有参数无返回值        
        public delegate void WithParaWithReturn(string str);//有参数有返回值

        /// <summary>
        /// 二‘委托的使用
        /// </summary>
        public void Usage()
        {
            #region 调用无参数无返回值的委托
            //委托的实例化
            NoParaNoReturnOutClass method = new NoParaNoReturnOutClass(Example);
            //委托实例的调用
            method.Invoke();
            //也可这样调用
            method();
            #endregion

            #region 调用无参数有返回值的委托
            NoParaWithReturn NoParaWithReturnMethod = new NoParaWithReturn(Examples);
            //接收返回值
            string result = NoParaWithReturnMethod.Invoke();
            #endregion

            #region 调用有参数无返回值的委托
            WithParaNoReturn WithParaNoReturnMethod = new WithParaNoReturn(Example);
            
            string str = string.Empty;
            //传递参数
            WithParaNoReturnMethod(str);
            #endregion

            #region 多播委托
            NoParaNoReturn multicast = new NoParaNoReturn(Example);
            //按顺序添加到方法列表
            multicast += Example;
            multicast += Example;
            multicast += Example;
            //从方法列表的尾部去掉且只去掉一个完全相同的方法
            multicast -= Example;
            #endregion
        }

        #region 示例方法（委托调用）
        /// <summary>
        /// 无参数无返回值
        /// </summary>
        public void Example()
        {
            //处理程序
        }
        /// <summary>
        /// 有参数无返回值
        /// </summary>
        public void Example(string str)
        {
            //处理程序
        }
        /// <summary>
        /// 无参数有返回值
        /// </summary>
        /// <param name="str"></param>
        public string Examples()
        {
            //处理程序
            return "";
        }
        /// <summary>
        /// 有参数有返回值
        /// </summary>
        /// <param name="str"></param>
        public string Example(string str,string str2)
        {
            //处理程序
            return "";
        }
        #endregion 
    }
}
