using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class SocketLogger : ILogger
    {
        private int port;
        private string host;

        public SocketLogger(string host, int port)
        {
            this.port = port;
            this.host = host;
        }

        public void Dispose()
        {

        }

    }
}
