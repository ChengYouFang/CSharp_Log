using System;
using System.IO;

namespace CYFang.Log
{
    public static class Log
    {
        //F6
        public static string FilePath { set; get; }

        public static void WriteLog(string message)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                FilePath = Directory.GetCurrentDirectory();
            }

            string filename = FilePath + string.Format("\\{0:yyyy}\\{0:MM}\\{0:yyyy-MM-dd}.txt", DateTime.Now);
            FileInfo info = new FileInfo(filename);
            if (info.Directory.Exists == false)
            {
                info.Directory.Create();
            }
            string log = message + Environment.NewLine;
            File.AppendAllText(FilePath, log);
        }

        public static void WriteLog(string tag, string message)
        {
            WriteLog(tag + ":" + message);
        }
    }
}