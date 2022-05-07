using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}
