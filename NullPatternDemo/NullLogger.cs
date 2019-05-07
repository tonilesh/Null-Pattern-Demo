using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPatternDemo
{
    class NullLogger:ILogger
    {
        #region ILogger Members

        public void WriteLine(string message)
        {
            
        }

        #endregion
    }
}
