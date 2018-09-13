using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FrozenThroneFactory
    {
        /// <summary>
        /// 创建人族
        /// </summary>
        /// <returns></returns>
        public Human CreateHuman()
        {
            return new Human();
        }
        /// <summary>
        /// 创建兽族
        /// </summary>
        /// <returns></returns>
        public Orc CreateOrc()
        {
            return new Orc();
        }
    }
}
