using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace GameLibWindow
{
    class MessageCodeGenerator : ICodeGenerator
    {
        public void GenerateCode()
        {
            string path = SimpleHelper.GetGameLibPath("MessageCode");
            SimpleHelper.SimpleLog(path);
        }
    }


}
