using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace 核心语法库
{
    public class 反射
    {
        /// <summary>
        /// 反射用法
        /// </summary>
        public void Usage()
        {
            Assembly assembly = Assembly.Load("class.dll");//动态加载DLL （DLL文件需放在项目的Debug目录中）
            #region Module（模块）
            Module[] modules = assembly.GetModules();
            foreach(Module module in modules)
            {
                Console.WriteLine(module.Name);
            }
            #endregion
            #region Type（类型）
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(type.Name);
            }
            #endregion 
            //找出具体类型（完全的类名称）
            Type typeHelper = assembly.GetType("class.Name");
            //创建对象
            object oHelper = Activator.CreateInstance(typeHelper);
            //转换对象（需要用到类接口）

            //调用方法
        }
    }
}
