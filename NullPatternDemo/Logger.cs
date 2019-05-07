using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPatternDemo
{
    public class LogManager
    {
        

        private static ILogger _logger=new ConsoleLogger();
        public static ILogger Logger
        {

            get { return _logger; }

            set { _logger = value; }
        }



        public static void Info(string message)
        {
            
            Logger.WriteLine("info:"+message);
        }

        public static void Error(string message)
        {
            Logger.WriteLine("error:" + message);
        }

        public static void Debug(string message)
        {
            Logger.WriteLine("debug:" + message);
        }

    }
}
