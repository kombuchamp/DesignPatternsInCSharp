using System;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;
            Console.WriteLine($"instance1 == instance2 ? {ReferenceEquals(instance1, instance2)}\n");

            int taskCount = 10;
            var tasks = new Task<ThreadSafeSingleton>[taskCount];
            Console.WriteLine($"Running {taskCount} Tasks acquiring ThreadSafeSingleton instance on {Environment.ProcessorCount} cores...\n");
            for (int i = 0; i < taskCount; i++)
            {
                tasks[i] = Task.Run(() => ThreadSafeSingleton.Instance);
            }
            Task.WaitAll(tasks);
            Console.WriteLine("\nDone");
            foreach (var task in tasks)
            {
                Console.WriteLine($"Task #{task.Id}, instance wtih hash code: {task.Result.GetHashCode()}");
            }
        }
    }
}
