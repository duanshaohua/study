using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 人族工厂
    /// </summary>
    public class HumanFactory
    {
        public IRace CreateInstance()
        {
            return new Human();
        }
    }
}
