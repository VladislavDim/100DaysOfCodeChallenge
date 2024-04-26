using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack<T>
    {
        private List<T> items;
        public CustomStack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if (items.Count == 0) throw new InvalidOperationException("The stack is empty.");

            T item = items.Last();
            items.RemoveAt(items.Count - 1);

            return item;
        }
        public T Peek()
        {
            if (items.Count == 0) throw new InvalidOperationException("The stack is empty.");

            return items.Last();
        }
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

    }
}
