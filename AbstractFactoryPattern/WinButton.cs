using System;

namespace AbstractFactoryPattern
{
    class WinButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("WinButton was clicked!");
        }
    }
}
