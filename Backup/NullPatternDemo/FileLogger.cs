using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NullPatternDemo
{
    public class FileLogger:ILogger
    {
        FileStream fs;
        StreamWriter writer;
             
        public FileLogger(string fileName)
        {
            fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(fs);
            writer.AutoFlush = true;
        }

        public FileLogger():this(AppDomain.CurrentDomain.BaseDirectory+"\\logfile.txt")
        {
            
        }

        #region ILogger Members

        public void WriteLine(string message)
        {
            writer.WriteLine(message);
        }

        #endregion
    }
}
