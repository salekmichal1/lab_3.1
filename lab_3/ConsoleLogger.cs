using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
     class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
        }
        public override void Dispose()
        {
            GC.SuppressFinalize(this);

        }
    }
}
