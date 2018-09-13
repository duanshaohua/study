using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyReflecton
{
    /// <summary>
    /// 动态加载DLL文件
    /// 通过反射获取信息，创建对象，调用方法
    /// 实现程序的可配置
    /// 
    /// 依赖接口，完成可配置可扩展
    /// 去掉接口，反射调用方法，包括私有方法
    /// 反射破坏单例（因为它可以调用私有方法和私有构造函数）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //反射的入口，动态的加载DLL（DLL文件存放在bin/debug）
            Assembly assembly = Assembly.Load("DshCms.Common");
            //基于类的完整名称，找出类型
            Type type = assembly.GetType("DshCms.Common.DESEncrypt");
            //根据类型，创建对象
            object obj = Activator.CreateInstance(type);

            //在使用接口时，然后将对象强制转换为类，完成方法的调用



            //
            foreach (Module m in assembly.GetModules())
            {
                Console.WriteLine(m.FullyQualifiedName);
            }
            //循环找出方法
            foreach (MethodInfo mi in type.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }



            //调取无参方法
            //MethodInfo Encrypt = type.GetMethod("Encrypt");
            //Encrypt.Invoke(obj, null);

            //调取有参且没有重载的方法
            //MethodInfo Encrypt = type.GetMethod("Encrypt");
            //Encrypt.Invoke(obj,new object[] { "sdfds"});单个参数
            //Encrypt.Invoke(obj,new object[] { "sdfds",10});多个参数

            //调取有重载的方法
            MethodInfo Encrypt = type.GetMethod("Encrypt", new Type[] { typeof(string) });
            string result = Encrypt.Invoke(obj, new object[] { "sdfds" }).ToString();


            //访问私有方法
            //MethodInfo Encrypt = type.GetMethod("Encrypt", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            Console.WriteLine(result);

            Console.ReadKey();


            
        }
    }
}
