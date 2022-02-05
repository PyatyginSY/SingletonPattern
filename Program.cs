using System;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("SingletonPattern");

            var processFirst = new Thread(() =>
            {
                TestSingletonLazy("FOO");
            });
            var processSecond = new Thread(() =>
            {
                TestSingletonLazy("BAR");
            });
            var processThird = new Thread(() =>
            {
                TestSingleton();
            });
            var processFourth = new Thread(() =>
            {
                TestSingleton();
            });

            processFirst.Start();
            processSecond.Start();
            processThird.Start();
            processFourth.Start();

            processFirst.Join();
            processSecond.Join();
            processThird.Join();
            processFourth.Join();
        }

        public static void TestSingletonLazy(string value)
        {
            var singleton = SingletonLazy.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        public static void TestSingleton()
        {
            var singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.Value);
        }
    }
}
