using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public static class Print
    {
        private static string path = @"c:\test\log.log";

        public static void PrintToLog(string str)
        {
            File.AppendAllText(path, $"{DateTime.Now}: {str}.\n");
        }
    }
}
