using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab03
{
    abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            DateTime dateTime = new DateTime();
            writer.WriteLine(messages);
            writer.Flush();
        }

        public abstract void Dispose();
    }
}
