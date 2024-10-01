using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StackQueueTaskManager
{
    public class ArrayStack<T> : IStack<T>
    {
        public int Count { get; private set; }
        private readonly List<T> list = new List<T>();

        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new Exception("Empty stack!");
            }
            return list[list.Count - 1];
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new Exception("Empty stack!");
            }

            var temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Count--;
            return temp;
        }

        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            list.Add(value);
            Count++;
        }
    }
}
