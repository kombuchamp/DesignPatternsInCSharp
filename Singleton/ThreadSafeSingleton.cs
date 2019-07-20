using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static object syncRoot = new object();
        public static ThreadSafeSingleton Instance
        {
            get
            {
                // Locking is expensive operation, so its better to check twice than lock everytime
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        Console.WriteLine("** Inside lock section **");
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public string Name { get; }

        private ThreadSafeSingleton()
        {
            Name = "ThreadSafeSingleton";
        }
    }
}
