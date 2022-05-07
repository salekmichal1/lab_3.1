using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp11
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            DateTime time = DateTime.Now;
            writer.Write(time.ToString("yyyy-MM-ddTHH:mm:sszzz") + " ");
            for (int i = 0; i < messages.Length; i++)
            {
                writer.Write(messages[i]);
                writer.Flush();
            }
        }

        public abstract void Dispose();
    }
}
