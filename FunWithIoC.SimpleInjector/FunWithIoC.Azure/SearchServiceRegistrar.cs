using FunWithIoC.Core;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIoC.Azure
{
    public class SearchServiceRegistrar : IRegistrar
    {
        public void Register(Container container)
        {
            container.Register<ISearchService, SearchService>();
        }
    }
}
