using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibreriaTwinsnet
{
    public static class FileInfoExtension
    {
        public static void WriteText(this FileInfo fileInfo,string contents)
        {            
            File.WriteAllText(fileInfo.FullName, contents);
        }

        public static void AppendAllText(this FileInfo fileInfo, string contents)
        {
            File.AppendAllText(fileInfo.FullName, contents);
        }

    }
}
