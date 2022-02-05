namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        static Singleton()
        {
        }

        private Singleton()
        {
            Value = System.DateTime.Now.TimeOfDay.ToString();
        }

        public string Value { get; private set; }

        public static Singleton GetInstance()
        {
            return _instance;
        }
    }
}
