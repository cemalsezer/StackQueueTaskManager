using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTaskManager
{
    public class TaskManagerBenchmark
    {
        private const int N = 1000; // Test için görev sayısı
        private StackTaskManager stackManager;
        private QueueTaskManager queueManager;
       
        [GlobalSetup]
        public void Setup()
        {
            stackManager = new StackTaskManager();
            queueManager = new QueueTaskManager();


            for (int i = 0; i < N; i++)
            {
                stackManager.AddTask("Task " + i);
                queueManager.AddTask("Task " + i);
             
            }
        }

        [Benchmark]
        public void StackProcessTasks()
        {
            while (stackManager.TaskCount > 0)
            {
                stackManager.ProcessTask();
            }

        }

        [Benchmark]
        public void QueueProcessTasks()
        {
            while (queueManager.TaskCount > 0)
            {
                queueManager.ProcessTask();
            }
        }
    }
}
