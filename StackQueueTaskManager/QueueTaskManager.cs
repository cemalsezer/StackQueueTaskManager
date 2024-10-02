using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTaskManager
{
    public class QueueTaskManager
    {
        private readonly Queue<string> taskQueue;

        public QueueTaskManager()
        {
            taskQueue = new Queue<string>();
        }

        public void AddTask(string task)
        {
            taskQueue.EnQueue(task);
        }

        public string ProcessTask()
        {
            return taskQueue.DeQueue();
        }

        public int TaskCount => taskQueue.Count;
    }
}
