using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Application
    {
        private IGUIFactory _factory;
        private IButton _button;
        private ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _factory = factory;
        }

        public void Start()
        {
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();

            _button.Click();
            Console.ReadKey();
        }
    }
}
