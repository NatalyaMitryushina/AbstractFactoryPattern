using System;

namespace AbstractFactoryPattern
{
    class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacButton was clicked!");
        }
    }
}
