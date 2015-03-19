using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIoC.Core
{
    public interface IRegistrar
    {
        void Register(Container container);
    }
}
