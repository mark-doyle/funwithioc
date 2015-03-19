using FunWithIoC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIoC.Azure
{
    public class SearchService : ISearchService
    {
        public bool Search(string query)
        {
            Console.WriteLine("FunWithIoC.Azure :: SearchService - " + query);
            return true;
        }
    }
}
