using FunWithIoC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIoC.Azure
{
    public class LoggingService : ILoggingService
    {
        public void Write(string text)
        {
            Console.WriteLine("FunWithIoC.Azure :: LoggingService - " + text);
        }
    }
}
