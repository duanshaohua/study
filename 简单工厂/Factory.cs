using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 工厂
    /// </summary>
    public class Factory
    {

        #region 通过参数来创建接口对象
        /// <summary>
        /// 通过参数来创建接口对象
        /// </summary>
        /// <param name="type">类型参数</param>
        /// <returns></returns>
        public static IRace CreateInstance(RaceType type)
        {            
            switch (type)
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Orc:
                    return new Orc();
                default:
                    throw new Exception("wrong raceType");
            }
            
        }
        #endregion

        #region 通过配置文件来创建接口对象
        private static string RaceTypeConfig = ConfigurationManager.AppSettings["RaceTypeConfig"];
        /// <summary>
        /// 通过配置文件来创建接口对象
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IRace CreateInstanceConfig()
        {
            switch ((RaceType)Enum.Parse(typeof(RaceType),RaceTypeConfig))
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Orc:
                    return new Orc();
                default:
                    throw new Exception("不存在的种族");
            }

        }
        #endregion

        #region 通过反射来创建接口对象
        private static string RaceTypeReflect = ConfigurationManager.AppSettings["RaceTypeReflect"];
        /// <summary>
        /// 通过反射来创建接口对象
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IRace CreateInstanceReflect()
        {
            string assemblyName = RaceTypeReflect.Split(',')[0];
            string typeName = RaceTypeReflect.Split(',')[1];
            return (IRace)(Activator.CreateInstance(assemblyName, typeName).Unwrap());
        }
        #endregion

        #region 种族类型
        /// <summary>
        /// 种族类型
        /// </summary>
        public enum RaceType
        {
            /// <summary>
            /// 人族
            /// </summary>
            Human,
            /// <summary>
            /// 兽族
            /// </summary>
            Orc,
            /// <summary>
            /// 不死族
            /// </summary>
            Undead,
            /// <summary>
            /// 暗夜精灵
            /// </summary>
            NE
        }
        #endregion
    }
}
