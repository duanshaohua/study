using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FrozenThroneFactory ractory = new FrozenThroneFactory();
            Human human = ractory.CreateHuman();
            human.ShowKing();

            Console.Read();
        }
    }
}
