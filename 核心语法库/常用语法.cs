using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 核心语法库
{
    public class 常用语法
    {
        /// <summary>
        /// 字符串+变量的拼接
        /// </summary>
        public void SplitJoint(string str)
        {
            string a = "英文字符的前三个字母是" + str + "，一起来读";
            string b = string.Format("英文字符的前三个字母是{0}，一起来读", str);
            string c = $"英文字符的前三个字母是{str}，一起来读";
        }
    }
}
