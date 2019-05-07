using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLogger();
            LogManager.Logger = new FileLogger();
            TestLogger();
            LogManager.Logger = new NullLogger();
            TestLogger();
        }

        public static void TestLogger()
        {
            Console.WriteLine("Logger type is "+LogManager.Logger);
            LogManager.Info("this is an Info message");
            LogManager.Debug("this is a Debug message");
            LogManager.Error("this is an error message");
            Console.WriteLine("\t---");
        }
    }
}

