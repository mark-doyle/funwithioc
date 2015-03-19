using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIoC.Core
{
    public interface ILoggingService
    {
        void Write(string text);
    }
}
