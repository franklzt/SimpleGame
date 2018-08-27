using log4net;
using System.IO;

namespace GameLibWindow
{
    public class SimpleHelper
    {
        public static void SimpleLog(string log, params object[] args)
        {
            string logString = string.Format(log,  args);
            LogManager.GetLogger("UserLog").Debug(logString);
        }
        
        public static string GetGameLibPath(string PathAddon)
        {
            string systemCurrentDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string LibProjgectPath = string.Format("{0}\\GameLib\\{1}\\", systemCurrentDir, PathAddon);
            if(!Directory.Exists(LibProjgectPath))
            {
                Directory.CreateDirectory(LibProjgectPath);
            }
            return LibProjgectPath;
        }

        public static string GetGameLibFilePath(string PathAddon)
        {
            string systemCurrentDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string LibProjgectPath = string.Format("{0}\\GameLib\\{1}", systemCurrentDir, PathAddon);
            return LibProjgectPath;
        }
    }
}
