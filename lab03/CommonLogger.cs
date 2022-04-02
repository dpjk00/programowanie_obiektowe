using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class CommonLogger : ILogger
    {
        ILogger[] loggers;
        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Log(params string[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
                Console.WriteLine(messages[i]);
        }

        public void Dispose()
        {

        }
    }
}
