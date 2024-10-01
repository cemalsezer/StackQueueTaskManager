using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTaskManager
{
    public class StackTaskManager
    {
        private readonly Stack<string> taskStack;

        public StackTaskManager()
        {
            taskStack = new Stack<string>();
        }

        public void AddTask(string task)
        {
            taskStack.Push(task);
        }

        public string ProcessTask()
        {
            return taskStack.Pop();
        }

        public int TaskCount => taskStack.Count;
    }
}
