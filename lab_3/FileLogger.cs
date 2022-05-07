using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp11
{
    class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            stream = new FileStream(path, FileMode.Append);

            writer = new StreamWriter(stream, Encoding.UTF8);
        }
        ~FileLogger()
        {
            this.Dispose();
        }
        public override void Dispose()
        {
            if (this.disposed)
            {
                writer.Dispose();
                stream.Dispose();
                writer.Close();
                stream.Close();
            }
        }
    }
}
