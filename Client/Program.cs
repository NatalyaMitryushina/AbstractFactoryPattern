using AbstractFactoryPattern;
using System.Configuration;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = FactoryProvider.GetFactory(ConfigurationManager.AppSettings["OS"]);
            var app = new Application(factory);
            app.Start();
        }
    }
}
