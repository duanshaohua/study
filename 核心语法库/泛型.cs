using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核心语法库
{
    public class 泛型
    {
        #region 泛型的定义

        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void Generic<T>(T t)
        {
            //处理程序
        }
        /// <summary>
        /// 泛型方法（多个类型参数）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="W"></typeparam>
        /// <param name="t"></param>
        /// <param name="s"></param>
        /// <param name="w"></param>
        public static void Generic<T, S, W>(T t,S s,W w)
        {
            //处理程序 
        }
        /// <summary>
        /// 泛型方法（应用于返回值）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T Generic<T>(T t,int i)
        {
            return default(T);
        }
        /// <summary>
        /// 泛型约束方法（约束参数必须为People类）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void GenericConstraint<T>(T t) where T: People
        {
            //处理程序            
        }

        #endregion

        #region 泛型的用法

        /// <summary>
        /// 泛型的用法
        /// </summary>
        public void GenericUse()
        {
            //泛型方法的用法
            int ia = 1;
            Generic<int>(ia);
            string str = "abc";
            Generic<string>(str);
            //泛型约束方法的用法
            People people = new People()
            {
                Id = 11,
                Name = "dsh",
                Age = 25
            };
            Generic(people);
        }

        #endregion 

        #region 辅助

        /// <summary>
        /// 人类
        /// </summary>
        public class People
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public void SayHi()
            {
                Console.WriteLine("{0}说，你好。", this.Name);
            }
        }

        #endregion 
    }
}
