using FunWithIoC.Core;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIoC.Main
{
    class Program
    {
        static Container _container;

        static void Main(string[] args)
        {
            _container = new Container();

            HandleRegistration("LoggingRegistrar");
            HandleRegistration("SearchRegistrar");

            ILoggingService loggingService = _container.GetInstance<ILoggingService>();
            loggingService.Write("Testing the logger");
            ISearchService searchService = _container.GetInstance<ISearchService>();
            searchService.Search("Testing the search");


            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }

        static void HandleRegistration(string configKey)
        {
            Console.WriteLine("Reading config for '" + configKey + "'");
            string registrarConfig = ConfigurationManager.AppSettings[configKey];
            Console.WriteLine("Loading type '" + registrarConfig + "'");
            Type registrarType = Type.GetType(registrarConfig, true);
            Console.WriteLine("Activating type '" + registrarType.FullName + "'");
            IRegistrar registrar = (IRegistrar)Activator.CreateInstance(registrarType);

            registrar.Register(_container);

        }
    }
}
