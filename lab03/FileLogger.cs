using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
System.IO

namespace lab03
{
    class FileLogger : ILogger
    {

        FileStream stream = new FileStream("log.txt", FileMode.Append);
        writer = new StreamWriter(stream);
        public void Dispose()
        {

        }
    }
}
