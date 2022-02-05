namespace SingletonPattern
{
    public sealed class SingletonLazy
    {
        private static SingletonLazy _instance;
        private static readonly object _lock = new object();

        private SingletonLazy()
        {
        }

        public string Value { get; set; }

        public static SingletonLazy GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonLazy();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
    }
}
