using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPatternDemo
{
    class ConsoleLogger:ILogger
    {
        

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        
    }
}
