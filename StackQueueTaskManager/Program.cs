using BenchmarkDotNet.Running;

namespace StackQueueTaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<TaskManagerBenchmark>();
            Console.WriteLine(summary);
        }
    }
    
}
