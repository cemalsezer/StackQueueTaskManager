﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueTaskManager
{
    public class Queue<T>
    {
        private readonly IQueue<T> queue;
        public int Count => queue.Count;
        public Queue(QueueType type = QueueType.Array)
        {
            if (type == QueueType.Array)
            {
                queue = new ArrayQueue<T>();
            }
        }
        public void EnQueue(T value)
        {
            queue.Enqueue(value);
        }
        public T DeQueue()
        {
            return queue.DeQueue();
        }
        public T Peek()
        {
            return queue.DeQueue();
        }
    }
    public interface IQueue<T>
    {
        int Count { get; }
        void Enqueue(T value);
        T DeQueue();
        T Peek();
    }
    public enum QueueType
    {
        Array = 0,

    }
}

