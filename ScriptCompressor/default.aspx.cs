using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yahoo.Yui.Compressor;

namespace ScriptCompressor
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string jsPath = Server.MapPath("/jquery-3.3.1.js");
            //文件内容
            string strContent = File.ReadAllText(jsPath, Encoding.UTF8);

            //初始化
            var js = new JavaScriptCompressor
            {
                CompressionType = CompressionType.None
            };
            //压缩该js
            strContent = js.Compress(strContent);
            //File.WriteAllText(jsPath, strContent, Encoding.UTF8);
            Response.Write(strContent);
            Response.End();
        }
    }
}