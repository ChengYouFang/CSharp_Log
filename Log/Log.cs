using System;
using System.IO;

namespace CYFang.Log
{
    public static class Log
    {
        public static string FilePath { set; get; }

        public static void writeLog(string message)
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
    }
}