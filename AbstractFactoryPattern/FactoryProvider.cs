namespace AbstractFactoryPattern
{
    public static class FactoryProvider
    {
        public static IGUIFactory GetFactory(string os)
        {
            switch (os)
            {
                case "Windows":
                    return new WinFactory();
                case "MacOS":
                    return new MacFactory();
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
