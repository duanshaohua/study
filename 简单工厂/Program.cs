using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("这里是魔兽世界");

            #region 原始创建法
            Console.WriteLine("****************原始创建法*****************");
            //创建人类对象
            Human original_human = new Human();
            original_human.ShowKing();
            //创建兽类对象
            Orc original_orc = new Orc();
            original_orc.ShowKing();
            #endregion

            #region 接口创建法
            Console.WriteLine("****************接口创建法*****************");
            //创建人类对象
            IRace interface_human = new Human();
            interface_human.ShowKing();
            #endregion

            #region 工厂参数创建法
            Console.WriteLine("****************工厂参数创建法*****************");
            //创建人类对象
            IRace factory_human = Factory.CreateInstance(Factory.RaceType.Human);
            factory_human.ShowKing();
            #endregion

            #region 工厂配置文件创建法
            Console.WriteLine("****************工厂配置文件创建法*****************");
            IRace factory_config_human = Factory.CreateInstanceConfig();
            factory_config_human.ShowKing();
            #endregion

            #region 工厂配置文件反射创建法
            Console.WriteLine("****************工厂配置文件反射创建法*****************");
            IRace factory_reflect_human = Factory.CreateInstanceReflect();
            factory_reflect_human.ShowKing();
            #endregion

            Console.Read();
        }
    }
}
