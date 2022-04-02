using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab03
{
    class FileLogger : ILogger
    {
        private string path = null;
        bool disposed;
        FileStream stream = new FileStream(path, FileMode.Append);
        
        public FileLogger(string path)
        {
            this.path = path;
        }

        public void Dispose()
        {

        }
    }
}
