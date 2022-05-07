using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] Loggers)
        {
            loggers = Loggers;
        }
        public void Log(params string[] messages)
        {
            foreach (ILogger logger in loggers)
            {
                logger.Log(messages);
            }
        }

        public void Dispose() {
            foreach (ILogger logger in loggers)
            {
                logger.Dispose();
            }
        }
    }
}

